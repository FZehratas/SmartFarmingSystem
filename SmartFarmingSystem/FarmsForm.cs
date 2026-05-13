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
    public partial class FarmsForm : Form
    {
        string connString = "Host=ep-bold-surf-apre6yz3.c-7.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_nqxUsDFfP10g;SSL Mode=Require;Trust Server Certificate=true;";

        public FarmsForm()
        {
            InitializeComponent();
            this.Load += FarmsForm_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnBack.Click += btnBack_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        // 🟢 LOAD
        void LoadFarms()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT * FROM farms";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void FarmsForm_Load(object sender, EventArgs e)
        {
            LoadFarms();
        }

        // ➕ ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFarmName.Text == "" || txtLocation.Text == "" || txtSize.Text == "")
            {
                MessageBox.Show("Boş alan bırakma!");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "INSERT INTO farms (farm_name, location, size_acre) VALUES (@n, @l, @s)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@n", txtFarmName.Text);
                    cmd.Parameters.AddWithValue("@l", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@s", int.Parse(txtSize.Text));

                    cmd.ExecuteNonQuery();
                }
            }

            LoadFarms();
        }

        // 🔄 UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = @"UPDATE farms 
                                     SET farm_name=@n, location=@l, size_acre=@s
                                     WHERE farm_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", txtFarmName.Text);
                        cmd.Parameters.AddWithValue("@l", txtLocation.Text);
                        cmd.Parameters.AddWithValue("@s", int.Parse(txtSize.Text));
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadFarms();
            }
        }

        // ❌ DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string query = "DELETE FROM farms WHERE farm_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadFarms();
            }
        }

        // 🖱️ GRID CLICK
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtFarmName.Text = row.Cells[1].Value.ToString();
                txtLocation.Text = row.Cells[2].Value.ToString();
                txtSize.Text = row.Cells[3].Value.ToString();
            }
        }

        // 🔙 BACK
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}

