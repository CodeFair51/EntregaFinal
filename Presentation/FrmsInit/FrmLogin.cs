using System.Windows.Forms;
using ApiAuthentication;
using Presentation.IntoFrmHub;

namespace Presentation.FrmsInit
{
    public partial class FrmLogin : Form
    {
        private readonly Login objLogin = new Login();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (txtUserName.Text != string.Empty && txtPass.Text != string.Empty)
            {
                bool enter = objLogin.doAuthentication(txtUserName.Text, txtPass.Text);

                if (enter)
                {
                    this.Dispose();
                    FrmSelectDeport s = new FrmSelectDeport();
                    FrmMain.openFrame(s, FrmMain.PnlContainer);
                }
                else
                {
                    if (objLogin.ErrorMessage != null)
                    {
                        MessageBox.Show(objLogin.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(objLogin.ErrorMessageDB, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
            FrmRegister r = new FrmRegister();
            FrmMain.openFrame(r, FrmMain.PnlContainer);
        }
    }
}
