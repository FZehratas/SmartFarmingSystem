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
            cmbField.Items.Clear();

            cmbField.Items.Add("Greenhouse A");
            cmbField.Items.Add("Greenhouse B");
            cmbField.Items.Add("Vertical Tower 1");
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
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["reading_id"].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = @"UPDATE sensorreadings 
                             SET temperature=@temp,
                                 moisture=@moist,
                                 reading_date=@date
                             WHERE reading_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@temp", int.Parse(txtTemperature.Text));
                        cmd.Parameters.AddWithValue("@moist", int.Parse(txtMoisture.Text));
                        cmd.Parameters.AddWithValue("@date", dtReadingDate.Value);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadSensors();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtTemperature.Text = row.Cells["temperature"].Value.ToString();
                txtMoisture.Text = row.Cells["moisture"].Value.ToString();
                dtReadingDate.Value = Convert.ToDateTime(row.Cells["reading_date"].Value);
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
    }
}
