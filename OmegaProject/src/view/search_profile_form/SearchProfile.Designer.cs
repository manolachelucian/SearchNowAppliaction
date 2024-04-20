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
            listOfUsers = new ListBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(153, 5);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 0;
            label1.Text = "Profiles";
            // 
            // listOfUsers
            // 
            listOfUsers.Cursor = Cursors.Hand;
            listOfUsers.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listOfUsers.ForeColor = Color.Gray;
            listOfUsers.FormattingEnabled = true;
            listOfUsers.ItemHeight = 21;
            listOfUsers.Location = new Point(3, 53);
            listOfUsers.Name = "listOfUsers";
            listOfUsers.Size = new Size(454, 361);
            listOfUsers.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(listOfUsers);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 428);
            panel1.TabIndex = 2;
            // 
            // SearchProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(panel1);
            Cursor = Cursors.Default;
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchProfile";
            Text = "SearchProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox listOfUsers;
        private Panel panel1;
    }
}