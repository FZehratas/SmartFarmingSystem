namespace SmartFarmingSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblacc = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panelTop = new Panel();
            logo1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            logo2 = new PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo2).BeginInit();
            SuspendLayout();
            // 
            // lblacc
            // 
            lblacc.AutoSize = true;
            lblacc.ForeColor = Color.ForestGreen;
            lblacc.Location = new Point(28, 119);
            lblacc.Name = "lblacc";
            lblacc.Size = new Size(154, 15);
            lblacc.TabIndex = 0;
            lblacc.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(61, 104);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Click += lblPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.AutoEllipsis = true;
            btnLogin.BackColor = Color.IndianRed;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(61, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.InfoText;
            txtUsername.Location = new Point(28, 147);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "username";
            txtUsername.Size = new Size(138, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(28, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(138, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Tag = "password";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(logo1);
            panelTop.Controls.Add(label1);
            panelTop.Location = new Point(-1, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(801, 39);
            panelTop.TabIndex = 5;
            // 
            // logo1
            // 
            logo1.BackgroundImage = (Image)resources.GetObject("logo1.BackgroundImage");
            logo1.BackgroundImageLayout = ImageLayout.Stretch;
            logo1.Location = new Point(0, 0);
            logo1.Name = "logo1";
            logo1.Size = new Size(57, 39);
            logo1.TabIndex = 1;
            logo1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 0;
            label1.Text = "STRAWBERRY FARMING CORP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(logo2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblacc);
            panel1.Location = new Point(317, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 275);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // logo2
            // 
            logo2.BackgroundImage = (Image)resources.GetObject("logo2.BackgroundImage");
            logo2.BackgroundImageLayout = ImageLayout.Stretch;
            logo2.Location = new Point(28, 18);
            logo2.Name = "logo2";
            logo2.Size = new Size(138, 71);
            logo2.TabIndex = 5;
            logo2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Name = "LoginForm";
            Text = "LoginForm";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblacc;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panelTop;
        private PictureBox logo1;
        internal Label label1;
        private Panel panel1;
        private PictureBox logo2;
    }
}