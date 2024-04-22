namespace SearchNow.src.view.panel_form
{
    public class ClosingForm : Form
    {

        /// <summary>
        /// Initializes a new instance of the CustomForm class.
        /// </summary>
        public ClosingForm()
        {
            InitializeComponent();
            FormClosing += CustomForm_FormClosing;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Event handler for the form closing event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void CustomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Initializes the form components.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // CustomForm
            // 
            ClientSize = new Size(284, 261);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }
    }
}

