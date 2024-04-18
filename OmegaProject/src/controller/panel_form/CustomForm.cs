namespace SearchNow.src.model.panel_form
{
    public class CustomForm : Form
    {

        public CustomForm()
        {
            InitializeComponent();
            FormClosing += CustomForm_FormClosing;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CustomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Opravdu chcete ukončit aplikaci?", "Potvrzeni", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
