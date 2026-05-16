namespace SmartFarmingSystem
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            panelTop = new Panel();
            logo1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            btnBack = new Button();
            btnQ6 = new Button();
            btnQ5 = new Button();
            btnQ4 = new Button();
            btnQ3 = new Button();
            btnQ2 = new Button();
            btnQ1 = new Button();
            dataGridView1 = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(logo1);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(label1);
            panelTop.Location = new Point(1, 1);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(801, 39);
            panelTop.TabIndex = 10;
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
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 0;
            label1.Text = "STRAWBERRY FARMING CORP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(btnQ6);
            panel3.Controls.Add(btnQ5);
            panel3.Controls.Add(btnQ4);
            panel3.Controls.Add(btnQ3);
            panel3.Controls.Add(btnQ2);
            panel3.Controls.Add(btnQ1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(28, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 349);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(54, 23);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 13;
            label4.Text = "What you want to see?";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(382, 37);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 12;
            label3.Text = "STATISTIC TABLE VIEW";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(0, 323);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 23);
            btnBack.TabIndex = 11;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnQ6
            // 
            btnQ6.Location = new Point(36, 270);
            btnQ6.Name = "btnQ6";
            btnQ6.Size = new Size(193, 23);
            btnQ6.TabIndex = 10;
            btnQ6.Text = "🔥Empty Fields";
            btnQ6.UseVisualStyleBackColor = true;
            btnQ6.Click += btnQ6_Click;
            // 
            // btnQ5
            // 
            btnQ5.Location = new Point(36, 231);
            btnQ5.Name = "btnQ5";
            btnQ5.Size = new Size(193, 23);
            btnQ5.TabIndex = 9;
            btnQ5.Text = "🕒Latest Sensor Data";
            btnQ5.UseVisualStyleBackColor = true;
            btnQ5.Click += btnQ5_Click;
            // 
            // btnQ4
            // 
            btnQ4.Location = new Point(36, 190);
            btnQ4.Name = "btnQ4";
            btnQ4.Size = new Size(193, 23);
            btnQ4.TabIndex = 8;
            btnQ4.Text = "💧Low Moisture Analysis";
            btnQ4.UseVisualStyleBackColor = true;
            btnQ4.Click += btnQ4_Click;
            // 
            // btnQ3
            // 
            btnQ3.Location = new Point(36, 151);
            btnQ3.Name = "btnQ3";
            btnQ3.Size = new Size(193, 23);
            btnQ3.TabIndex = 7;
            btnQ3.Text = "🌡 Min & Max Temperature";
            btnQ3.UseVisualStyleBackColor = true;
            btnQ3.Click += btnQ3_Click;
            // 
            // btnQ2
            // 
            btnQ2.Location = new Point(36, 108);
            btnQ2.Name = "btnQ2";
            btnQ2.Size = new Size(193, 23);
            btnQ2.TabIndex = 6;
            btnQ2.Text = "📊 Crops Per Farm";
            btnQ2.UseVisualStyleBackColor = true;
            btnQ2.Click += btnQ2_Click;
            // 
            // btnQ1
            // 
            btnQ1.Location = new Point(36, 60);
            btnQ1.Name = "btnQ1";
            btnQ1.Size = new Size(193, 23);
            btnQ1.TabIndex = 5;
            btnQ1.Text = "🌾Above Avg Temperature";
            btnQ1.UseVisualStyleBackColor = true;
            btnQ1.Click += btnQ1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(363, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 161);
            dataGridView1.TabIndex = 4;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panelTop);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox logo1;
        private Label label2;
        internal Label label1;
        private Panel panel3;
        private Button btnQ2;
        private Button btnQ1;
        private DataGridView dataGridView1;
        private Button btnBack;
        private Button btnQ6;
        private Button btnQ5;
        private Button btnQ4;
        private Button btnQ3;
        internal Label label3;
        internal Label label4;
    }
}