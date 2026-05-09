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
        string connString = "Host=aws-0-eu-central-1.pooler.supabase.com;Port=6543;Database=postgres;Username=postgres.ejkekkoynvhewhmxolqy;Password=smartfarmingsystem4;SSL Mode=Require;Trust Server Certificate=true";
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
        }
        void LoadCrops()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Crop Name");
            dt.Columns.Add("Field");
            dt.Columns.Add("Date");
            dt.Columns.Add("Status");

            dt.Rows.Add(1, "Strawberry Albion", "Greenhouse A", "2026-03-01", "Growing");
            dt.Rows.Add(2, "Strawberry Festival", "Greenhouse B", "2026-02-15", "Ready");

            dataGridView1.DataSource = dt;
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
            DataTable dt = (DataTable)dataGridView1.DataSource;

            dt.Rows.Add(
                dt.Rows.Count + 1,
                txtCropName1.Text,
                cmbField.Text,
                dtPlantingDate.Value.ToShortDateString(),
                "New"
            );
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
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[1].Value = txtCropName1.Text;
                dataGridView1.CurrentRow.Cells[2].Value = cmbField.Text;
                dataGridView1.CurrentRow.Cells[3].Value = dtPlantingDate.Value.ToShortDateString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
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
    }
}
