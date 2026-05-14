namespace SmartFarmingSystem
{
    partial class SensorReadingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorReadingsForm));
            panelTop = new Panel();
            logo1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnBack = new Button();
            txtMoisture = new TextBox();
            label4 = new Label();
            dtReadingDate = new DateTimePicker();
            cmbField = new ComboBox();
            txtTemperature = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblTemperature = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label3 = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(logo1);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(label1);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(949, 39);
            panelTop.TabIndex = 8;
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
            label2.Location = new Point(699, 9);
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
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 0;
            label1.Text = "STRAWBERRY FARMING CORP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(24, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(925, 349);
            panel3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(363, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(545, 161);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(txtMoisture);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtReadingDate);
            panel2.Controls.Add(cmbField);
            panel2.Controls.Add(txtTemperature);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblTemperature);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 393);
            panel2.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.DarkOliveGreen;
            btnBack.Location = new Point(-3, 323);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 23);
            btnBack.TabIndex = 19;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtMoisture
            // 
            txtMoisture.Location = new Point(108, 122);
            txtMoisture.Name = "txtMoisture";
            txtMoisture.Size = new Size(186, 23);
            txtMoisture.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 17;
            label4.Text = "Moisture:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtReadingDate
            // 
            dtReadingDate.Location = new Point(108, 198);
            dtReadingDate.Name = "dtReadingDate";
            dtReadingDate.Size = new Size(186, 23);
            dtReadingDate.TabIndex = 16;
            // 
            // cmbField
            // 
            cmbField.FormattingEnabled = true;
            cmbField.Location = new Point(108, 161);
            cmbField.Name = "cmbField";
            cmbField.Size = new Size(186, 23);
            cmbField.TabIndex = 15;
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(108, 84);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(186, 23);
            txtTemperature.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.DarkOliveGreen;
            label7.Location = new Point(45, 16);
            label7.Name = "label7";
            label7.Size = new Size(221, 20);
            label7.TabIndex = 13;
            label7.Text = "🌱 SENSOR MANAGEMENT     ";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.DarkOliveGreen;
            label6.Location = new Point(25, 198);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 12;
            label6.Text = " Date: ";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(25, 164);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Field:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTemperature.ForeColor = Color.DarkOliveGreen;
            lblTemperature.Location = new Point(7, 84);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(99, 20);
            lblTemperature.TabIndex = 10;
            lblTemperature.Text = "Temperature:";
            lblTemperature.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.DarkOliveGreen;
            btnDelete.Location = new Point(204, 242);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.DarkOliveGreen;
            btnUpdate.Location = new Point(108, 242);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.DarkOliveGreen;
            btnAdd.Location = new Point(7, 242);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // SensorReadingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 450);
            Controls.Add(panel3);
            Controls.Add(panelTop);
            Name = "SensorReadingsForm";
            Text = "SensorReadingsForm";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox logo1;
        private Label label2;
        internal Label label1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DateTimePicker dtReadingDate;
        private ComboBox cmbField;
        private TextBox txtTemperature;
        internal Label label7;
        internal Label label6;
        internal Label label5;
        internal Label lblTemperature;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private TextBox txtMoisture;
        internal Label label4;
        private Button btnBack;
    }
}