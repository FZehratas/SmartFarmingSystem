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
        string connString = "Host=aws-0-eu-central-1.pooler.supabase.com;Port=6543;Database=postgres;Username=postgres.ejkekkoynvhewhmxolqy;Password=Sıfre;SSL Mode=Require;Trust Server Certificate=true";
        void TestConnection()
        {
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(connString))
                {
                    conn.Open();
                    MessageBox.Show("BAĞLANDI!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public CropsForm()
        {
            InitializeComponent();
            this.Load += CropsForm_Load;
            TestConnection();
        }
        void LoadCrops()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT crop_id, crop_name, planting_date, status 
                         FROM ""Crops""";

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

                string query = @"SELECT field_id, field_name FROM ""Fields""";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbField.DisplayMember = "field_name";
                    cmbField.ValueMember = "field_id";
                    cmbField.DataSource = dt;
                }
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO ""Crops"" 
                        (field_id, crop_name, planting_date, status)
                        VALUES (@field, @name, @date, 'Planted')";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@field", cmbField.SelectedValue);
                    cmd.Parameters.AddWithValue("@name", txtCropName.Text);
                    cmd.Parameters.AddWithValue("@date", dtPlantingDate.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Crop eklendi!");
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

                txtCropName.Text = row.Cells["crop_name"].Value.ToString();
                dtPlantingDate.Value = Convert.ToDateTime(row.Cells["planting_date"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["crop_id"].Value);

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"UPDATE ""Crops"" 
                         SET crop_name=@name, planting_date=@date
                         WHERE crop_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtCropName.Text);
                    cmd.Parameters.AddWithValue("@date", dtPlantingDate.Value);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Güncellendi!");
            LoadCrops();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["crop_id"].Value);

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"DELETE FROM ""Crops"" WHERE crop_id=@id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Silindi!");
            LoadCrops();
        }
    }
}
