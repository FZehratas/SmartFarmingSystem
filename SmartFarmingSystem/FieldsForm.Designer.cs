namespace SmartFarmingSystem
{
    partial class FieldsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldsForm));
            panelTop = new Panel();
            logo1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtArea = new TextBox();
            label4 = new Label();
            cmbFarm = new ComboBox();
            txtSoil = new TextBox();
            txtFieldName = new TextBox();
            btnBack = new Button();
            label7 = new Label();
            Size = new Label();
            fldnm = new Label();
            FarmName = new Label();
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
            panelTop.Size = new Size(920, 39);
            panelTop.TabIndex = 9;
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
            label2.Location = new Point(659, 9);
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
            label1.Location = new Point(63, 9);
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
            panel3.Size = new Size(892, 349);
            panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(363, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(515, 161);
            dataGridView1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtArea);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbFarm);
            panel2.Controls.Add(txtSoil);
            panel2.Controls.Add(txtFieldName);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Size);
            panel2.Controls.Add(fldnm);
            panel2.Controls.Add(FarmName);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 393);
            panel2.TabIndex = 3;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(108, 205);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(186, 23);
            txtArea.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 21;
            label4.Text = "Area: ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbFarm
            // 
            cmbFarm.FormattingEnabled = true;
            cmbFarm.Location = new Point(108, 85);
            cmbFarm.Name = "cmbFarm";
            cmbFarm.Size = new Size(186, 23);
            cmbFarm.TabIndex = 20;
            // 
            // txtSoil
            // 
            txtSoil.Location = new Point(108, 166);
            txtSoil.Name = "txtSoil";
            txtSoil.Size = new Size(186, 23);
            txtSoil.TabIndex = 19;
            // 
            // txtFieldName
            // 
            txtFieldName.Location = new Point(108, 126);
            txtFieldName.Name = "txtFieldName";
            txtFieldName.Size = new Size(186, 23);
            txtFieldName.TabIndex = 18;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.DarkOliveGreen;
            btnBack.Location = new Point(3, 320);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 23);
            btnBack.TabIndex = 17;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
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
            label7.Text = "🌱 FIELDS MANAGEMENT     ";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Size.ForeColor = Color.DarkOliveGreen;
            Size.Location = new Point(12, 165);
            Size.Name = "Size";
            Size.Size = new Size(42, 20);
            Size.TabIndex = 12;
            Size.Text = "Soil: ";
            Size.TextAlign = ContentAlignment.TopCenter;
            // 
            // fldnm
            // 
            fldnm.AutoSize = true;
            fldnm.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fldnm.ForeColor = Color.DarkOliveGreen;
            fldnm.Location = new Point(12, 125);
            fldnm.Name = "fldnm";
            fldnm.Size = new Size(91, 20);
            fldnm.TabIndex = 11;
            fldnm.Text = "Field Name:";
            fldnm.TextAlign = ContentAlignment.TopCenter;
            // 
            // FarmName
            // 
            FarmName.AutoSize = true;
            FarmName.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FarmName.ForeColor = Color.DarkOliveGreen;
            FarmName.Location = new Point(12, 84);
            FarmName.Name = "FarmName";
            FarmName.Size = new Size(47, 20);
            FarmName.TabIndex = 10;
            FarmName.Text = "Farm:";
            FarmName.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.DarkOliveGreen;
            btnDelete.Location = new Point(204, 243);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.DarkOliveGreen;
            btnUpdate.Location = new Point(108, 243);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.DarkOliveGreen;
            btnAdd.Location = new Point(3, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
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
            // FieldsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 450);
            Controls.Add(panel3);
            Controls.Add(panelTop);
            Name = "FieldsForm";
            Text = "FieldsForm";
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
        private TextBox txtSoil;
        private TextBox txtFieldName;
        private Button btnBack;
        internal Label label7;
        internal Label Size;
        internal Label fldnm;
        internal Label FarmName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private ComboBox cmbFarm;
        private TextBox txtArea;
        internal Label label4;
    }
}