namespace SearchNow.src.user_forums_form
{
    partial class User_forums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_forums));
            userFormsGrid = new DataGridView();
            deleteButton = new Button();
            label1 = new Label();
            deleteForumButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userFormsGrid).BeginInit();
            SuspendLayout();
            // 
            // userFormsGrid
            // 
            userFormsGrid.BackgroundColor = Color.LightGray;
            userFormsGrid.BorderStyle = BorderStyle.None;
            userFormsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userFormsGrid.Cursor = Cursors.Hand;
            userFormsGrid.Location = new Point(12, 49);
            userFormsGrid.Name = "userFormsGrid";
            userFormsGrid.Size = new Size(560, 400);
            userFormsGrid.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 1;
            label1.Text = "My Forums";
            // 
            // deleteForumButton
            // 
            deleteForumButton.BackColor = Color.Red;
            deleteForumButton.Cursor = Cursors.Hand;
            deleteForumButton.FlatAppearance.BorderSize = 0;
            deleteForumButton.FlatStyle = FlatStyle.Popup;
            deleteForumButton.ForeColor = Color.White;
            deleteForumButton.Location = new Point(475, 9);
            deleteForumButton.Name = "deleteForumButton";
            deleteForumButton.Size = new Size(97, 33);
            deleteForumButton.TabIndex = 2;
            deleteForumButton.Text = "DELETE";
            deleteForumButton.UseVisualStyleBackColor = false;
            // 
            // User_forums
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 461);
            Controls.Add(deleteForumButton);
            Controls.Add(label1);
            Controls.Add(userFormsGrid);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "User_forums";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_forums";
            ((System.ComponentModel.ISupportInitialize)userFormsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView userFormsGrid;
        private Button deleteButton;
        private Label label1;
        private Button deleteForumButton;
    }
}