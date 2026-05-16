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

        //This query shows fields with an average temperature higher than the overall system average.
        private void btnQ1_Click(object sender, EventArgs e)
        {
            string q = @"
            SELECT f.field_name, AVG(s.temperature) AS avg_temp
            FROM sensorreadings s
            JOIN fields f ON s.field_id = f.field_id
            GROUP BY f.field_name
            HAVING AVG(s.temperature) > (
                SELECT AVG(temperature) FROM sensorreadings
            )";

            LoadData(q);
        }


        // 🔹This query calculates the total number of crops in each farm using multiple table joins.
        private void btnQ2_Click(object sender, EventArgs e)
        {
            string q = @"
            SELECT fa.farm_name, COUNT(c.crop_id) AS total_crops
            FROM farms fa
            JOIN fields f ON fa.farm_id = f.farm_id
            JOIN crops c ON f.field_id = c.field_id
            GROUP BY fa.farm_name
            ORDER BY total_crops DESC";
            LoadData(q);
        }


        // 🔹 This query displays the minimum and maximum temperature recorded in each field.
        private void btnQ3_Click(object sender, EventArgs e)
        {
                    string q = @"
            SELECT f.field_name,
                   MAX(s.temperature) AS max_temp,
                   MIN(s.temperature) AS min_temp
            FROM sensorreadings s
            JOIN fields f ON s.field_id = f.field_id
            GROUP BY f.field_name";
            LoadData(q);
        }


        // 🔹This query identifies fields that frequently experience low moisture levels. 
        private void btnQ4_Click(object sender, EventArgs e)
        {
            string q = @"
            SELECT f.field_name, COUNT(*) AS low_moisture_count
            FROM sensorreadings s
            JOIN fields f ON s.field_id = f.field_id
            WHERE s.moisture < 60
            GROUP BY f.field_name
            HAVING COUNT(*) > 1";
        }


        // 🔹 This query retrieves the most recent sensor reading for each field.
        private void btnQ5_Click(object sender, EventArgs e)
        {
            string q = @"
            SELECT f.field_name, s.temperature, s.reading_date
            FROM sensorreadings s
            JOIN fields f ON s.field_id = f.field_id
            WHERE s.reading_date = (
                SELECT MAX(s2.reading_date)
                FROM sensorreadings s2
                WHERE s2.field_id = s.field_id
            )";
            LoadData(q);
        }


        // 🔹This query lists fields that currently have no crops assigned.
        private void btnQ6_Click(object sender, EventArgs e)
        {
            string q = @"
            SELECT f.field_name
            FROM fields f
            LEFT JOIN crops c ON f.field_id = c.field_id
            WHERE c.crop_id IS NULL";
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
