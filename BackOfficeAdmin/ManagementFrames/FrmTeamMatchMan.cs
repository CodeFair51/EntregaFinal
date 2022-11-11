using System;
using System.Windows.Forms;
using Logic;
using Entities;
using System.Drawing;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmTeamMatchMan : Form
    {
        private Match objMatch = null;
        private TeamMatch objTeamMatch = null;
        private readonly TeamMatchLogic objTeamMatchLogic = new TeamMatchLogic();

        public FrmTeamMatchMan()
        {
            InitializeComponent();
            LoadIndex();
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex()
        {
            objMatch = new Match();

            objTeamMatchLogic.Index(ref objMatch, "equipo");

            if (objMatch.ErrorMessage == null)
            {
                dgvIndex.DataSource = objMatch.DtResults;
            }
            else
            {
                MessageBox.Show(objMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                objTeamMatch = new TeamMatch()
                {
                    Stadium = txtStadium.Text,
                    Date = txtDate.Text,
                    Time = txtTime.Text,
                    DeportName = txtDeport.Text,
                    HomeName = txtHomeTeam.Text,
                    VisitingName = txtVisitingTeam.Text
                };

                objTeamMatchLogic.Create(ref objTeamMatch);

                if (objTeamMatch.ErrorMessage != null)
                {
                    MessageBox.Show(objTeamMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                objTeamMatch = new TeamMatch()
                {
                    IdMatch = Convert.ToInt32(txtUpdate.Text),
                    Stadium = txtStadium.Text,
                    Date = txtDate.Text,
                    Time = txtTime.Text,
                    HomeName = txtHomeTeam.Text,
                    VisitingName = txtVisitingTeam.Text,
                };

                objTeamMatchLogic.Update(ref objTeamMatch);

                if (objTeamMatch.ErrorMessage != null)
                {
                    MessageBox.Show(objTeamMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                objMatch = new Match()
                {
                    IdMatch = Convert.ToInt32(txtDelete.Text)
                };

                objTeamMatchLogic.Delete(ref objMatch);

                if (objMatch.ErrorMessage == null)
                {
                    txtDelete_Leave(null, null);
                    txtUpdate_Leave(null, null);
                }
                else
                {
                    MessageBox.Show(objMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    objTeamMatch = new TeamMatch()
                    {
                        IdMatch = Convert.ToInt32(dgvIndex.Rows[e.RowIndex].Cells["idPartido"].Value.ToString())
                    };

                    objTeamMatchLogic.Read(ref objTeamMatch);

                    if (objTeamMatch.ErrorMessage == null)
                    {
                        txtHomeTeam.Text = objTeamMatch.HomeName;
                        txtVisitingTeam.Text = objTeamMatch.VisitingName;
                        txtDeport.Text = objTeamMatch.DeportName;
                        txtStadium.Text = objTeamMatch.Stadium;
                        txtDate.Text = objTeamMatch.Date;
                        txtTime.Text = objTeamMatch.Time;

                        if (e.RowIndex == dgvIndex.RowCount - 1)
                        {
                            txtUpdate_Leave(null, null);
                            txtDelete_Leave(null, null);
                        }
                        else
                        {
                            txtUpdate_Enter(null, null);
                            txtDelete_Enter(null, null);
                            txtUpdate.Text = objTeamMatch.IdMatch.ToString();
                            txtDelete.Text = objTeamMatch.IdMatch.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show(objTeamMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateResults_Click(object sender, EventArgs e)
        {
            FrmUpdateResults u = new FrmUpdateResults();
            FrmMain.OpenFrame(u, FrmHub.PnlDisplay);
        }

        private void txtUpdate_Enter(object sender, EventArgs e)
        {
            txtUpdate.Text = string.Empty;
            txtUpdate.ForeColor = Color.Black;
        }

        private void txtUpdate_Leave(object sender, EventArgs e)
        {
            txtUpdate.Text = "ID partido";
            txtUpdate.ForeColor = Color.Gray;
        }

        private void txtDelete_Enter(object sender, EventArgs e)
        {
            txtDelete.Text = string.Empty;
            txtDelete.ForeColor = Color.Black;
        }

        private void txtDelete_Leave(object sender, EventArgs e)
        {
            txtDelete.Text = "ID partido";
            txtDelete.ForeColor = Color.Gray;
        }
    }
}
