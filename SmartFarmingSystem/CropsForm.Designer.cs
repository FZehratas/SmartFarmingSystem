namespace SmartFarmingSystem
{
    partial class CropsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropsForm));
            panelTop = new Panel();
            logo1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dtPlantingDate = new DateTimePicker();
            cmbField = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtCropName = new Label();
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
            panelTop.Size = new Size(801, 39);
            panelTop.TabIndex = 7;
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
            panel3.Location = new Point(28, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 349);
            panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(363, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 161);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtPlantingDate);
            panel2.Controls.Add(cmbField);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtCropName);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 393);
            panel2.TabIndex = 3;
            // 
            // dtPlantingDate
            // 
            dtPlantingDate.Location = new Point(108, 165);
            dtPlantingDate.Name = "dtPlantingDate";
            dtPlantingDate.Size = new Size(186, 23);
            dtPlantingDate.TabIndex = 16;
            // 
            // cmbField
            // 
            cmbField.FormattingEnabled = true;
            cmbField.Location = new Point(108, 126);
            cmbField.Name = "cmbField";
            cmbField.Size = new Size(186, 23);
            cmbField.TabIndex = 15;
            cmbField.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.DarkOliveGreen;
            label7.Location = new Point(45, 16);
            label7.Name = "label7";
            label7.Size = new Size(211, 20);
            label7.TabIndex = 13;
            label7.Text = "🌱 CROPS MANAGEMENT     ";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.DarkOliveGreen;
            label6.Location = new Point(12, 165);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 12;
            label6.Text = " Date: ";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Field:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCropName
            // 
            txtCropName.AutoSize = true;
            txtCropName.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtCropName.ForeColor = Color.DarkOliveGreen;
            txtCropName.Location = new Point(7, 84);
            txtCropName.Name = "txtCropName";
            txtCropName.Size = new Size(95, 20);
            txtCropName.TabIndex = 10;
            txtCropName.Text = " Crop Name:";
            txtCropName.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.DarkOliveGreen;
            btnDelete.Location = new Point(204, 212);
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
            btnUpdate.Location = new Point(108, 212);
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
            btnAdd.Location = new Point(12, 212);
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
            // CropsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panelTop);
            Name = "CropsForm";
            Text = "CropsForm";
            Load += CropsForm_Load;
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
        private Panel panel2;
        internal Label label6;
        internal Label label5;
        internal Label txtCropName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private DateTimePicker dtPlantingDate;
        private ComboBox cmbField;
        private TextBox textBox1;
        internal Label label7;
        private DataGridView dataGridView1;
    }
}