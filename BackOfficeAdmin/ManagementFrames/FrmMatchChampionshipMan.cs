using System.Windows.Forms;
using Logic;
using Entities;
using System;
using System.Drawing;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmMatchChampionshipMan : Form
    {
        private Match_Championship objMatch_Champ = null;
        private readonly Match_ChampionshipLogic objMatch_ChampLogic = new Match_ChampionshipLogic();

        public FrmMatchChampionshipMan()
        {
            InitializeComponent();
            LoadIndex();
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex()
        {
            objMatch_Champ = new Match_Championship();

            objMatch_ChampLogic.Index(ref objMatch_Champ);

            if (objMatch_Champ.ErrorMessage == null)
            {
                dgvIndex.DataSource = objMatch_Champ.DtResults;
            }
            else
            {
                MessageBox.Show(objMatch_Champ.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            try
            {
                objMatch_Champ = new Match_Championship()
                {
                    IdMatch = Convert.ToInt32(txtIdMatch.Text),
                    ChampionshipName = txtChampionship.Text,
                    DateNumber = Convert.ToByte(txtDateNumber.Text)
                };

                objMatch_ChampLogic.Create(ref objMatch_Champ);

                if (objMatch_Champ.ErrorMessage != null)
                {
                    MessageBox.Show(objMatch_Champ.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objMatch_Champ = new Match_Championship()
                {
                    IdMatch = Convert.ToInt32(txtUpdate.Text),
                    ChampionshipName = txtChampionship.Text,
                    DateNumber = Convert.ToByte(txtDateNumber.Text)
                };

                objMatch_ChampLogic.Update(ref objMatch_Champ);

                if (objMatch_Champ.ErrorMessage != null)
                {
                    MessageBox.Show(objMatch_Champ.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                objMatch_Champ = new Match_Championship()
                {
                    IdMatch = Convert.ToInt32(txtDelete.Text)
                };

                objMatch_ChampLogic.Delete(ref objMatch_Champ);

                if (objMatch_Champ.ErrorMessage == null)
                {
                    txtUpdate_Leave(null, null);
                    txtDelete_Leave(null, null);
                }
                else
                {
                    MessageBox.Show(objMatch_Champ.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    objMatch_Champ = new Match_Championship()
                    {
                        IdMatch = Convert.ToInt32(dgvIndex.Rows[e.RowIndex].Cells["idPartido"].Value.ToString())
                    };

                    objMatch_ChampLogic.Read(ref objMatch_Champ);

                    if (objMatch_Champ.ErrorMessage == null)
                    {
                        txtIdMatch.Text = objMatch_Champ.IdMatch.ToString();
                        txtChampionship.Text = objMatch_Champ.ChampionshipName;
                        txtDateNumber.Text = objMatch_Champ.DateNumber.ToString();

                        if (e.RowIndex == dgvIndex.Rows.Count - 1)
                        {
                            txtUpdate_Leave(null, null);
                            txtDelete_Leave(null, null);
                        }
                        else
                        {
                            txtUpdate_Enter(null, null);
                            txtDelete_Enter(null, null);
                            txtUpdate.Text = objMatch_Champ.IdMatch.ToString();
                            txtDelete.Text = objMatch_Champ.IdMatch.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show(objMatch_Champ.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
