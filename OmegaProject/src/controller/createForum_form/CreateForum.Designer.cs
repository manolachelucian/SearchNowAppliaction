namespace SearchNow.src.createForum_form
{
    partial class CreateForum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForum));
            labelForumName = new Label();
            textBoxForumName = new TextBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            buttonCreateForum = new Button();
            SuspendLayout();
            // 
            // labelForumName
            // 
            labelForumName.AutoSize = true;
            labelForumName.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForumName.ForeColor = Color.RoyalBlue;
            labelForumName.Location = new Point(94, 38);
            labelForumName.Margin = new Padding(4, 0, 4, 0);
            labelForumName.Name = "labelForumName";
            labelForumName.Size = new Size(102, 21);
            labelForumName.TabIndex = 0;
            labelForumName.Text = "Forum Name";
            // 
            // textBoxForumName
            // 
            textBoxForumName.BackColor = Color.White;
            textBoxForumName.Cursor = Cursors.IBeam;
            textBoxForumName.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxForumName.ForeColor = Color.Gray;
            textBoxForumName.Location = new Point(94, 62);
            textBoxForumName.Margin = new Padding(4, 3, 4, 3);
            textBoxForumName.Multiline = true;
            textBoxForumName.Name = "textBoxForumName";
            textBoxForumName.Size = new Size(250, 30);
            textBoxForumName.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.ForeColor = Color.RoyalBlue;
            labelDescription.Location = new Point(94, 104);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(89, 21);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Cursor = Cursors.IBeam;
            textBoxDescription.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescription.ForeColor = Color.Gray;
            textBoxDescription.Location = new Point(94, 128);
            textBoxDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(250, 30);
            textBoxDescription.TabIndex = 3;
            // 
            // buttonCreateForum
            // 
            buttonCreateForum.BackColor = Color.RoyalBlue;
            buttonCreateForum.Cursor = Cursors.Hand;
            buttonCreateForum.FlatAppearance.BorderSize = 0;
            buttonCreateForum.FlatStyle = FlatStyle.Flat;
            buttonCreateForum.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCreateForum.ForeColor = Color.White;
            buttonCreateForum.Location = new Point(94, 214);
            buttonCreateForum.Margin = new Padding(4, 3, 4, 3);
            buttonCreateForum.Name = "buttonCreateForum";
            buttonCreateForum.Size = new Size(250, 50);
            buttonCreateForum.TabIndex = 4;
            buttonCreateForum.Text = "Create Forum";
            buttonCreateForum.UseVisualStyleBackColor = false;
            // 
            // CreateForum
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(426, 309);
            Controls.Add(buttonCreateForum);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(textBoxForumName);
            Controls.Add(labelForumName);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "CreateForum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New Forum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelForumName;
        private System.Windows.Forms.TextBox textBoxForumName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCreateForum;
    }
}