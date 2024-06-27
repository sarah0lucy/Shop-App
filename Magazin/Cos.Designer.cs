namespace Magazin
{
    partial class Cos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cos));
            dataGridView1 = new DataGridView();
            ButonFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumPurple;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 366);
            dataGridView1.TabIndex = 0;
            // 
            // ButonFactura
            // 
            ButonFactura.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            ButonFactura.Location = new Point(552, 396);
            ButonFactura.Name = "ButonFactura";
            ButonFactura.Size = new Size(220, 41);
            ButonFactura.TabIndex = 1;
            ButonFactura.Text = "Vezi factura";
            ButonFactura.UseVisualStyleBackColor = true;
            ButonFactura.Click += ButonFactura_Click;
            // 
            // Cos
            // 
            BackColor = Color.Thistle;
            ClientSize = new Size(784, 461);
            Controls.Add(ButonFactura);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cos";
            Text = "Cos";
            Load += Cos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Button ButonFactura;
    }
}