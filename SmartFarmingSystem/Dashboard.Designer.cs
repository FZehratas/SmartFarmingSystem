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
            buttonlogout = new Button();
            btnUsers = new Button();
            btnSensors = new Button();
            btnFields = new Button();
            btnCrops = new Button();
            dataGridViewtbl1 = new DataGridView();
            panel3 = new Panel();
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
            panelTop.Size = new Size(801, 39);
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
            label2.Location = new Point(541, 9);
            label2.Name = "label2";
            label2.Size = new Size(247, 25);
            label2.TabIndex = 1;
            label2.Text = "Welcome! Have a nice day ";
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
            panel2.Controls.Add(buttonlogout);
            panel2.Controls.Add(btnUsers);
            panel2.Controls.Add(btnSensors);
            panel2.Controls.Add(btnFields);
            panel2.Controls.Add(btnCrops);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 393);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
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
            // btnUsers
            // 
            btnUsers.ForeColor = Color.DarkOliveGreen;
            btnUsers.Location = new Point(30, 209);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(195, 23);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "Manage Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += button4_Click;
            // 
            // btnSensors
            // 
            btnSensors.ForeColor = Color.DarkOliveGreen;
            btnSensors.Location = new Point(30, 161);
            btnSensors.Name = "btnSensors";
            btnSensors.Size = new Size(195, 23);
            btnSensors.TabIndex = 6;
            btnSensors.Text = "Manage Sensors";
            btnSensors.UseVisualStyleBackColor = true;
            // 
            // btnFields
            // 
            btnFields.ForeColor = Color.DarkOliveGreen;
            btnFields.Location = new Point(30, 113);
            btnFields.Name = "btnFields";
            btnFields.Size = new Size(195, 23);
            btnFields.TabIndex = 5;
            btnFields.Text = "Manage Fields";
            btnFields.UseVisualStyleBackColor = true;
            btnFields.Click += button2_Click;
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
            // 
            // dataGridViewtbl1
            // 
            dataGridViewtbl1.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewtbl1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewtbl1.Location = new Point(315, 71);
            dataGridViewtbl1.Name = "dataGridViewtbl1";
            dataGridViewtbl1.Size = new Size(417, 148);
            dataGridViewtbl1.TabIndex = 4;
            dataGridViewtbl1.CellContentClick += dataGridViewtbl1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewtbl1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(30, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 349);
            panel3.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
        private Button btnUsers;
        private Button btnSensors;
        private Button btnFields;
        private DataGridView dataGridViewtbl1;
        private Button buttonlogout;
        private Panel panel3;
    }
}