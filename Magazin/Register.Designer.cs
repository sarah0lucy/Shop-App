namespace Magazin
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Username = new Label();
            Email = new Label();
            Parola = new Label();
            Parola2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BoxUsername = new TextBox();
            BoxEmail = new TextBox();
            BoxParola = new TextBox();
            BoxParola2 = new TextBox();
            Intro = new Label();
            Signin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Username.Location = new Point(233, 153);
            Username.Name = "Username";
            Username.Size = new Size(86, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Email.Location = new Point(265, 211);
            Email.Name = "Email";
            Email.Size = new Size(54, 20);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // Parola
            // 
            Parola.AutoSize = true;
            Parola.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Parola.Location = new Point(259, 264);
            Parola.Name = "Parola";
            Parola.Size = new Size(60, 20);
            Parola.TabIndex = 2;
            Parola.Text = "Parola";
            // 
            // Parola2
            // 
            Parola2.AutoSize = true;
            Parola2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Parola2.Location = new Point(180, 293);
            Parola2.Name = "Parola2";
            Parola2.Size = new Size(139, 20);
            Parola2.TabIndex = 3;
            Parola2.Text = "Confirma parola";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(173, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // BoxUsername
            // 
            BoxUsername.BorderStyle = BorderStyle.FixedSingle;
            BoxUsername.Location = new Point(364, 146);
            BoxUsername.Name = "BoxUsername";
            BoxUsername.Size = new Size(219, 27);
            BoxUsername.TabIndex = 6;
            // 
            // BoxEmail
            // 
            BoxEmail.BorderStyle = BorderStyle.FixedSingle;
            BoxEmail.Location = new Point(364, 204);
            BoxEmail.Name = "BoxEmail";
            BoxEmail.Size = new Size(219, 27);
            BoxEmail.TabIndex = 7;
            // 
            // BoxParola
            // 
            BoxParola.BorderStyle = BorderStyle.FixedSingle;
            BoxParola.Location = new Point(364, 257);
            BoxParola.Name = "BoxParola";
            BoxParola.PasswordChar = '*';
            BoxParola.Size = new Size(219, 27);
            BoxParola.TabIndex = 8;
            // 
            // BoxParola2
            // 
            BoxParola2.BorderStyle = BorderStyle.FixedSingle;
            BoxParola2.Location = new Point(364, 291);
            BoxParola2.Name = "BoxParola2";
            BoxParola2.PasswordChar = '*';
            BoxParola2.Size = new Size(219, 27);
            BoxParola2.TabIndex = 9;
            // 
            // Intro
            // 
            Intro.AutoSize = true;
            Intro.Font = new Font("Times New Roman", 20.8F, FontStyle.Bold | FontStyle.Italic);
            Intro.ForeColor = Color.Black;
            Intro.Location = new Point(242, 76);
            Intro.Name = "Intro";
            Intro.Size = new Size(300, 41);
            Intro.TabIndex = 10;
            Intro.Text = "Creeaza-ti un cont!";
            // 
            // Signin
            // 
            Signin.BackColor = Color.DarkCyan;
            Signin.FlatStyle = FlatStyle.Popup;
            Signin.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            Signin.Location = new Point(339, 366);
            Signin.Name = "Signin";
            Signin.Size = new Size(110, 34);
            Signin.TabIndex = 11;
            Signin.Text = "Sign in";
            Signin.UseVisualStyleBackColor = false;
            Signin.Click += Signin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(Signin);
            Controls.Add(Intro);
            Controls.Add(BoxParola2);
            Controls.Add(BoxParola);
            Controls.Add(BoxEmail);
            Controls.Add(BoxUsername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Parola2);
            Controls.Add(Parola);
            Controls.Add(Email);
            Controls.Add(Username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Text = "Inregistreaza-te!";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Email;
        private Label Parola;
        private Label Parola2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox BoxUsername;
        private TextBox BoxEmail;
        private TextBox BoxParola;
        private TextBox BoxParola2;
        private Label Intro;
        private Button Signin;
    }
}