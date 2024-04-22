namespace SearchNow.src.controller.search_profile_form
{
    partial class SearchProfile
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
            label1 = new Label();
            panel1 = new Panel();
            status = new Label();
            birth = new Label();
            bio = new Label();
            email = new Label();
            username = new Label();
            displayname = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(179, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // panel1
            // 
            panel1.Controls.Add(status);
            panel1.Controls.Add(birth);
            panel1.Controls.Add(bio);
            panel1.Controls.Add(email);
            panel1.Controls.Add(username);
            panel1.Controls.Add(displayname);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = Color.RoyalBlue;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 409);
            panel1.TabIndex = 1;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(155, 248);
            status.Name = "status";
            status.Size = new Size(97, 17);
            status.TabIndex = 5;
            status.Text = "Account Status ";
            // 
            // birth
            // 
            birth.AutoSize = true;
            birth.Location = new Point(171, 188);
            birth.Name = "birth";
            birth.Size = new Size(73, 17);
            birth.TabIndex = 4;
            birth.Text = "dateofbirth";
            // 
            // bio
            // 
            bio.AutoSize = true;
            bio.Location = new Point(179, 308);
            bio.Name = "bio";
            bio.Size = new Size(27, 17);
            bio.TabIndex = 3;
            bio.Text = "bio";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(179, 134);
            email.Name = "email";
            email.Size = new Size(39, 17);
            email.TabIndex = 2;
            email.Text = "email";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(179, 28);
            username.Name = "username";
            username.Size = new Size(65, 17);
            username.TabIndex = 1;
            username.Text = "username";
            // 
            // displayname
            // 
            displayname.AutoSize = true;
            displayname.Location = new Point(173, 81);
            displayname.Name = "displayname";
            displayname.Size = new Size(79, 17);
            displayname.TabIndex = 0;
            displayname.Text = "displatname";
            // 
            // SearchProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchProfile";
            Text = "SearchProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label birth;
        private Label bio;
        private Label email;
        private Label username;
        private Label displayname;
        private Label status;
    }
}