using System;
using System.Windows.Forms;
using ApiAuthentication;

namespace Presentation.FrmsInit
{
    public partial class FrmRegister : Form
    {
        private Register objRegister = null;

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != string.Empty && txtEmail.Text != string.Empty && txtPass.Text != string.Empty && txtName.Text != string.Empty && txtLastName.Text != string.Empty && txtCountry.Text != string.Empty)
            {
                objRegister = new Register();

                objRegister.doRegister(txtUserName.Text, txtEmail.Text, txtPass.Text, txtName.Text, txtLastName.Text, txtCountry.Text);

                if (objRegister.ErrorMessage == null)
                {
                    if (objRegister.ErrorMessageDB == null)
                    {
                        MessageBox.Show("Se ha registrado correctamente!", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBack_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show(objRegister.ErrorMessageDB, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(objRegister.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmLogin l = new FrmLogin();
            FrmMain.openFrame(l, FrmMain.PnlContainer);
        }
    }
}
