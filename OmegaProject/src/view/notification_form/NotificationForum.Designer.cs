namespace SearchNow.src.view.notification_form
{
    partial class NotificationForum
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
            labelNotification = new Label();
            radioFromNewest = new RadioButton();
            radioFromOldest = new RadioButton();
            notificationGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)notificationGrid).BeginInit();
            SuspendLayout();
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNotification.ForeColor = Color.RoyalBlue;
            labelNotification.Location = new Point(12, 22);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(111, 25);
            labelNotification.TabIndex = 0;
            labelNotification.Text = "Notification";
            // 
            // radioFromNewest
            // 
            radioFromNewest.AutoSize = true;
            radioFromNewest.Cursor = Cursors.Hand;
            radioFromNewest.FlatStyle = FlatStyle.Flat;
            radioFromNewest.ForeColor = Color.RoyalBlue;
            radioFromNewest.Location = new Point(363, 13);
            radioFromNewest.Name = "radioFromNewest";
            radioFromNewest.Size = new Size(65, 21);
            radioFromNewest.TabIndex = 1;
            radioFromNewest.TabStop = true;
            radioFromNewest.Text = "newest";
            radioFromNewest.UseVisualStyleBackColor = true;
            // 
            // radioFromOldest
            // 
            radioFromOldest.AutoSize = true;
            radioFromOldest.Cursor = Cursors.Hand;
            radioFromOldest.FlatStyle = FlatStyle.Flat;
            radioFromOldest.ForeColor = Color.RoyalBlue;
            radioFromOldest.Location = new Point(363, 40);
            radioFromOldest.Name = "radioFromOldest";
            radioFromOldest.Size = new Size(61, 21);
            radioFromOldest.TabIndex = 2;
            radioFromOldest.TabStop = true;
            radioFromOldest.Text = "oldest";
            radioFromOldest.UseVisualStyleBackColor = true;
            // 
            // notificationGrid
            // 
            notificationGrid.BackgroundColor = Color.White;
            notificationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notificationGrid.GridColor = Color.LightGray;
            notificationGrid.Location = new Point(12, 72);
            notificationGrid.Name = "notificationGrid";
            notificationGrid.Size = new Size(416, 236);
            notificationGrid.TabIndex = 3;
            // 
            // NotificationForum
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 320);
            Controls.Add(notificationGrid);
            Controls.Add(radioFromOldest);
            Controls.Add(radioFromNewest);
            Controls.Add(labelNotification);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NotificationForum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notification";
            ((System.ComponentModel.ISupportInitialize)notificationGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNotification;
        private RadioButton radioFromNewest;
        private RadioButton radioFromOldest;
        private DataGridView notificationGrid;
    }
}