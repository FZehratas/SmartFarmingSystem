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
    public partial class CropsForm : Form
    {
        string connString = "Host=ep-bold-surf-apre6yz3.c-7.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_nqxUsDFfP10g;SSL Mode=Require;Trust Server Certificate=true;";
        int selectedCropId = -1;
        public CropsForm()
        {
            InitializeComponent();
            this.Load += CropsForm_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        void LoadCrops()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT c.crop_id, c.crop_name, f.field_name, c.planting_date, c.status
                         FROM crops c
                         JOIN fields f ON c.field_id = f.field_id";

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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCropName1.Text == "" || cmbField.Text == "")
            {
                MessageBox.Show("Boş alan bırakma!");
                return;
            }
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO crops (field_id, crop_name, planting_date, status)
                 VALUES (
                     (SELECT field_id FROM fields WHERE field_name=@f LIMIT 1),
                     @name, @date, @status
                 )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@f", cmbField.Text);
                    cmd.Parameters.AddWithValue("@name", txtCropName1.Text);
                    cmd.Parameters.AddWithValue("@date", dtPlantingDate.Value);
                    cmd.Parameters.AddWithValue("@status", "New");

                    cmd.ExecuteNonQuery();
                }
            }

            LoadCrops();
        }

        private void CropsForm_Load(object sender, EventArgs e)
        {
            LoadCrops();
            LoadFields();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedCropId = Convert.ToInt32(row.Cells[0].Value); // crop_id

                txtCropName1.Text = row.Cells[1].Value.ToString();
                cmbField.Text = row.Cells[2].Value.ToString();

                var v = row.Cells[3].Value;
                if (v is DateTime dt) dtPlantingDate.Value = dt;
                else if (v is DateOnly d) dtPlantingDate.Value = d.ToDateTime(TimeOnly.MinValue);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCropId == -1)
            {
                MessageBox.Show("Önce listeden bir kayıt seç!");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"UPDATE crops 
                         SET crop_name=@name,
                             planting_date=@date,
                             field_id = (SELECT field_id FROM fields WHERE field_name=@f LIMIT 1),
                             status=@status
                         WHERE crop_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtCropName1.Text);
                    cmd.Parameters.AddWithValue("@date", dtPlantingDate.Value);
                    cmd.Parameters.AddWithValue("@f", cmbField.Text);
                    cmd.Parameters.AddWithValue("@status", "Updated");
                    cmd.Parameters.AddWithValue("@id", selectedCropId);

                    int affected = cmd.ExecuteNonQuery();

                    if (affected == 0)
                        MessageBox.Show("Güncellenecek kayıt bulunamadı!");
                }
            }

            selectedCropId = -1; // reset
            LoadCrops();
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "DELETE FROM crops WHERE crop_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadCrops();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }

        private void txtCropName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
