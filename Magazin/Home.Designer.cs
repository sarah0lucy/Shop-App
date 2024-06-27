namespace Magazin
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            toolStrip1 = new ToolStrip();
            ButonComanda = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            ButonStoc = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            ID = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            ButonFactura = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            ButonTrimite = new Button();
            ComandaText = new TextBox();
            ButonCos = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ButonComanda, toolStripSeparator4, toolStripSeparator1, ButonStoc, toolStripSeparator2, toolStripSeparator3, ID, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(800, 34);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // ButonComanda
            // 
            ButonComanda.BackColor = Color.Transparent;
            ButonComanda.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            ButonComanda.Name = "ButonComanda";
            ButonComanda.Size = new Size(198, 31);
            ButonComanda.Text = "Plaseaza comanda";
            ButonComanda.Click += ButonComanda_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 34);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // ButonStoc
            // 
            ButonStoc.BackColor = Color.Transparent;
            ButonStoc.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            ButonStoc.Name = "ButonStoc";
            ButonStoc.Size = new Size(52, 31);
            ButonStoc.Text = "Stoc";
            ButonStoc.Click += ButonStoc_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 34);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 34);
            // 
            // ID
            // 
            ID.Alignment = ToolStripItemAlignment.Right;
            ID.BackColor = Color.Transparent;
            ID.Name = "ID";
            ID.Padding = new Padding(10, 0, 0, 0);
            ID.Size = new Size(103, 31);
            ID.Text = "idClient";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.BackColor = Color.MintCream;
            toolStripButton1.BackgroundImageLayout = ImageLayout.None;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 31);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // ButonFactura
            // 
            ButonFactura.Location = new Point(665, 377);
            ButonFactura.Name = "ButonFactura";
            ButonFactura.Size = new Size(123, 47);
            ButonFactura.TabIndex = 3;
            ButonFactura.Text = "Vezi factura";
            ButonFactura.UseVisualStyleBackColor = true;
            ButonFactura.Click += ButonFactura_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 34);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button1.Location = new Point(425, 42);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(32, 168);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(302, 204);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(425, 167);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(302, 204);
            listBox2.TabIndex = 7;
            // 
            // ButonTrimite
            // 
            ButonTrimite.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            ButonTrimite.Location = new Point(511, 195);
            ButonTrimite.Name = "ButonTrimite";
            ButonTrimite.Size = new Size(110, 39);
            ButonTrimite.TabIndex = 8;
            ButonTrimite.Text = "Trimite";
            ButonTrimite.UseVisualStyleBackColor = true;
            ButonTrimite.Click += ButonTrimite_Click;
            // 
            // ComandaText
            // 
            ComandaText.Location = new Point(32, 134);
            ComandaText.Multiline = true;
            ComandaText.Name = "ComandaText";
            ComandaText.Size = new Size(344, 244);
            ComandaText.TabIndex = 9;
            // 
            // ButonCos
            // 
            ButonCos.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            ButonCos.Location = new Point(511, 257);
            ButonCos.Name = "ButonCos";
            ButonCos.Size = new Size(110, 39);
            ButonCos.TabIndex = 10;
            ButonCos.Text = "Vezi Cos";
            ButonCos.UseVisualStyleBackColor = true;
            ButonCos.Click += ButonCos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(599, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 106);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(443, 94);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 12;
            label1.Text = "Vezi cod QR ->";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ButonCos);
            Controls.Add(ComandaText);
            Controls.Add(ButonTrimite);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(ButonFactura);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripLabel ButonComanda;
        private ToolStripLabel ButonStoc;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel ID;
        private Button ButonFactura;
        private ToolStripSeparator toolStripSeparator2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private Button ButonTrimite;
        private TextBox ComandaText;
        private Button ButonCos;
        private ToolStripSeparator toolStripSeparator4;
        private PictureBox pictureBox1;
        private Label label1;
    }
}