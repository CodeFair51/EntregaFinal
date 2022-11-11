using System.Windows.Forms;
using Logic;
using Entities;
using System;
using System.Drawing;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmTeamMan : Form
    {
        private Team objTeam = null;
        private readonly TeamLogic objTeamLogic = new TeamLogic();

        public FrmTeamMan()
        {
            InitializeComponent();
            LoadIndex();
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex()
        {
            objTeam = new Team();

            objTeamLogic.Index(ref objTeam);

            if (objTeam.ErrorMessage == null)
            {
                dgvIndex.DataSource = objTeam.DtResults;
            }
            else
            {
                MessageBox.Show(objTeam.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            try
            {
                objTeam = new Team()
                {
                    TeamName = txtTeamName.Text,
                    Country = txtCountry.Text
                };

                objTeamLogic.Create(ref objTeam);

                if (objTeam.ErrorMessage != null)
                {
                    MessageBox.Show(objTeam.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                objTeam = new Team()
                {
                    TeamName = txtUpdate.Text,
                    NewTeamName = txtTeamName.Text,
                    Country = txtCountry.Text
                };

                objTeamLogic.Update(ref objTeam);

                if (objTeam.ErrorMessage != null)
                {
                    MessageBox.Show(objTeam.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objTeam = new Team()
                {
                    TeamName = txtDelete.Text
                };

                objTeamLogic.Delete(ref objTeam);

                if (objTeam.ErrorMessage == null)
                {
                    txtDelete_Leave(null, null);
                    txtUpdate_Leave(null, null);
                }
                else
                {
                    MessageBox.Show(objTeam.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex();
        }

        private void dgvIndex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    objTeam = new Team()
                    {
                        TeamName = dgvIndex.Rows[e.RowIndex].Cells["nomEquipo"].Value.ToString()
                    };

                    objTeamLogic.Read(ref objTeam);

                    if (objTeam.ErrorMessage == null)
                    {
                        txtTeamName.Text = objTeam.TeamName;
                        txtCountry.Text = objTeam.Country;

                        if (e.RowIndex == dgvIndex.RowCount - 1)
                        {
                            txtUpdate_Leave(null, null);
                            txtDelete_Leave(null, null);
                        }
                        else
                        {
                            txtUpdate_Enter(null, null);
                            txtDelete_Enter(null, null);
                            txtUpdate.Text = objTeam.TeamName;
                            txtDelete.Text = objTeam.TeamName;
                        }
                    }
                    else
                    {
                        MessageBox.Show(objTeam.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtUpdate.Text = "Nombre del equipo";
            txtUpdate.ForeColor = Color.Gray;
        }

        private void txtDelete_Enter(object sender, EventArgs e)
        {
            txtDelete.Text = string.Empty;
            txtDelete.ForeColor = Color.Black;
        }

        private void txtDelete_Leave(object sender, EventArgs e)
        {
            txtDelete.Text = "Nombre del equipo";
            txtDelete.ForeColor = Color.Gray;
        }
    }
}
