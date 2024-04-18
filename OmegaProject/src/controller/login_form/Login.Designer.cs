namespace OmegaProject
{
    partial class Login
    {
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            btnCheckCon = new Button();
            btnLogin = new Button();
            btnRegister = new Button();
            username = new TextBox();
            password = new TextBox();
            labelPass = new Label();
            labelUsername = new Label();
            _passwordShow = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lock_icon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lock_icon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 474);
            label1.Name = "label1";
            label1.Size = new Size(177, 17);
            label1.TabIndex = 0;
            label1.Text = "Check Database connection";
            // 
            // btnCheckCon
            // 
            btnCheckCon.Cursor = Cursors.Hand;
            btnCheckCon.FlatAppearance.BorderSize = 0;
            btnCheckCon.FlatStyle = FlatStyle.Flat;
            btnCheckCon.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckCon.ForeColor = Color.RoyalBlue;
            btnCheckCon.Location = new Point(106, 504);
            btnCheckCon.Name = "btnCheckCon";
            btnCheckCon.Size = new Size(53, 25);
            btnCheckCon.TabIndex = 1;
            btnCheckCon.Text = "Check";
            btnCheckCon.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.RoyalBlue;
            btnRegister.Location = new Point(73, 410);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 24);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Cursor = Cursors.IBeam;
            username.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.Gray;
            username.Location = new Point(57, 151);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(193, 30);
            username.TabIndex = 4;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Gray;
            password.Location = new Point(54, 236);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(193, 30);
            password.TabIndex = 5;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.FlatStyle = FlatStyle.Flat;
            labelPass.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPass.Location = new Point(30, 210);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(66, 17);
            labelPass.TabIndex = 6;
            labelPass.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(31, 127);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(69, 17);
            labelUsername.TabIndex = 7;
            labelUsername.Text = "Username";
            // 
            // _passwordShow
            // 
            _passwordShow.AutoSize = true;
            _passwordShow.Cursor = Cursors.Hand;
            _passwordShow.FlatStyle = FlatStyle.Flat;
            _passwordShow.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _passwordShow.Location = new Point(31, 276);
            _passwordShow.Name = "_passwordShow";
            _passwordShow.Size = new Size(119, 21);
            _passwordShow.TabIndex = 9;
            _passwordShow.Text = "Show password";
            _passwordShow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(31, 48);
            label2.Name = "label2";
            label2.Size = new Size(104, 45);
            label2.TabIndex = 10;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 381);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 11;
            label3.Text = "Dont have an Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(34, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 1);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(31, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 1);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lock_icon
            // 
            lock_icon.Image = (Image)resources.GetObject("lock_icon.Image");
            lock_icon.Location = new Point(30, 230);
            lock_icon.Name = "lock_icon";
            lock_icon.Size = new Size(24, 30);
            lock_icon.SizeMode = PictureBoxSizeMode.Zoom;
            lock_icon.TabIndex = 15;
            lock_icon.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(285, 550);
            Controls.Add(lock_icon);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(_passwordShow);
            Controls.Add(labelUsername);
            Controls.Add(labelPass);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(btnCheckCon);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lock_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCheckCon;
        private Button btnLogin;
        private Button btnRegister;
        private TextBox username;
        private TextBox password;
        private Label labelPass;
        private Label labelUsername;
        private CheckBox _passwordShow;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox lock_icon;
    }



}
