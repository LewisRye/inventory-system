using System;
using System.Windows.Forms;

namespace NEA
{
    public partial class LoginDisconnectForm : Form
    {
        public LoginDisconnectForm()
        {
            InitializeComponent();
        }

        private void ButtonUnderstand_Click(object Sender, EventArgs E)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Visible = true;
            }
            this.Hide();
            this.Close();
            this.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void LoginDisconnectForm_Load(object Sender, EventArgs E)
        {

        }
    }
}
