namespace OmegaProject.src
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            listBoxForums = new ListBox();
            createDiscussion = new Button();
            searchForum = new TextBox();
            searchForumButton = new Button();
            _btnLogOut = new Button();
            profile_form = new Button();
            panel1 = new Panel();
            labelDisplayNameProfile = new Label();
            panel2 = new Panel();
            label4 = new Label();
            searchProfile = new Button();
            myForumsButton = new Button();
            adminMenuButton = new Button();
            searchUser_textbox = new TextBox();
            panel3 = new Panel();
            refreshForumButton = new Button();
            filterBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxForums
            // 
            listBoxForums.BackColor = Color.WhiteSmoke;
            listBoxForums.BorderStyle = BorderStyle.None;
            listBoxForums.Cursor = Cursors.Hand;
            listBoxForums.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxForums.ForeColor = Color.Gray;
            listBoxForums.FormattingEnabled = true;
            listBoxForums.ItemHeight = 25;
            listBoxForums.Location = new Point(35, 159);
            listBoxForums.Margin = new Padding(0);
            listBoxForums.Name = "listBoxForums";
            listBoxForums.Size = new Size(650, 400);
            listBoxForums.TabIndex = 6;
            // 
            // createDiscussion
            // 
            createDiscussion.BackColor = Color.Transparent;
            createDiscussion.Cursor = Cursors.Hand;
            createDiscussion.FlatAppearance.BorderColor = Color.LightGray;
            createDiscussion.FlatStyle = FlatStyle.Flat;
            createDiscussion.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createDiscussion.ForeColor = Color.Black;
            createDiscussion.Image = (Image)resources.GetObject("createDiscussion.Image");
            createDiscussion.ImageAlign = ContentAlignment.MiddleLeft;
            createDiscussion.Location = new Point(12, 122);
            createDiscussion.Name = "createDiscussion";
            createDiscussion.Size = new Size(145, 40);
            createDiscussion.TabIndex = 9;
            createDiscussion.Text = "Create Forum";
            createDiscussion.TextAlign = ContentAlignment.MiddleRight;
            createDiscussion.UseVisualStyleBackColor = false;
            // 
            // searchForum
            // 
            searchForum.BorderStyle = BorderStyle.FixedSingle;
            searchForum.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchForum.ForeColor = Color.Gray;
            searchForum.Location = new Point(347, 114);
            searchForum.Multiline = true;
            searchForum.Name = "searchForum";
            searchForum.Size = new Size(231, 32);
            searchForum.TabIndex = 10;
            // 
            // searchForumButton
            // 
            searchForumButton.BackColor = Color.RoyalBlue;
            searchForumButton.Cursor = Cursors.Hand;
            searchForumButton.FlatAppearance.BorderSize = 0;
            searchForumButton.FlatStyle = FlatStyle.Flat;
            searchForumButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchForumButton.ForeColor = Color.White;
            searchForumButton.Location = new Point(584, 114);
            searchForumButton.Name = "searchForumButton";
            searchForumButton.Size = new Size(101, 32);
            searchForumButton.TabIndex = 11;
            searchForumButton.Text = "Search";
            searchForumButton.UseVisualStyleBackColor = false;
            // 
            // _btnLogOut
            // 
            _btnLogOut.BackColor = Color.Transparent;
            _btnLogOut.Cursor = Cursors.Hand;
            _btnLogOut.FlatAppearance.BorderSize = 0;
            _btnLogOut.FlatStyle = FlatStyle.Flat;
            _btnLogOut.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _btnLogOut.ForeColor = Color.Transparent;
            _btnLogOut.Image = (Image)resources.GetObject("_btnLogOut.Image");
            _btnLogOut.Location = new Point(52, 520);
            _btnLogOut.Name = "_btnLogOut";
            _btnLogOut.Size = new Size(43, 45);
            _btnLogOut.TabIndex = 3;
            _btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            _btnLogOut.UseVisualStyleBackColor = false;
            // 
            // profile_form
            // 
            profile_form.BackColor = Color.Transparent;
            profile_form.Cursor = Cursors.Hand;
            profile_form.FlatAppearance.BorderSize = 0;
            profile_form.FlatStyle = FlatStyle.Flat;
            profile_form.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profile_form.ForeColor = Color.Transparent;
            profile_form.Image = (Image)resources.GetObject("profile_form.Image");
            profile_form.Location = new Point(853, 12);
            profile_form.Name = "profile_form";
            profile_form.RightToLeft = RightToLeft.No;
            profile_form.Size = new Size(35, 36);
            profile_form.TabIndex = 5;
            profile_form.TextAlign = ContentAlignment.MiddleLeft;
            profile_form.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(labelDisplayNameProfile);
            panel1.Controls.Add(profile_form);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 60);
            panel1.TabIndex = 12;
            // 
            // labelDisplayNameProfile
            // 
            labelDisplayNameProfile.AutoSize = true;
            labelDisplayNameProfile.BackColor = Color.Transparent;
            labelDisplayNameProfile.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDisplayNameProfile.Location = new Point(766, 20);
            labelDisplayNameProfile.Name = "labelDisplayNameProfile";
            labelDisplayNameProfile.Size = new Size(46, 20);
            labelDisplayNameProfile.TabIndex = 6;
            labelDisplayNameProfile.Text = "name";
            labelDisplayNameProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(_btnLogOut);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(searchProfile);
            panel2.Controls.Add(myForumsButton);
            panel2.Controls.Add(adminMenuButton);
            panel2.Controls.Add(searchUser_textbox);
            panel2.Controls.Add(createDiscussion);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 590);
            panel2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(6, 6);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 14;
            label4.Text = "Search User";
            // 
            // searchProfile
            // 
            searchProfile.BackColor = Color.Transparent;
            searchProfile.Cursor = Cursors.Hand;
            searchProfile.FlatAppearance.BorderColor = Color.LightGray;
            searchProfile.FlatStyle = FlatStyle.Flat;
            searchProfile.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchProfile.ForeColor = Color.DimGray;
            searchProfile.Image = (Image)resources.GetObject("searchProfile.Image");
            searchProfile.ImageAlign = ContentAlignment.MiddleLeft;
            searchProfile.Location = new Point(21, 61);
            searchProfile.Name = "searchProfile";
            searchProfile.Size = new Size(123, 34);
            searchProfile.TabIndex = 11;
            searchProfile.Text = "Search Profile";
            searchProfile.TextAlign = ContentAlignment.MiddleRight;
            searchProfile.UseVisualStyleBackColor = false;
            // 
            // myForumsButton
            // 
            myForumsButton.BackColor = Color.Transparent;
            myForumsButton.Cursor = Cursors.Hand;
            myForumsButton.FlatAppearance.BorderColor = Color.LightGray;
            myForumsButton.FlatStyle = FlatStyle.Flat;
            myForumsButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myForumsButton.ForeColor = Color.Black;
            myForumsButton.ImageAlign = ContentAlignment.MiddleLeft;
            myForumsButton.Location = new Point(12, 187);
            myForumsButton.Name = "myForumsButton";
            myForumsButton.Size = new Size(145, 40);
            myForumsButton.TabIndex = 12;
            myForumsButton.Text = "My Forums";
            myForumsButton.UseVisualStyleBackColor = false;
            // 
            // adminMenuButton
            // 
            adminMenuButton.BackColor = Color.Transparent;
            adminMenuButton.Cursor = Cursors.Hand;
            adminMenuButton.FlatAppearance.BorderColor = Color.LightGray;
            adminMenuButton.FlatStyle = FlatStyle.Flat;
            adminMenuButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminMenuButton.ForeColor = Color.Black;
            adminMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            adminMenuButton.Location = new Point(12, 252);
            adminMenuButton.Name = "adminMenuButton";
            adminMenuButton.Size = new Size(145, 40);
            adminMenuButton.TabIndex = 10;
            adminMenuButton.Text = "Admin Menu";
            adminMenuButton.UseVisualStyleBackColor = false;
            // 
            // searchUser_textbox
            // 
            searchUser_textbox.Cursor = Cursors.IBeam;
            searchUser_textbox.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchUser_textbox.ForeColor = Color.Gray;
            searchUser_textbox.Location = new Point(6, 26);
            searchUser_textbox.Multiline = true;
            searchUser_textbox.Name = "searchUser_textbox";
            searchUser_textbox.Size = new Size(170, 30);
            searchUser_textbox.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(refreshForumButton);
            panel3.Controls.Add(filterBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(searchForumButton);
            panel3.Controls.Add(listBoxForums);
            panel3.Controls.Add(searchForum);
            panel3.Location = new Point(182, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 572);
            panel3.TabIndex = 18;
            // 
            // refreshForumButton
            // 
            refreshForumButton.Cursor = Cursors.Hand;
            refreshForumButton.FlatAppearance.BorderSize = 0;
            refreshForumButton.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshForumButton.ForeColor = Color.RoyalBlue;
            refreshForumButton.Location = new Point(35, 114);
            refreshForumButton.Name = "refreshForumButton";
            refreshForumButton.Size = new Size(75, 42);
            refreshForumButton.TabIndex = 16;
            refreshForumButton.Text = "Refresh";
            refreshForumButton.UseVisualStyleBackColor = true;
            // 
            // filterBox
            // 
            filterBox.Cursor = Cursors.Hand;
            filterBox.FlatStyle = FlatStyle.Flat;
            filterBox.ForeColor = Color.Gray;
            filterBox.FormattingEnabled = true;
            filterBox.Location = new Point(132, 118);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(209, 25);
            filterBox.TabIndex = 15;
            filterBox.Text = "FILTER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(347, 90);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 14;
            label3.Text = "Enter forum name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(202, 21);
            label2.TabIndex = 13;
            label2.Text = "Here you can seach forums ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(126, 45);
            label1.TabIndex = 12;
            label1.Text = "Forums";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 650);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "MenuForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxForums;
        private Button createDiscussion;
        private TextBox searchForum;
        private Button searchForumButton;
        private Button _btnLogOut;
        private Button profile_form;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button adminMenuButton;
        private Button searchProfile;
        private Button myForumsButton;
        private Label label2;
        private Label label1;
        private ComboBox filterBox;
        private Label label3;
        private Button refreshForumButton;
        private Label labelDisplayNameProfile;
        private Label label4;
        private TextBox searchUser_textbox;
    }
}