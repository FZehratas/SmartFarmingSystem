using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartFarmingSystem
{
    public partial class StatisticsForm : Form
    {
        string connString = "Host=ep-bold-surf-apre6yz3.c-7.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_nqxUsDFfP10g;SSL Mode=Require;Trust Server Certificate=true;";
        int selectedCropId = -1;
        public StatisticsForm()
        {
            InitializeComponent();
        }

        void LoadData(string query)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        // 🔹 QUERY 1 → Total Crops
        private void btnQ1_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM crops";
            LoadData(q);
        }


        // 🔹 QUERY 2 → Crops Per Field (FIXED)
        private void btnQ2_Click(object sender, EventArgs e)
        {
            string q = @"SELECT f.field_name, COUNT(c.crop_id) AS total_crops
                 FROM fields f
                 LEFT JOIN crops c ON f.field_id = c.field_id
                 GROUP BY f.field_name";
            LoadData(q);
        }


        // 🔹 QUERY 3 → Average Temperature (ZATEN DOĞRUYDU)
        private void btnQ3_Click(object sender, EventArgs e)
        {
            string q = @"SELECT f.field_name, AVG(s.temperature) AS avg_temp
                 FROM sensorreadings s
                 JOIN fields f ON s.field_id = f.field_id
                 GROUP BY f.field_name";
            LoadData(q);
        }


        // 🔹 QUERY 4 → Low Moisture (FIXED - JOIN EKLENDİ)
        private void btnQ4_Click(object sender, EventArgs e)
        {
            string q = @"SELECT f.field_name, s.moisture
                 FROM sensorreadings s
                 JOIN fields f ON s.field_id = f.field_id
                 WHERE s.moisture < 80";
            LoadData(q);
        }


        // 🔹 QUERY 5 → Recent Crops (OK ama LIMIT EKLEDİK)
        private void btnQ5_Click(object sender, EventArgs e)
        {
            string q = @"SELECT crop_name, planting_date
                 FROM crops
                 ORDER BY planting_date DESC
                 LIMIT 5";
            LoadData(q);
        }


        // 🔹 QUERY 6 → Max Temperature (DOĞRU)
        private void btnQ6_Click(object sender, EventArgs e)
        {
            string q = @"SELECT f.field_name, MAX(s.temperature) AS max_temp
                 FROM sensorreadings s
                 JOIN fields f ON s.field_id = f.field_id
                 GROUP BY f.field_name";
            LoadData(q);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }
    }
}
