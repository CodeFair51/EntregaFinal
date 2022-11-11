using System;
using System.Windows.Forms;
using Logic;
using Entities;
using System.Drawing;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmSingleMatchMan : Form
    {
        private Match objMatch = null;
        private SingleMatch objSingleMatch = null;
        private readonly SingleMatchLogic objSingleMatchLogic = new SingleMatchLogic();

        public FrmSingleMatchMan()
        {
            InitializeComponent();
            LoadIndex();
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex()
        {
            objMatch = new Match();

            objSingleMatchLogic.Index(ref objMatch, "individual");

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
                objSingleMatch = new SingleMatch()
                {
                    Stadium = txtStadium.Text,
                    Date = txtDate.Text,
                    Time = txtTime.Text,
                    DeportName = txtDeport.Text,
                    IdHomePlayer = Convert.ToInt32(txtHomePlayer.Text),
                    IdVisitingPlayer = Convert.ToInt32(txtVisitingPlayer.Text)
                };

                objSingleMatchLogic.Create(ref objSingleMatch);

                if (objSingleMatch.ErrorMessage != null)
                {
                    MessageBox.Show(objSingleMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objSingleMatch = new SingleMatch()
                {
                    IdMatch = Convert.ToInt32(txtUpdate.Text),
                    Stadium = txtStadium.Text,
                    Date = txtDate.Text,
                    Time = txtTime.Text,
                    IdHomePlayer = Convert.ToInt32(txtHomePlayer.Text),
                    IdVisitingPlayer = Convert.ToInt32(txtVisitingPlayer.Text)
                };

                objSingleMatchLogic.Update(ref objSingleMatch);

                if (objSingleMatch.ErrorMessage != null)
                {
                    MessageBox.Show(objSingleMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                objSingleMatchLogic.Delete(ref objMatch);

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
                    objSingleMatch = new SingleMatch()
                    {
                        IdMatch = Convert.ToInt32(dgvIndex.Rows[e.RowIndex].Cells["idPartido"].Value.ToString())
                    };

                    objSingleMatchLogic.Read(ref objSingleMatch);

                    if (objSingleMatch.ErrorMessage == null)
                    {
                        txtHomePlayer.Text = objSingleMatch.IdHomePlayer.ToString();
                        txtVisitingPlayer.Text = objSingleMatch.IdVisitingPlayer.ToString();
                        txtDeport.Text = objSingleMatch.DeportName;
                        txtStadium.Text = objSingleMatch.Stadium;
                        txtDate.Text = objSingleMatch.Date;
                        txtTime.Text = objSingleMatch.Time;

                        if (e.RowIndex == dgvIndex.RowCount - 1)
                        {
                            txtUpdate_Leave(null, null);
                            txtDelete_Leave(null, null);
                        }
                        else
                        {
                            txtUpdate_Enter(null, null);
                            txtDelete_Enter(null, null);
                            txtUpdate.Text = objSingleMatch.IdMatch.ToString();
                            txtDelete.Text = objSingleMatch.IdMatch.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show(objSingleMatch.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
