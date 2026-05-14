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
    using System.Data;
    public partial class Dashboard : Form
    {
        string connString = "Host=ep-bold-surf-apre6yz3.c-7.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_nqxUsDFfP10g;SSL Mode=Require;Trust Server Certificate=true;";



        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
        void LoadDashboardData()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // toplam crops
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Crops", conn))
                {
                    lblCrops.Text = cmd.ExecuteScalar().ToString();
                }

                // toplam farms
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Farms", conn))
                {
                    lblFarms.Text = cmd.ExecuteScalar().ToString();
                }

                // sensör tablosu
                string query = @"SELECT f.field_name, s.temperature, s.moisture, s.reading_date
                         FROM SensorReadings s
                         JOIN Fields f ON s.field_id = f.field_id";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewtbl1.DataSource = dt;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmsForm f = new FarmsForm(); // şimdilik bunu aç
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FieldsForm f = new FieldsForm();
            f.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewtbl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnCrops_Click(object sender, EventArgs e)
        {
            CropsForm form = new CropsForm();
            form.Show();
            this.Close();
        }

        private void btnSensors_Click(object sender, EventArgs e)
        {
            SensorReadingsForm f = new SensorReadingsForm();
            f.Show();
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm s = new StatisticsForm();
            s.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
