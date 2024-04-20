namespace OmegaProject.src.forum_form
{
    partial class ForumDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForumDetailsForm));
            labelForumName = new Label();
            labelDescription = new Label();
            labelCreatedAt = new Label();
            labelCreatedBy = new Label();
            textBoxComment = new TextBox();
            btnAddComment = new Button();
            listBoxComments = new ListBox();
            deleteButton = new Button();
            panel1 = new Panel();
            filterComboBox = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelForumName
            // 
            labelForumName.AutoSize = true;
            labelForumName.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForumName.ForeColor = Color.RoyalBlue;
            labelForumName.Location = new Point(13, 18);
            labelForumName.Margin = new Padding(4, 0, 4, 0);
            labelForumName.Name = "labelForumName";
            labelForumName.Size = new Size(166, 37);
            labelForumName.TabIndex = 0;
            labelForumName.Text = "Forum name";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(18, 65);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(98, 21);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Description";
            // 
            // labelCreatedAt
            // 
            labelCreatedAt.AutoSize = true;
            labelCreatedAt.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreatedAt.Location = new Point(18, 96);
            labelCreatedAt.Margin = new Padding(4, 0, 4, 0);
            labelCreatedAt.Name = "labelCreatedAt";
            labelCreatedAt.Size = new Size(88, 21);
            labelCreatedAt.TabIndex = 2;
            labelCreatedAt.Text = "Created at";
            // 
            // labelCreatedBy
            // 
            labelCreatedBy.AutoSize = true;
            labelCreatedBy.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreatedBy.Location = new Point(18, 127);
            labelCreatedBy.Margin = new Padding(4, 0, 4, 0);
            labelCreatedBy.Name = "labelCreatedBy";
            labelCreatedBy.Size = new Size(92, 21);
            labelCreatedBy.TabIndex = 3;
            labelCreatedBy.Text = "Created by";
            // 
            // textBoxComment
            // 
            textBoxComment.BorderStyle = BorderStyle.FixedSingle;
            textBoxComment.Location = new Point(18, 170);
            textBoxComment.Margin = new Padding(4, 3, 4, 3);
            textBoxComment.Multiline = true;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(466, 64);
            textBoxComment.TabIndex = 4;
            // 
            // btnAddComment
            // 
            btnAddComment.BackColor = Color.RoyalBlue;
            btnAddComment.Cursor = Cursors.Hand;
            btnAddComment.FlatAppearance.BorderSize = 0;
            btnAddComment.FlatStyle = FlatStyle.Flat;
            btnAddComment.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddComment.ForeColor = Color.White;
            btnAddComment.Location = new Point(18, 240);
            btnAddComment.Margin = new Padding(4, 3, 4, 3);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(120, 30);
            btnAddComment.TabIndex = 5;
            btnAddComment.Text = "Comment";
            btnAddComment.UseVisualStyleBackColor = false;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // listBoxComments
            // 
            listBoxComments.BackColor = Color.LightGray;
            listBoxComments.BorderStyle = BorderStyle.None;
            listBoxComments.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxComments.FormattingEnabled = true;
            listBoxComments.ItemHeight = 21;
            listBoxComments.Location = new Point(12, 8);
            listBoxComments.Margin = new Padding(4, 3, 4, 3);
            listBoxComments.Name = "listBoxComments";
            listBoxComments.Size = new Size(472, 231);
            listBoxComments.TabIndex = 6;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(145, 240);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(120, 30);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxComments);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 276);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 251);
            panel1.TabIndex = 8;
            // 
            // filterComboBox
            // 
            filterComboBox.Cursor = Cursors.Hand;
            filterComboBox.FlatStyle = FlatStyle.Flat;
            filterComboBox.ForeColor = Color.Gray;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Location = new Point(364, 244);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(120, 25);
            filterComboBox.TabIndex = 9;
            filterComboBox.Text = "Filter";
            // 
            // ForumDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(498, 527);
            Controls.Add(filterComboBox);
            Controls.Add(panel1);
            Controls.Add(deleteButton);
            Controls.Add(btnAddComment);
            Controls.Add(textBoxComment);
            Controls.Add(labelCreatedBy);
            Controls.Add(labelCreatedAt);
            Controls.Add(labelDescription);
            Controls.Add(labelForumName);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ForumDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForumDetailsForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label labelForumName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.ListBox listBoxComments;
        private Button deleteButton;
        private Panel panel1;
        private ComboBox filterComboBox;
    }
}