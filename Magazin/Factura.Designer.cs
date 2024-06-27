namespace Magazin
{
    partial class Factura
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewFurnizor;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridView dataGridViewProduse;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            dataGridViewFurnizor = new DataGridView();
            dataGridViewClient = new DataGridView();
            dataGridViewProduse = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            labelCostTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFurnizor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFurnizor
            // 
            dataGridViewFurnizor.AllowUserToAddRows = false;
            dataGridViewFurnizor.AllowUserToDeleteRows = false;
            dataGridViewFurnizor.BackgroundColor = SystemColors.Control;
            dataGridViewFurnizor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFurnizor.Location = new Point(60, 199);
            dataGridViewFurnizor.Margin = new Padding(4, 5, 4, 5);
            dataGridViewFurnizor.Name = "dataGridViewFurnizor";
            dataGridViewFurnizor.RowHeadersWidth = 51;
            dataGridViewFurnizor.Size = new Size(429, 249);
            dataGridViewFurnizor.TabIndex = 0;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Location = new Point(591, 199);
            dataGridViewClient.Margin = new Padding(4, 5, 4, 5);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.RowHeadersWidth = 51;
            dataGridViewClient.Size = new Size(419, 249);
            dataGridViewClient.TabIndex = 1;
            // 
            // dataGridViewProduse
            // 
            dataGridViewProduse.BackgroundColor = SystemColors.Control;
            dataGridViewProduse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduse.Location = new Point(60, 553);
            dataGridViewProduse.Margin = new Padding(4, 5, 4, 5);
            dataGridViewProduse.Name = "dataGridViewProduse";
            dataGridViewProduse.RowHeadersWidth = 51;
            dataGridViewProduse.Size = new Size(941, 184);
            dataGridViewProduse.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button1.Location = new Point(76, 867);
            button1.Name = "button1";
            button1.Size = new Size(171, 51);
            button1.TabIndex = 3;
            button1.Text = "Salveaza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button2.Location = new Point(300, 867);
            button2.Name = "button2";
            button2.Size = new Size(171, 51);
            button2.TabIndex = 4;
            button2.Text = "Printeaza";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.birdy2;
            pictureBox1.Location = new Point(32, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.generatedtext;
            pictureBox2.Location = new Point(130, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(60, 164);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 7;
            label1.Text = "Furnizor";
            // 
            // labelCostTotal
            // 
            labelCostTotal.AutoSize = true;
            labelCostTotal.BackColor = Color.GhostWhite;
            labelCostTotal.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelCostTotal.Location = new Point(732, 742);
            labelCostTotal.Name = "labelCostTotal";
            labelCostTotal.Size = new Size(61, 29);
            labelCostTotal.TabIndex = 8;
            labelCostTotal.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(591, 164);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 9;
            label3.Text = "Client";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(60, 518);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 11;
            label4.Text = "Comanda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.GhostWhite;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.Location = new Point(76, 478);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.GhostWhite;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(732, 492);
            label6.Name = "label6";
            label6.Size = new Size(122, 19);
            label6.TabIndex = 13;
            label6.Text = "Cota TVA: 19%";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1067, 994);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelCostTotal);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewProduse);
            Controls.Add(dataGridViewClient);
            Controls.Add(dataGridViewFurnizor);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Factura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFurnizor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label labelCostTotal;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}