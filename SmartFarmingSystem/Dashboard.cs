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
        string connString = "Host=db.ejkekkoynvhewhmxolqy.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=smartfarmingsystem4;SSL Mode=Require;Trust Server Certificate=true";
        void LoadSensors()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT field_id, temperature, moisture, reading_date 
                         FROM ""SensorReadings""";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewtbl1.DataSource = dt;
                }
            }
        }
        void LoadCounts()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                var cmd1 = new NpgsqlCommand(@"SELECT COUNT(*) FROM ""Crops""", conn);
                var cmd2 = new NpgsqlCommand(@"SELECT COUNT(*) FROM ""Farms""", conn);

                int cropCount = Convert.ToInt32(cmd1.ExecuteScalar());
                int farmCount = Convert.ToInt32(cmd2.ExecuteScalar());

                lblCrops.Text = cropCount.ToString();
                lblFarms.Text = farmCount.ToString();
            }
        }
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // LoadSensors();
            // LoadCounts();
            DataTable dt = new DataTable();

            dt.Columns.Add("Field ID");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Moisture");
            dt.Columns.Add("Date");

            dt.Rows.Add("1", "22°C", "70%", "06 May");
            dt.Rows.Add("2", "24°C", "65%", "06 May");
            dt.Rows.Add("3", "21°C", "75%", "06 May");

            dataGridViewtbl1.DataSource = dt;

            lblCrops.Text = "3";
            lblFarms.Text = "2";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
            this.Hide();
        }

        private void btnSensors_Click(object sender, EventArgs e)
        {
            SensorReadingsForm f = new SensorReadingsForm();
            f.Show();
        }
    }
}
