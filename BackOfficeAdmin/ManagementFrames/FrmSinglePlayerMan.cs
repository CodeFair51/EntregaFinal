using System;
using System.Drawing;
using System.Windows.Forms;
using Logic;
using Entities;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmSinglePlayerMan : Form
    {
        private Player objPlayer = null;
        private SinglePlayer objSinglePlayer = null;
        private readonly SinglePlayerLogic objSinglePlayerLogic = new SinglePlayerLogic();

        public FrmSinglePlayerMan()
        {
            InitializeComponent();
            LoadIndex();
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex()
        {
            objPlayer = new Player();

            objSinglePlayerLogic.Index(ref objPlayer, "individual");

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
                objSinglePlayer = new SinglePlayer()
                {
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Nationality = txtNationality.Text,
                    Ranking = Convert.ToInt32(txtRanking.Text)
                };

                objSinglePlayerLogic.Create(ref objSinglePlayer);

                if (objSinglePlayer.ErrorMessage != null)
                {
                    MessageBox.Show(objSinglePlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objSinglePlayer = new SinglePlayer()
                {
                    PlayerID = Convert.ToInt32(txtUpdate.Text),
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Nationality = txtNationality.Text,
                    Ranking = Convert.ToInt32(txtRanking.Text)
                };

                objSinglePlayerLogic.Update(ref objSinglePlayer);

                if (objSinglePlayer.ErrorMessage != null)
                {
                    MessageBox.Show(objSinglePlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                objSinglePlayerLogic.Delete(ref objPlayer, "individual");

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
                    objSinglePlayer = new SinglePlayer()
                    {
                        PlayerID = Convert.ToInt32(dgvIndex.Rows[e.RowIndex].Cells["idJugadorInd"].Value.ToString())
                    };

                    objSinglePlayerLogic.Read(ref objSinglePlayer, "individual");

                    if (objSinglePlayer.ErrorMessage == null)
                    {
                        txtName.Text = objSinglePlayer.Name;
                        txtLastName.Text = objSinglePlayer.LastName;
                        txtNationality.Text = objSinglePlayer.Nationality;
                        txtRanking.Text = objSinglePlayer.Ranking.ToString();

                        if (e.RowIndex == dgvIndex.RowCount - 1)
                        {
                            txtUpdate_Leave(null, null);
                            txtDelete_Leave(null, null);
                        }
                        else
                        {
                            txtUpdate_Enter(null, null);
                            txtDelete_Enter(null, null);
                            txtUpdate.Text = objSinglePlayer.PlayerID.ToString();
                            txtDelete.Text = objSinglePlayer.PlayerID.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show(objSinglePlayer.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
