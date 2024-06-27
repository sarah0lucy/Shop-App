namespace Magazin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login = new Button();
            RegisterLink = new LinkLabel();
            logo = new PictureBox();
            logoname = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoname).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(228, 280);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            label2.Location = new Point(253, 321);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Parola:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(341, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(341, 321);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 4;
            // 
            // Login
            // 
            Login.BackColor = Color.DarkCyan;
            Login.FlatStyle = FlatStyle.Popup;
            Login.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Login.Location = new Point(319, 394);
            Login.Name = "Login";
            Login.Size = new Size(110, 34);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Location = new Point(278, 362);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(196, 20);
            RegisterLink.TabIndex = 6;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Nu ai cont? Inregistreaza-te!";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.birdy2;
            logo.Location = new Point(278, 25);
            logo.Name = "logo";
            logo.Size = new Size(235, 161);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 7;
            logo.TabStop = false;
            // 
            // logoname
            // 
            logoname.Image = Properties.Resources.generatedtext;
            logoname.Location = new Point(228, 182);
            logoname.Name = "logoname";
            logoname.Size = new Size(334, 89);
            logoname.TabIndex = 8;
            logoname.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(logoname);
            Controls.Add(RegisterLink);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "𝔹𝕚𝕣𝕕𝕝𝕪𝕊𝕙𝕠𝕡";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoname).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Login;
        private LinkLabel RegisterLink;
        private PictureBox logo;
        private PictureBox logoname;
    }
}
