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
    public partial class ManageUsers : Form
    {
        string connString = "Host=ep-bold-surf-apre6yz3.c-7.us-east-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_nqxUsDFfP10g;SSL Mode=Require;Trust Server Certificate=true;";
        Dashboard dashboard;
        void LoadUsers()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string q = @"SELECT u.user_id, u.username, u.full_name, r.role_name
             FROM ""users"" u
             LEFT JOIN ""roles"" r ON u.role_id = r.role_id";

                using (var da = new NpgsqlDataAdapter(q, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        void LoadRoles()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string q = "SELECT role_id, role_name FROM roles";

                using (var da = new NpgsqlDataAdapter(q, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbRole.DataSource = dt;
                    cmbRole.DisplayMember = "role_name";
                    cmbRole.ValueMember = "role_id";
                }
            }
        }
       
        public ManageUsers(Dashboard d)
        {
            InitializeComponent();
            dashboard = d;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRoles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string q = @"INSERT INTO users(username, password, full_name, role_id)
                     VALUES(@u, @p, @f, @r)";

                using (var cmd = new NpgsqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@f", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@r", cmbRole.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                LoadUsers();
            }
        }
        int selectedUserId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            MessageBox.Show("ID: " + selectedUserId); 

            txtUsername.Text = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
            txtFullName.Text = dataGridView1.CurrentRow.Cells["full_name"].Value.ToString();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                selectedUserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
                txtFullName.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
          

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string q = @"UPDATE ""users"" 
                     SET username=@u, password=@p, full_name=@f, role_id=@r
                     WHERE user_id=@id";

                using (var cmd = new NpgsqlCommand(q, conn))
                {
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@f", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@r", cmbRole.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                    cmd.ExecuteNonQuery();
                }

                LoadUsers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Lütfen kullanıcı seç!");
                return;
            }

            DialogResult r = MessageBox.Show("Silmek istiyor musun?", "Confirm", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string q = "DELETE FROM \"users\" WHERE user_id=@id";

                    using (var cmd = new NpgsqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadUsers();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(1); // geçici (role da gönderebilirsin)
            d.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
