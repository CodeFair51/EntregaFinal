using System.Windows.Forms;
using Logic;
using Entities;
using System.Drawing;
using System;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmClientMan : Form
    {
        private User objUser = null;
        private readonly UserLogic objUserLogic = new UserLogic();

        public FrmClientMan()
        {
            InitializeComponent();
            LoadIndex();
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex()
        {
            objUser = new User()
            {
                Type = "cliente"
            };

            objUserLogic.Index(ref objUser);

            if (objUser.ErrorMessage == null)
            {
                dgvIndex.DataSource = objUser.DtResults;
            }
            else
            {
                MessageBox.Show(objUser.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            try
            {
                objUser = new User()
                {
                    UserName = txtUserName.Text,
                    Email = txtEmail.Text,
                    Pass = txtPass.Text,
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Country = txtCountry.Text,
                    Type = "cliente"
                };

                if (chkSub.Checked)
                {
                    objUser.Payment = 1;
                }
                else
                {
                    objUser.Payment = 0;
                }

                objUserLogic.Create(ref objUser);

                if (objUser.ErrorMessage != null)
                {
                    MessageBox.Show(objUser.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                objUser = new User()
                {
                    UserName = txtUpdate.Text,
                    NewUserName = txtUserName.Text,
                    Email = txtEmail.Text,
                    Pass = txtPass.Text,
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Country = txtCountry.Text,
                    Type = "cliente"
                };

                if (chkSub.Checked)
                {
                    objUser.Payment = 1;
                }
                else
                {
                    objUser.Payment = 0;
                }

                objUserLogic.Update(ref objUser);

                if (objUser.ErrorMessage != null)
                {
                    MessageBox.Show(objUser.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                objUser = new User()
                {
                    UserName = txtDelete.Text
                };

                objUserLogic.Read(ref objUser);

                if (objUser.ErrorMessage == null)
                {
                    if (objUser.Type == "cliente")
                    {
                        objUserLogic.Delete(ref objUser);

                        if (objUser.ErrorMessage == null)
                        {
                            txtDelete_Leave(null, null);
                            txtUpdate_Leave(null, null);
                        }
                        else
                        {
                            MessageBox.Show(objUser.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar: el usuario ingresado es un administrador", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(objUser.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex();
        }

        private void dgvUserIndex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    objUser = new User()
                    {
                        UserName = dgvIndex.Rows[e.RowIndex].Cells["nomUsuario"].Value.ToString()
                    };

                    objUserLogic.Read(ref objUser);

                    if (objUser.ErrorMessage == null)
                    {
                        txtUserName.Text = objUser.UserName;
                        txtEmail.Text = objUser.Email;
                        txtPass.Text = objUser.Pass;
                        txtName.Text = objUser.Name;
                        txtLastName.Text = objUser.LastName;
                        txtCountry.Text = objUser.Country;

                        if (objUser.Payment == 1)
                        {
                            chkSub.Checked = true;
                        }
                        else
                        {
                            chkSub.Checked = false;
                        }

                        if (e.RowIndex == dgvIndex.RowCount - 1)
                        {
                            txtDelete_Leave(null, null);
                            txtUpdate_Leave(null, null);
                        }
                        else
                        {
                            txtDelete_Enter(null, null);
                            txtUpdate_Enter(null, null);
                            txtDelete.Text = objUser.UserName;
                            txtUpdate.Text = objUser.UserName;
                        }
                    }
                    else
                    {
                        MessageBox.Show(objUser.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUpdate_Enter(object sender, EventArgs e)
        {
            txtUpdate.Text = string.Empty;
            txtUpdate.ForeColor = Color.Black;
        }

        private void txtUpdate_Leave(object sender, EventArgs e)
        {
            txtUpdate.Text = "Nombre de usuario";
            txtUpdate.ForeColor = Color.Gray;
        }

        private void txtDelete_Enter(object sender, EventArgs e)
        {
            txtDelete.Text = string.Empty;
            txtDelete.ForeColor = Color.Black;
        }

        private void txtDelete_Leave(object sender, EventArgs e)
        {
            txtDelete.Text = "Nombre de usuario";
            txtDelete.ForeColor = Color.Gray;
        }
    }
}
