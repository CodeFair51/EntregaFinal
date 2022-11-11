using System;
using System.Drawing;
using System.Windows.Forms;
using ApiResults;

namespace Presentation.IntoFrmHub
{
    public partial class FrmHome : Form
    {
        private readonly ChampionshipQuery objChampQuery = new ChampionshipQuery();

        private PnlChampionship[] pnlChampionship;
        private Label lblWithoutResults;

        public FrmHome()
        {
            InitializeComponent();
            LoadChampionshipPanels();
        }

        private void LoadChampionshipPanels()
        {
            //Cargar los paneles de ligas dependiendo del deporte, solo cargar las ligas que tengan resultados del dia
            try
            {
                Point position;

                objChampQuery.IndexNameNow(FrmHub.Deport);

                if (objChampQuery.ErrorMessageDB == null)
                {
                    if (objChampQuery.ErrorMessage == null)
                    {
                        if (objChampQuery.DtResults.Rows.Count > 0)
                        {
                            position = new Point(40, 20);

                            pnlChampionship = new PnlChampionship[objChampQuery.DtResults.Rows.Count];

                            for (int i = 0; i < pnlChampionship.Length; i++)
                            {
                                pnlChampionship[i] = new PnlChampionship(objChampQuery.DtResults.Rows[i]["nomCampeonato"].ToString());

                                switch (pnlChampionship.Length)
                                {
                                    case 1:
                                        pnlChampionship[0].Location = new Point(377, 20);
                                        break;
                                    case 2:
                                        pnlChampionship[0].Location = new Point(135 ,20);
                                        pnlChampionship[1].Location = new Point(617 ,20);
                                        break;
                                    case 3:
                                        pnlChampionship[0].Location = new Point(15 ,20);
                                        pnlChampionship[1].Location = new Point(377 ,20);
                                        pnlChampionship[2].Location = new Point(739 ,20);
                                        break;
                                    default:
                                        pnlChampionship[i].Location = position;
                                        position.X += 365;
                                        break;
                                }
                                pnlDisplay.Controls.Add(pnlChampionship[i]);
                                pnlChampionship[i].LoadMatchPanels();
                            }
                        }
                        else
                        {
                            //Hacer que el label aparezca siempre en el medio del panel

                            lblWithoutResults = new Label()
                            {
                                Text = "No hay resultados\nen este momento",
                                Font = new Font("Microsoft Sans Serif", 26F),
                                AutoSize = true,
                                Location = new Point(402, 201),
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            pnlDisplay.Controls.Add(lblWithoutResults);
                        }
                    }
                    else
                    {
                        MessageBox.Show(objChampQuery.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(objChampQuery.ErrorMessageDB, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

