using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartFarmingSystem
{
    using System.Data;
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Field ID");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Moisture");
            dt.Columns.Add("Date");

            dt.Rows.Add("1", "22°C", "70%", "06 May");
            dt.Rows.Add("2", "24°C", "65%", "06 May");
            dt.Rows.Add("3", "21°C", "75%", "06 May");

            dataGridViewtbl1.DataSource = dt;
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

        }

        private void btnCrops_Click(object sender, EventArgs e)
        {
            CropsForm form = new CropsForm();
            form.Show();
            this.Hide();
        }
    }
}
