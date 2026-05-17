namespace SmartFarmingSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panelTop = new Panel();
            logo1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnStatistics = new Button();
            buttonlogout = new Button();
            btnField = new Button();
            btnSensors = new Button();
            btnFarms = new Button();
            btnCrops = new Button();
            dataGridViewtbl1 = new DataGridView();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            lblFarms = new Label();
            lblCrops = new Label();
            btnManageUsers = new Button();
            panel1.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtbl1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelTop);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(logo1);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(label1);
            panelTop.Location = new Point(0, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1020, 39);
            panelTop.TabIndex = 6;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(553, 9);
            label2.Name = "label2";
            label2.Size = new Size(247, 25);
            label2.TabIndex = 1;
            label2.Text = "Welcome! Have a nice day ";
            label2.Click += label2_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(246, 25);
            label3.TabIndex = 2;
            label3.Text = "WHAT YOU WANT TO DO?";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnManageUsers);
            panel2.Controls.Add(btnStatistics);
            panel2.Controls.Add(buttonlogout);
            panel2.Controls.Add(btnField);
            panel2.Controls.Add(btnSensors);
            panel2.Controls.Add(btnFarms);
            panel2.Controls.Add(btnCrops);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 393);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnStatistics
            // 
            btnStatistics.Location = new Point(30, 238);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(195, 23);
            btnStatistics.TabIndex = 10;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // buttonlogout
            // 
            buttonlogout.ForeColor = Color.Firebrick;
            buttonlogout.Location = new Point(-3, 314);
            buttonlogout.Name = "buttonlogout";
            buttonlogout.Size = new Size(273, 29);
            buttonlogout.TabIndex = 8;
            buttonlogout.Text = "Log Out";
            buttonlogout.UseVisualStyleBackColor = true;
            buttonlogout.Click += buttonlogout_Click;
            // 
            // btnField
            // 
            btnField.ForeColor = Color.DarkOliveGreen;
            btnField.Location = new Point(30, 200);
            btnField.Name = "btnField";
            btnField.Size = new Size(195, 23);
            btnField.TabIndex = 7;
            btnField.Text = "Manage Field";
            btnField.UseVisualStyleBackColor = true;
            btnField.Click += button4_Click;
            // 
            // btnSensors
            // 
            btnSensors.ForeColor = Color.DarkOliveGreen;
            btnSensors.Location = new Point(30, 155);
            btnSensors.Name = "btnSensors";
            btnSensors.Size = new Size(195, 23);
            btnSensors.TabIndex = 6;
            btnSensors.Text = "Manage Sensors";
            btnSensors.UseVisualStyleBackColor = true;
            btnSensors.Click += btnSensors_Click;
            // 
            // btnFarms
            // 
            btnFarms.ForeColor = Color.DarkOliveGreen;
            btnFarms.Location = new Point(30, 113);
            btnFarms.Name = "btnFarms";
            btnFarms.Size = new Size(195, 23);
            btnFarms.TabIndex = 5;
            btnFarms.Text = "Manage Farms";
            btnFarms.UseVisualStyleBackColor = true;
            btnFarms.Click += button2_Click;
            // 
            // btnCrops
            // 
            btnCrops.ForeColor = Color.DarkOliveGreen;
            btnCrops.Location = new Point(30, 68);
            btnCrops.Name = "btnCrops";
            btnCrops.Size = new Size(195, 23);
            btnCrops.TabIndex = 4;
            btnCrops.Text = "Manage Crops";
            btnCrops.UseVisualStyleBackColor = true;
            btnCrops.Click += btnCrops_Click;
            // 
            // dataGridViewtbl1
            // 
            dataGridViewtbl1.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewtbl1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewtbl1.Location = new Point(296, 116);
            dataGridViewtbl1.Name = "dataGridViewtbl1";
            dataGridViewtbl1.Size = new Size(433, 148);
            dataGridViewtbl1.TabIndex = 4;
            dataGridViewtbl1.CellContentClick += dataGridViewtbl1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblFarms);
            panel3.Controls.Add(lblCrops);
            panel3.Controls.Add(dataGridViewtbl1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(30, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 349);
            panel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(296, 43);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 9;
            label5.Text = "Crops:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(511, 43);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 8;
            label4.Text = "Farms:";
            // 
            // lblFarms
            // 
            lblFarms.AutoSize = true;
            lblFarms.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFarms.ForeColor = Color.DarkOliveGreen;
            lblFarms.Location = new Point(596, 43);
            lblFarms.Name = "lblFarms";
            lblFarms.Size = new Size(23, 25);
            lblFarms.TabIndex = 7;
            lblFarms.Text = "0";
            // 
            // lblCrops
            // 
            lblCrops.AutoSize = true;
            lblCrops.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCrops.ForeColor = Color.DarkOliveGreen;
            lblCrops.Location = new Point(371, 43);
            lblCrops.Name = "lblCrops";
            lblCrops.Size = new Size(23, 25);
            lblCrops.TabIndex = 6;
            lblCrops.Text = "0";
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(30, 281);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(195, 23);
            btnManageUsers.TabIndex = 11;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtbl1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelTop;
        private PictureBox logo1;
        internal Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Button btnCrops;
        private Button btnField;
        private Button btnSensors;
        private Button btnFarms;
        private DataGridView dataGridViewtbl1;
        private Button buttonlogout;
        private Panel panel3;
        private Label lblFarms;
        private Label lblCrops;
        private Label label5;
        private Label label4;
        private Button btnStatistics;
        private Button btnManageUsers;
    }
}