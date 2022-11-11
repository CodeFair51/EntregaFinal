using System;
using Logic;
using Entities;
using System.Windows.Forms;
using System.Drawing;

namespace BackOfficeAdmin.ManagementFrames
{
    public partial class FrmChampionshipMan : Form
    {
        private Championship objChamp = null;
        private ChampionshipLogic objChampLogic = new ChampionshipLogic();

        public FrmChampionshipMan()
        {
            InitializeComponent();
            LoadIndex(0);
            txtUpdate_Leave(null, null);
            txtDelete_Leave(null, null);
        }

        private void LoadIndex(int indexModality)
        {
            string modality = null;

            switch (indexModality)
            {
                case 1:
                    modality = "gruposEliminatorias";
                    break;
                default:
                    break;
            }

            objChamp = new Championship()
            {
                Modality = modality
            };

            objChampLogic.Index(ref objChamp);

            if (objChamp.ErrorMessage == null)
            {
                dgvIndex.DataSource = objChamp.DtResults;
            }
            else
            {
                MessageBox.Show(objChamp.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                objChamp = new Championship()
                {
                    ChampionshipName = txtChampionshipName.Text,
                    QuantityDates = Convert.ToByte(txtQuantityDates.Text),
                    Region = txtRegion.Text,
                    DeportName = txtDeportName.Text
                };

                switch (cmbModality.SelectedIndex)
                {
                    case 0:
                        objChamp.Modality = "liga";
                        break;
                    case 1:
                        objChamp.Modality = "gruposEliminatorias";

                        if (chkFirstAndSecondLeg.Checked)
                        {
                            objChamp.FirstAndSecondGroupLeg = 1;
                        }
                        else
                        {
                            objChamp.FirstAndSecondGroupLeg = 0;
                        }
                        break;
                }

                objChampLogic.Create(ref objChamp);

                if (objChamp.ErrorMessage != null)
                {
                    MessageBox.Show(objChamp.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex(cmbAtributesModality.SelectedIndex);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                objChamp = new Championship()
                {
                    ChampionshipName = txtUpdate.Text,
                    NewChampionshipName = txtChampionshipName.Text,
                    QuantityDates = Convert.ToByte(txtQuantityDates.Text),
                    Region = txtRegion.Text,
                    DeportName = txtDeportName.Text
                };

                switch (cmbModality.SelectedIndex)
                {
                    case 0:
                        objChamp.Modality = "liga";
                        break;
                    case 1:
                        objChamp.Modality = "gruposEliminatorias";

                        if (chkFirstAndSecondLeg.Checked)
                        {
                            objChamp.FirstAndSecondGroupLeg = 1;
                        }
                        else
                        {
                            objChamp.FirstAndSecondGroupLeg = 0;
                        }
                        break;
                }

                objChampLogic.Update(ref objChamp);

                if (objChamp.ErrorMessage != null)
                {
                    MessageBox.Show(objChamp.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex(cmbAtributesModality.SelectedIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                objChamp = new Championship()
                {
                    ChampionshipName = txtChampionshipName.Text
                };

                objChampLogic.Delete(ref objChamp);

                if (objChamp.ErrorMessage == null)
                {
                    txtDelete_Leave(null, null);
                    txtUpdate_Leave(null, null);
                }
                else
                {
                    MessageBox.Show(objChamp.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadIndex(cmbAtributesModality.SelectedIndex);
        }

        private void dgvIndex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    objChamp = new Championship()
                    {
                        ChampionshipName = dgvIndex.Rows[e.RowIndex].Cells["nomCampeonato"].Value.ToString()
                    };

                    objChampLogic.Read(ref objChamp);

                    if (objChamp.ErrorMessage == null)
                    {
                        txtChampionshipName.Text = objChamp.ChampionshipName;
                        txtRegion.Text = objChamp.Region;
                        txtQuantityDates.Text = objChamp.QuantityDates.ToString();
                        txtDeportName.Text = objChamp.DeportName;

                        chkFirstAndSecondLeg.Hide();
                        switch (objChamp.Modality)
                        {
                            case "liga":
                                cmbModality.SelectedIndex = 0;
                                break;
                            case "gruposEliminatorias":
                                cmbModality.SelectedIndex = 1;

                                chkFirstAndSecondLeg.Show();
                                if (objChamp.FirstAndSecondGroupLeg == 1)
                                {
                                    chkFirstAndSecondLeg.Checked = true;
                                }
                                else
                                {
                                    chkFirstAndSecondLeg.Checked = false;
                                }
                                break;
                        }

                        if (e.RowIndex == dgvIndex.RowCount - 1)
                        {
                            txtUpdate_Leave(null, null);
                            txtDelete_Leave(null, null);
                        }
                        else
                        {
                            txtUpdate_Enter(null, null);
                            txtDelete_Enter(null, null);
                            txtUpdate.Text = objChamp.ChampionshipName;
                            txtDelete.Text = objChamp.ChampionshipName;
                        }
                    }
                    else
                    {
                        MessageBox.Show(objChamp.ErrorMessage, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbModality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModality.SelectedIndex == 1)
            {
                chkFirstAndSecondLeg.Show();
            }
            else
            {
                chkFirstAndSecondLeg.Hide();
            }
        }

        private void cmbAtributesModality_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIndex(cmbAtributesModality.SelectedIndex);
        }

        private void txtUpdate_Enter(object sender, EventArgs e)
        {
            txtUpdate.Text = string.Empty;
            txtUpdate.ForeColor = Color.Black;
        }

        private void txtUpdate_Leave(object sender, EventArgs e)
        {
            txtUpdate.Text = "Nombre del campeonato";
            txtUpdate.ForeColor = Color.Gray;
        }

        private void txtDelete_Enter(object sender, EventArgs e)
        {
            txtDelete.Text = string.Empty;
            txtDelete.ForeColor = Color.Black;
        }

        private void txtDelete_Leave(object sender, EventArgs e)
        {
            txtDelete.Text = "Nombre del campeonato";
            txtDelete.ForeColor = Color.Gray;
        }
    }
}
