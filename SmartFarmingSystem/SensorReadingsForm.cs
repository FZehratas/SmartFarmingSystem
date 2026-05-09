using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartFarmingSystem
{
    public partial class SensorReadingsForm : Form
    {

        void LoadSensors()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Field");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Moisture");
            dt.Columns.Add("Date");

            dt.Rows.Add(1, "Greenhouse A", "22", "70", "2026-05-06");
            dt.Rows.Add(2, "Greenhouse B", "24", "65", "2026-05-06");
            dt.Rows.Add(3, "Vertical Tower 1", "21", "75", "2026-05-06");

            dataGridView1.DataSource = dt;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;

            dt.Rows.Add(
                dt.Rows.Count + 1,
                cmbField.Text,
                txtTemperature.Text,
                txtMoisture.Text,
                dtReadingDate.Value.ToShortDateString()
            );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[1].Value = cmbField.Text;
                dataGridView1.CurrentRow.Cells[2].Value = txtTemperature.Text;
                dataGridView1.CurrentRow.Cells[3].Value = txtMoisture.Text;
                dataGridView1.CurrentRow.Cells[4].Value = dtReadingDate.Value.ToShortDateString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                cmbField.Text = row.Cells[1].Value.ToString();
                txtTemperature.Text = row.Cells[2].Value.ToString();
                txtMoisture.Text = row.Cells[3].Value.ToString();
                dtReadingDate.Value = Convert.ToDateTime(row.Cells[4].Value);
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
