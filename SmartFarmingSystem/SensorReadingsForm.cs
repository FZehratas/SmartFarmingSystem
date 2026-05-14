using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace SmartFarmingSystem
{
    public partial class SensorReadingsForm : Form
    {
        int selectedReadingId = 0;
        string connString = "Host=ep-bold-surf-apre6yz3.c-7.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_nqxUsDFfP10g;SSL Mode=Require;Trust Server Certificate=true;";

        void LoadSensors()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT s.reading_id, f.field_name, s.temperature, s.moisture, s.reading_date
                         FROM sensorreadings s
                         JOIN fields f ON s.field_id = f.field_id";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        void LoadFields()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string q = "SELECT field_id, field_name FROM fields";

                using (var da = new NpgsqlDataAdapter(q, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbField.DataSource = dt;
                    cmbField.DisplayMember = "field_name"; // görünen
                    cmbField.ValueMember = "field_id";     // arka plan (ID)
                }
            }
        }
        private void SensorReadingsForm_Load(object sender, EventArgs e)
        {
            LoadSensors();
            LoadFields();
        }
        public SensorReadingsForm()
        {
            InitializeComponent();
            this.Load += SensorReadingsForm_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO sensorreadings (field_id, temperature, moisture, reading_date)
                         VALUES (
                             (SELECT field_id FROM fields WHERE field_name=@f),
                             @temp, @moist, @date
                         )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@f", cmbField.Text);
                    cmd.Parameters.AddWithValue("@temp", int.Parse(txtTemperature.Text));
                    cmd.Parameters.AddWithValue("@moist", int.Parse(txtMoisture.Text));
                    cmd.Parameters.AddWithValue("@date", dtReadingDate.Value);

                    cmd.ExecuteNonQuery();
                }
            }


            LoadSensors();
            txtTemperature.Clear();
            txtMoisture.Clear();
            cmbField.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["reading_id"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "DELETE FROM sensorreadings WHERE reading_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadSensors();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReadingId == 0)
            {
                MessageBox.Show("Lütfen bir kayıt seç!");
                return;
            }

            if (cmbField.SelectedValue == null)
            {
                MessageBox.Show("Field seçili değil!");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string q = @"UPDATE sensorreadings 
                     SET temperature=@temp,
                         moisture=@moisture,
                         field_id=@field_id,
                         reading_date=@date
                     WHERE reading_id=@id";

                using (var cmd = new NpgsqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@temp", Convert.ToDouble(txtTemperature.Text));
                    cmd.Parameters.AddWithValue("@moisture", Convert.ToDouble(txtMoisture.Text));
                    cmd.Parameters.AddWithValue("@field_id", Convert.ToInt32(cmbField.SelectedValue)); // 💣 FIX
                    cmd.Parameters.AddWithValue("@date", dtReadingDate.Value);
                    cmd.Parameters.AddWithValue("@id", selectedReadingId);

                    cmd.ExecuteNonQuery();
                }
            }

            LoadSensors();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex]; // 💣 BURASI ŞART

                if (row.Cells[0].Value != DBNull.Value)
                    selectedReadingId = Convert.ToInt32(row.Cells[0].Value);

                txtTemperature.Text = row.Cells["temperature"].Value?.ToString();
                txtMoisture.Text = row.Cells["moisture"].Value?.ToString();
                cmbField.Text = row.Cells["field_name"].Value?.ToString();

                var v = row.Cells["reading_date"].Value;
                if (v != DBNull.Value && v != null)
                    dtReadingDate.Value = Convert.ToDateTime(v);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
