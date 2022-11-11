using System.Windows.Forms;
using Logic;
using Entities;

namespace BackOfficeAdmin
{
    public partial class FrmLogin : Form
    {
        private User objUser = null;
        private readonly UserLogic objUserLogic = new UserLogic();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (txtUserName.Text != string.Empty && txtPass.Text != string.Empty)
            {
                objUser = new User()
                {
                    UserName = txtUserName.Text
                };

                objUserLogic.Read(ref objUser);

                if (objUser.ErrorMessage == null)
                {

                    if (objUser.DtResults.Rows.Count == 1)
                    {
                        if (objUser.Pass == txtPass.Text)
                        {
                            if (objUser.Type == "admin")
                            {
                                this.Dispose();
                                FrmHub i = new FrmHub();
                                FrmMain.OpenFrame(i, FrmMain.PnlContainer);
                            }
                            else
                            {
                                MessageBox.Show("Necesita permisos de administrador!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario incorrecto!", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(objUser.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
