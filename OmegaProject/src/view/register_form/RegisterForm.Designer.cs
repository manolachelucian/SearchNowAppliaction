namespace OmegaProject.src
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            _registerBtn = new Button();
            username = new TextBox();
            password = new TextBox();
            _usernameLabel = new Label();
            _passwordLabel = new Label();
            _btnLoginForm = new Button();
            email_label = new Label();
            label_displayName = new Label();
            label_dateOfBirth = new Label();
            email = new TextBox();
            displayName = new TextBox();
            birth = new DateTimePicker();
            labelConfirmPassword = new Label();
            confirmPassword = new TextBox();
            registerShowPassword = new CheckBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(49, 32);
            label1.Name = "label1";
            label1.Size = new Size(169, 40);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // _registerBtn
            // 
            _registerBtn.BackColor = Color.RoyalBlue;
            _registerBtn.Cursor = Cursors.Hand;
            _registerBtn.FlatStyle = FlatStyle.Flat;
            _registerBtn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _registerBtn.ForeColor = Color.White;
            _registerBtn.Location = new Point(51, 363);
            _registerBtn.Name = "_registerBtn";
            _registerBtn.Size = new Size(216, 40);
            _registerBtn.TabIndex = 1;
            _registerBtn.Text = "Create Account";
            _registerBtn.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            username.BackColor = Color.White;
            username.BorderStyle = BorderStyle.None;
            username.Cursor = Cursors.IBeam;
            username.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.Gray;
            username.Location = new Point(51, 130);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(216, 30);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.BorderStyle = BorderStyle.None;
            password.Cursor = Cursors.IBeam;
            password.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.Gray;
            password.Location = new Point(51, 202);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(216, 30);
            password.TabIndex = 3;
            // 
            // _usernameLabel
            // 
            _usernameLabel.AutoSize = true;
            _usernameLabel.FlatStyle = FlatStyle.Flat;
            _usernameLabel.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _usernameLabel.Location = new Point(49, 110);
            _usernameLabel.Name = "_usernameLabel";
            _usernameLabel.Size = new Size(111, 17);
            _usernameLabel.TabIndex = 4;
            _usernameLabel.Text = "Create username";
            // 
            // _passwordLabel
            // 
            _passwordLabel.AutoSize = true;
            _passwordLabel.BackColor = Color.White;
            _passwordLabel.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _passwordLabel.Location = new Point(51, 176);
            _passwordLabel.Name = "_passwordLabel";
            _passwordLabel.Size = new Size(109, 17);
            _passwordLabel.TabIndex = 5;
            _passwordLabel.Text = "Create password";
            // 
            // _btnLoginForm
            // 
            _btnLoginForm.BackColor = Color.White;
            _btnLoginForm.Cursor = Cursors.Hand;
            _btnLoginForm.FlatAppearance.BorderSize = 0;
            _btnLoginForm.FlatStyle = FlatStyle.Flat;
            _btnLoginForm.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _btnLoginForm.ForeColor = Color.RoyalBlue;
            _btnLoginForm.Location = new Point(381, 371);
            _btnLoginForm.Margin = new Padding(0);
            _btnLoginForm.Name = "_btnLoginForm";
            _btnLoginForm.Size = new Size(91, 26);
            _btnLoginForm.TabIndex = 6;
            _btnLoginForm.Text = "Back to login";
            _btnLoginForm.UseVisualStyleBackColor = false;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(335, 110);
            email_label.Name = "email_label";
            email_label.Size = new Size(42, 17);
            email_label.TabIndex = 7;
            email_label.Text = "Email";
            // 
            // label_displayName
            // 
            label_displayName.AutoSize = true;
            label_displayName.Location = new Point(335, 176);
            label_displayName.Name = "label_displayName";
            label_displayName.Size = new Size(96, 17);
            label_displayName.TabIndex = 8;
            label_displayName.Text = "Display name ";
            // 
            // label_dateOfBirth
            // 
            label_dateOfBirth.AutoSize = true;
            label_dateOfBirth.Location = new Point(335, 245);
            label_dateOfBirth.Name = "label_dateOfBirth";
            label_dateOfBirth.Size = new Size(88, 17);
            label_dateOfBirth.TabIndex = 9;
            label_dateOfBirth.Text = "Date of birth";
            // 
            // email
            // 
            email.BackColor = Color.White;
            email.BorderStyle = BorderStyle.None;
            email.Cursor = Cursors.IBeam;
            email.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Gray;
            email.Location = new Point(335, 130);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(216, 30);
            email.TabIndex = 10;
            // 
            // displayName
            // 
            displayName.BackColor = Color.White;
            displayName.BorderStyle = BorderStyle.None;
            displayName.Cursor = Cursors.IBeam;
            displayName.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayName.ForeColor = Color.Gray;
            displayName.Location = new Point(335, 202);
            displayName.Multiline = true;
            displayName.Name = "displayName";
            displayName.Size = new Size(216, 30);
            displayName.TabIndex = 11;
            // 
            // birth
            // 
            birth.CalendarForeColor = Color.White;
            birth.CalendarMonthBackground = Color.DarkGray;
            birth.CalendarTitleBackColor = Color.DarkGray;
            birth.CalendarTitleForeColor = Color.White;
            birth.Cursor = Cursors.Hand;
            birth.CustomFormat = "yyyy-MM-dd";
            birth.Format = DateTimePickerFormat.Custom;
            birth.Location = new Point(335, 275);
            birth.MaxDate = new DateTime(2006, 4, 22, 0, 0, 0, 0);
            birth.MinDate = new DateTime(1910, 1, 1, 0, 0, 0, 0);
            birth.Name = "birth";
            birth.Size = new Size(216, 25);
            birth.TabIndex = 12;
            birth.Value = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(51, 245);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(120, 17);
            labelConfirmPassword.TabIndex = 13;
            labelConfirmPassword.Text = "Confirm password";
            // 
            // confirmPassword
            // 
            confirmPassword.BackColor = Color.White;
            confirmPassword.BorderStyle = BorderStyle.None;
            confirmPassword.Cursor = Cursors.IBeam;
            confirmPassword.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPassword.ForeColor = Color.Gray;
            confirmPassword.Location = new Point(51, 275);
            confirmPassword.Multiline = true;
            confirmPassword.Name = "confirmPassword";
            confirmPassword.PasswordChar = '*';
            confirmPassword.Size = new Size(216, 30);
            confirmPassword.TabIndex = 14;
            // 
            // registerShowPassword
            // 
            registerShowPassword.AutoSize = true;
            registerShowPassword.Cursor = Cursors.Hand;
            registerShowPassword.FlatStyle = FlatStyle.Flat;
            registerShowPassword.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerShowPassword.Location = new Point(52, 324);
            registerShowPassword.Name = "registerShowPassword";
            registerShowPassword.Size = new Size(119, 21);
            registerShowPassword.TabIndex = 15;
            registerShowPassword.Text = "Show password";
            registerShowPassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 354);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 16;
            label2.Text = "I have already account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(51, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 1);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(51, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 1);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Location = new Point(51, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 1);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(335, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 1);
            panel4.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Location = new Point(335, 159);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 1);
            panel5.TabIndex = 18;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(604, 461);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(registerShowPassword);
            Controls.Add(confirmPassword);
            Controls.Add(labelConfirmPassword);
            Controls.Add(birth);
            Controls.Add(displayName);
            Controls.Add(email);
            Controls.Add(label_dateOfBirth);
            Controls.Add(label_displayName);
            Controls.Add(email_label);
            Controls.Add(_btnLoginForm);
            Controls.Add(_passwordLabel);
            Controls.Add(_usernameLabel);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(_registerBtn);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button _registerBtn;
        private TextBox username;
        private TextBox password;
        private Label _usernameLabel;
        private Label _passwordLabel;
        private Button _btnLoginForm;
        private Label email_label;
        private Label label_displayName;
        private Label label_dateOfBirth;
        private TextBox email;
        private TextBox displayName;
        private DateTimePicker birth;
        private Label labelConfirmPassword;
        private TextBox confirmPassword;
        private CheckBox registerShowPassword;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}