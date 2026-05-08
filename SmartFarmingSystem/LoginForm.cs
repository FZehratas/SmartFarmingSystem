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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // ŞİMDİLİK LOCAL TEST
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Giriş başarılı!");

                Dashboard d = new Dashboard();
                d.Show();

                this.Hide(); // login form kapanır
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
