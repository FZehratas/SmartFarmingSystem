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
    public partial class FieldsForm : Form
    {
        string connString = "Host=ep-bold-surf-apre6yz3.c-7.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_nqxUsDFfP10g;SSL Mode=Require;Trust Server Certificate=true;";

        public FieldsForm()
        {
            InitializeComponent();
            this.Load += FieldsForm_Load;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnBack.Click += btnBack_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // 🟢 LOAD FARMS → dropdown
        void LoadFarms()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT farm_id, farm_name FROM farms";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbFarm.DataSource = dt;
                    cmbFarm.DisplayMember = "farm_name";
                    cmbFarm.ValueMember = "farm_id";
                }
            }
        }

        // 🟢 LOAD FIELDS
        void LoadFields()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT f.field_id, fa.farm_name, f.field_name, f.soil_type, f.area
                                 FROM fields f
                                 JOIN farms fa ON f.farm_id = fa.farm_id";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void FieldsForm_Load(object sender, EventArgs e)
        {
            LoadFarms();
            LoadFields();
        }

        // ➕ ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFieldName.Text == "")
            {
                MessageBox.Show("Boş alan bırakma!");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO fields (farm_id, field_name, soil_type, area)
                                 VALUES (@farm, @name, @soil, @area)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@farm", cmbFarm.SelectedValue);
                    cmd.Parameters.AddWithValue("@name", txtFieldName.Text);
                    cmd.Parameters.AddWithValue("@soil", txtSoil.Text);
                    cmd.Parameters.AddWithValue("@area", int.Parse(txtArea.Text));

                    cmd.ExecuteNonQuery();
                }
            }

            LoadFields();
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

                    string query = @"UPDATE fields 
                                     SET farm_id=@farm,
                                         field_name=@name,
                                         soil_type=@soil,
                                         area=@area
                                     WHERE field_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@farm", cmbFarm.SelectedValue);
                        cmd.Parameters.AddWithValue("@name", txtFieldName.Text);
                        cmd.Parameters.AddWithValue("@soil", txtSoil.Text);
                        cmd.Parameters.AddWithValue("@area", int.Parse(txtArea.Text));
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadFields();
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

                    string query = "DELETE FROM fields WHERE field_id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadFields();
            }
        }

        // 🖱️ GRID CLICK
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                cmbFarm.Text = row.Cells[1].Value.ToString();
                txtFieldName.Text = row.Cells[2].Value.ToString();
                txtSoil.Text = row.Cells[3].Value.ToString();
                txtArea.Text = row.Cells[4].Value.ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
