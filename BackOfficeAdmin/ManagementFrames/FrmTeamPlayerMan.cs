using System;
using System.Drawing;
using System.Windows.Forms;
using Logic;
using Entities;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmTeamPlayerMan : Form
    {
        private Player objPlayer = null;
        private TeamPlayer objTeamPlayer = null;
        private readonly TeamPlayerLogic objTeamPlayerLogic = new TeamPlayerLogic();

        public FrmTeamPlayerMan()
        {
            InitializeComponent();
            LoadIndex();
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex()
        {
            objPlayer = new Player();

            objTeamPlayerLogic.Index(ref objPlayer, "equipo");

            if (objPlayer.ErrorMessage == null)
            {
                dgvIndex.DataSource = objPlayer.DtResults;
            }
            else
            {
                MessageBox.Show(objPlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                objTeamPlayer = new TeamPlayer()
                {
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Nationality = txtNationality.Text,
                    Score = Convert.ToInt32(txtScore.Text)
                };

                objTeamPlayerLogic.Create(ref objTeamPlayer);

                if (objTeamPlayer.ErrorMessage != null)
                {
                    MessageBox.Show(objTeamPlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objTeamPlayer = new TeamPlayer()
                {
                    PlayerID = Convert.ToInt32(txtUpdate.Text),
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Nationality = txtNationality.Text,
                    Score = Convert.ToInt32(txtScore.Text)
                };

                objTeamPlayerLogic.Update(ref objTeamPlayer);

                if (objTeamPlayer.ErrorMessage != null)
                {
                    MessageBox.Show(objTeamPlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objPlayer = new Player()
                {
                    PlayerID = Convert.ToInt32(txtDelete.Text)
                };

                objTeamPlayerLogic.Delete(ref objPlayer, "equipo");

                if (objPlayer.ErrorMessage == null)
                {
                    txtDelete_Leave(null, null);
                    txtUpdate_Leave(null, null);
                }
                else
                {
                    MessageBox.Show(objPlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    objTeamPlayer = new TeamPlayer()
                    {
                        PlayerID = Convert.ToInt32(dgvIndex.Rows[e.RowIndex].Cells["idJugadorEq"].Value.ToString())
                    };

                    objTeamPlayerLogic.Read(ref objTeamPlayer, "equipo");

                    if (objTeamPlayer.ErrorMessage == null)
                    {
                        txtName.Text = objTeamPlayer.Name;
                        txtLastName.Text = objTeamPlayer.LastName;
                        txtNationality.Text = objTeamPlayer.Nationality;
                        txtScore.Text = objTeamPlayer.Score.ToString();

                        if (e.RowIndex == dgvIndex.RowCount - 1)
                        {
                            txtUpdate_Leave(null, null);
                            txtDelete_Leave(null, null);
                        }
                        else
                        {
                            txtUpdate_Enter(null, null);
                            txtDelete_Enter(null, null);
                            txtUpdate.Text = objTeamPlayer.PlayerID.ToString();
                            txtDelete.Text = objTeamPlayer.PlayerID.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show(objTeamPlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtUpdate.Text = "ID jugador";
            txtUpdate.ForeColor = Color.Gray;
        }

        private void txtDelete_Enter(object sender, EventArgs e)
        {
            txtDelete.Text = string.Empty;
            txtDelete.ForeColor = Color.Black;
        }

        private void txtDelete_Leave(object sender, EventArgs e)
        {
            txtDelete.Text = "ID jugador";
            txtDelete.ForeColor = Color.Gray;
        }
    }
}
