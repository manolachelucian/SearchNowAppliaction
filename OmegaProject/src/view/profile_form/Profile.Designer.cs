namespace OmegaProject.src.profile_form
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            _labelUserName = new Label();
            _labelEmail = new Label();
            _labelCreatedAt = new Label();
            _labelRole = new Label();
            _labelAccountStatus = new Label();
            label1 = new Label();
            _bio = new TextBox();
            _updateBio = new Button();
            _labelDisplayName = new Label();
            labelProf = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonSettings = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // _labelUserName
            // 
            _labelUserName.AutoSize = true;
            _labelUserName.BackColor = Color.White;
            _labelUserName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _labelUserName.Location = new Point(185, 110);
            _labelUserName.Margin = new Padding(0);
            _labelUserName.Name = "_labelUserName";
            _labelUserName.Size = new Size(68, 17);
            _labelUserName.TabIndex = 1;
            _labelUserName.Text = "username";
            // 
            // _labelEmail
            // 
            _labelEmail.AutoSize = true;
            _labelEmail.BackColor = Color.Transparent;
            _labelEmail.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _labelEmail.Location = new Point(185, 162);
            _labelEmail.Name = "_labelEmail";
            _labelEmail.Size = new Size(42, 17);
            _labelEmail.TabIndex = 2;
            _labelEmail.Text = "email";
            // 
            // _labelCreatedAt
            // 
            _labelCreatedAt.AutoSize = true;
            _labelCreatedAt.BackColor = Color.Transparent;
            _labelCreatedAt.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _labelCreatedAt.Location = new Point(185, 250);
            _labelCreatedAt.Name = "_labelCreatedAt";
            _labelCreatedAt.Size = new Size(16, 17);
            _labelCreatedAt.TabIndex = 3;
            _labelCreatedAt.Text = ": ";
            // 
            // _labelRole
            // 
            _labelRole.AutoSize = true;
            _labelRole.BackColor = Color.Transparent;
            _labelRole.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _labelRole.Location = new Point(185, 219);
            _labelRole.Name = "_labelRole";
            _labelRole.Size = new Size(34, 17);
            _labelRole.TabIndex = 4;
            _labelRole.Text = "user";
            // 
            // _labelAccountStatus
            // 
            _labelAccountStatus.AutoSize = true;
            _labelAccountStatus.BackColor = Color.Transparent;
            _labelAccountStatus.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _labelAccountStatus.ForeColor = Color.Green;
            _labelAccountStatus.Location = new Point(185, 189);
            _labelAccountStatus.Name = "_labelAccountStatus";
            _labelAccountStatus.Size = new Size(44, 17);
            _labelAccountStatus.TabIndex = 5;
            _labelAccountStatus.Text = "active";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 370);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 6;
            label1.Text = "bio";
            // 
            // _bio
            // 
            _bio.BackColor = Color.WhiteSmoke;
            _bio.BorderStyle = BorderStyle.None;
            _bio.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _bio.ForeColor = Color.Gray;
            _bio.Location = new Point(44, 395);
            _bio.Margin = new Padding(3, 4, 3, 4);
            _bio.Multiline = true;
            _bio.Name = "_bio";
            _bio.Size = new Size(300, 81);
            _bio.TabIndex = 7;
            // 
            // _updateBio
            // 
            _updateBio.BackColor = Color.RoyalBlue;
            _updateBio.Cursor = Cursors.Hand;
            _updateBio.FlatAppearance.BorderSize = 0;
            _updateBio.FlatStyle = FlatStyle.Flat;
            _updateBio.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _updateBio.ForeColor = Color.White;
            _updateBio.Location = new Point(44, 482);
            _updateBio.Margin = new Padding(2);
            _updateBio.Name = "_updateBio";
            _updateBio.Size = new Size(300, 50);
            _updateBio.TabIndex = 8;
            _updateBio.Text = "Update";
            _updateBio.UseVisualStyleBackColor = false;
            _updateBio.Click += _updateBio_Click;
            // 
            // _labelDisplayName
            // 
            _labelDisplayName.AutoSize = true;
            _labelDisplayName.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _labelDisplayName.Location = new Point(185, 136);
            _labelDisplayName.Margin = new Padding(0);
            _labelDisplayName.Name = "_labelDisplayName";
            _labelDisplayName.Size = new Size(90, 17);
            _labelDisplayName.TabIndex = 9;
            _labelDisplayName.Text = "display name";
            // 
            // labelProf
            // 
            labelProf.AutoSize = true;
            labelProf.Font = new Font("Nirmala UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProf.ForeColor = Color.RoyalBlue;
            labelProf.Location = new Point(41, 21);
            labelProf.Margin = new Padding(2, 0, 2, 0);
            labelProf.Name = "labelProf";
            labelProf.Size = new Size(128, 47);
            labelProf.TabIndex = 10;
            labelProf.Text = "Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(44, 68);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 11;
            label2.Text = "Personal Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(44, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(43, 289);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 13;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.RoyalBlue;
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Location = new Point(44, 317);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(300, 50);
            buttonSettings.TabIndex = 15;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 110);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 16;
            label3.Text = "USERNAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 136);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 17;
            label4.Text = "DISPLAY NAME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 162);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 18;
            label5.Text = "E-MAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 189);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 19;
            label6.Text = "ACCOUNT-STATUS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(121, 219);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 20;
            label7.Text = "ROLE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 250);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 21;
            label8.Text = "CREATED AT";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(404, 561);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonSettings);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(labelProf);
            Controls.Add(_labelDisplayName);
            Controls.Add(_updateBio);
            Controls.Add(_bio);
            Controls.Add(label1);
            Controls.Add(_labelAccountStatus);
            Controls.Add(_labelRole);
            Controls.Add(_labelCreatedAt);
            Controls.Add(_labelEmail);
            Controls.Add(_labelUserName);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label _labelUserName;
        private Label _labelEmail;
        private Label _labelCreatedAt;
        private Label _labelRole;
        private Label _labelAccountStatus;
        private Label label1;
        private TextBox _bio;
        private Button _updateBio;
        private Label _labelDisplayName;
        private Label labelProf;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button buttonSettings;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}