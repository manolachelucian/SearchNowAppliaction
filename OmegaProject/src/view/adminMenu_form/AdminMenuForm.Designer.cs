namespace SearchNow.src.adminMenu_form
{
    partial class AdminMenuForm
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
            adminMenu = new Panel();
            banRadio = new RadioButton();
            suspendRadio = new RadioButton();
            usernameLabel = new Label();
            buttonUnbanUser = new Button();
            bannedUserTextBox = new TextBox();
            buttonBanUser = new Button();
            adminMenu.SuspendLayout();
            SuspendLayout();
            // 
            // adminMenu
            // 
            adminMenu.BackColor = Color.Transparent;
            adminMenu.Controls.Add(banRadio);
            adminMenu.Controls.Add(suspendRadio);
            adminMenu.Controls.Add(usernameLabel);
            adminMenu.Controls.Add(buttonUnbanUser);
            adminMenu.Controls.Add(bannedUserTextBox);
            adminMenu.Controls.Add(buttonBanUser);
            adminMenu.Location = new Point(35, 29);
            adminMenu.Name = "adminMenu";
            adminMenu.Size = new Size(300, 120);
            adminMenu.TabIndex = 17;
            // 
            // banRadio
            // 
            banRadio.AutoSize = true;
            banRadio.Cursor = Cursors.Hand;
            banRadio.FlatAppearance.BorderSize = 0;
            banRadio.FlatStyle = FlatStyle.Flat;
            banRadio.ForeColor = Color.Gray;
            banRadio.Location = new Point(159, 10);
            banRadio.Name = "banRadio";
            banRadio.Size = new Size(46, 21);
            banRadio.TabIndex = 18;
            banRadio.TabStop = true;
            banRadio.Text = "Ban";
            banRadio.UseVisualStyleBackColor = true;
            // 
            // suspendRadio
            // 
            suspendRadio.AutoSize = true;
            suspendRadio.Cursor = Cursors.Hand;
            suspendRadio.FlatStyle = FlatStyle.Flat;
            suspendRadio.ForeColor = Color.Gray;
            suspendRadio.Location = new Point(221, 10);
            suspendRadio.Name = "suspendRadio";
            suspendRadio.Size = new Size(75, 21);
            suspendRadio.TabIndex = 17;
            suspendRadio.TabStop = true;
            suspendRadio.Text = "Suspend";
            suspendRadio.UseVisualStyleBackColor = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.RoyalBlue;
            usernameLabel.Location = new Point(4, 5);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(149, 25);
            usernameLabel.TabIndex = 16;
            usernameLabel.Text = "Enter username ";
            // 
            // buttonUnbanUser
            // 
            buttonUnbanUser.Cursor = Cursors.Hand;
            buttonUnbanUser.FlatStyle = FlatStyle.Flat;
            buttonUnbanUser.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUnbanUser.ForeColor = Color.RoyalBlue;
            buttonUnbanUser.Location = new Point(4, 73);
            buttonUnbanUser.Name = "buttonUnbanUser";
            buttonUnbanUser.Size = new Size(143, 34);
            buttonUnbanUser.TabIndex = 14;
            buttonUnbanUser.Text = "Unban user";
            buttonUnbanUser.UseVisualStyleBackColor = true;
            // 
            // bannedUserTextBox
            // 
            bannedUserTextBox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bannedUserTextBox.ForeColor = Color.Gray;
            bannedUserTextBox.Location = new Point(4, 33);
            bannedUserTextBox.Multiline = true;
            bannedUserTextBox.Name = "bannedUserTextBox";
            bannedUserTextBox.Size = new Size(293, 34);
            bannedUserTextBox.TabIndex = 15;
            // 
            // buttonBanUser
            // 
            buttonBanUser.BackColor = Color.RoyalBlue;
            buttonBanUser.Cursor = Cursors.Hand;
            buttonBanUser.FlatAppearance.BorderSize = 0;
            buttonBanUser.FlatStyle = FlatStyle.Flat;
            buttonBanUser.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBanUser.ForeColor = Color.White;
            buttonBanUser.Location = new Point(159, 73);
            buttonBanUser.Name = "buttonBanUser";
            buttonBanUser.Size = new Size(138, 34);
            buttonBanUser.TabIndex = 13;
            buttonBanUser.Text = "ban user";
            buttonBanUser.UseVisualStyleBackColor = false;
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 161);
            Controls.Add(adminMenu);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenuForm";
            adminMenu.ResumeLayout(false);
            adminMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel adminMenu;
        private RadioButton banRadio;
        private RadioButton suspendRadio;
        private Label usernameLabel;
        private Button buttonUnbanUser;
        private TextBox bannedUserTextBox;
        private Button buttonBanUser;
    }
}