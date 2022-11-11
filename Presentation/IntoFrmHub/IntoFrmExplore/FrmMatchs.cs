using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ApiResults;

namespace Presentation.IntoFrmHub
{
    public partial class FrmMatchs : Form
    {
        private ChampionshipQuery objChampQuery = new ChampionshipQuery();
        private Match_ChampionshipQuery objMatch_ChampQuery = new Match_ChampionshipQuery();
        private string _championshipName;

        private Button[] btnDate;
        private PnlMatch[] pnlMatch;
        private Panel pnlDates;
        private Panel pnlDisplayMatchs;
        private Label lblWithoutResults;

        public FrmMatchs(string championshipName)
        {
            InitializeComponent();
            MyInitializeComponent();
            ChampionshipName = championshipName;
            LoadDates();
        }

        public string ChampionshipName { get => _championshipName; set => _championshipName = value; }

        private void MyInitializeComponent()
        {
            pnlDates = new Panel()
            {
                Name = "pnlDates",
                Dock = DockStyle.Top,
                AutoScroll = true,
                Size = new Size(0, 30)
            };
            pnlDates.HorizontalScroll.Enabled = true;
            this.Controls.Add(pnlDates);

            pnlDisplayMatchs = new Panel()
            {
                Name = "pnlDisplayMatchs",
                Size = new Size(960, 479),
                AutoScroll = true,
                Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
                | AnchorStyles.Left) | AnchorStyles.Right)))
            };
            pnlDisplayMatchs.VerticalScroll.Enabled = true;
            pnlDisplayMatchs.HorizontalScroll.Enabled = true;
            this.Controls.Add(pnlDisplayMatchs);

            lblWithoutResults = new Label()
            {
                Text = "No hay resultados\nen este momento",
                Font = new Font("Microsoft Sans Serif", 22F),
                Location = new Point(352, 218),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        private void InitializeBtnsDate(Point position)
        {
            for (int i = 0; i < btnDate.Length; i++)
            {
                btnDate[i] = new Button()
                {
                    Name = (i + 1).ToString(),
                    Font = new Font("Microsoft Sans Serif", 12F),
                    Size = new Size(60, 20),
                    Location = position
                };
                position.X += 60;
                btnDate[i].Click += new System.EventHandler(btnDates_Click);
                pnlDates.Controls.Add(btnDate[i]);
            }
        }

        private void LoadDates()
        {
            objChampQuery.Read(ChampionshipName);

            if (objChampQuery.ErrorMessageDB == null)
            {
                if (objChampQuery.ErrorMessage == null)
                {
                    switch (objChampQuery.Modality)
                    {
                        case "liga":
                            btnDate = new Button[objChampQuery.DatesQuantity];
                            InitializeBtnsDate(new Point(0, 0));
                            for (int i = 0; i < btnDate.Length; i++)
                            {
                                btnDate[i].Text = "Fecha " + (i + 1);
                            }
                            break;
                        case "gruposEliminatorias":
                            Point position = new Point(130, 0);
                            int btnQuantity = 5;
                            int indexButton = 1;

                            if (objChampQuery.FirstAndSecondGroupLeg == 1)
                            {
                                position = new Point(110, 0);
                                btnQuantity = 6;
                                indexButton = 2;
                            }

                            btnDate = new Button[btnQuantity];
                            InitializeBtnsDate(position);
                            
                            btnDate[0].Text = "Fase de grupos\nRonda 1";

                            if (objChampQuery.FirstAndSecondGroupLeg == 1)
                            {
                                btnDate[1].Text = "Fase de grupos\nRonda 2";
                            }

                            btnDate[indexButton].Text = "Octavos de Final";
                            indexButton++;
                            btnDate[indexButton].Text = "Cuartos de Final";
                            indexButton++;
                            btnDate[indexButton].Text = "Semifinal";
                            indexButton++;
                            btnDate[indexButton].Text = "Final";
                            break;
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

        private void LoadMatchs(byte nroFecha)
        {
            //Cargar todos los paneles de partido que coincidan con el campeonato y el numero de fecha elegido
            try
            {
                Point position;
                objMatch_ChampQuery.IndexNroFecha(nroFecha, ChampionshipName);

                if (objMatch_ChampQuery.ErrorMessageDB == null)
                {
                    if (objMatch_ChampQuery.ErrorMessage == null)
                    {
                        pnlDisplayMatchs.Controls.Clear();

                        if (objMatch_ChampQuery.DtResults.Rows.Count > 0)
                        {
                            position = new Point(160, 100);

                            pnlMatch = new PnlMatch[objMatch_ChampQuery.DtResults.Rows.Count];

                            int i = 0;

                            foreach (DataRow var in objMatch_ChampQuery.DtResults.Rows)
                            {
                                pnlMatch[i] = new PnlMatch();
                                pnlMatch[i].Name = "PnlMatch" + (i + 1);
                                pnlMatch[i].Location = position;
                                pnlMatch[i].Click += new EventHandler(pnlMatch_Click);
                                pnlDisplayMatchs.Controls.Add(pnlMatch[i]);
                                pnlMatch[i].LblTeam1Score.Text = var["anotacionLocal"].ToString();
                                pnlMatch[i].LblTeam2Score.Text = var["anotacionVisitante"].ToString();
                                pnlMatch[i].LblDate.Text = var["fecha"].ToString();

                                if ((i + 1) % 4 == 0)
                                {
                                    position.X = 160;
                                    position.Y += 100;
                                }
                                else
                                {
                                    position.X += 365;
                                }
                                i++;
                            }

                            i = 0;

                            switch (FrmHub.Modality)
                            {
                                case "equipo":
                                    foreach (DataRow var in objMatch_ChampQuery.DtResults.Rows)
                                    {
                                        pnlMatch[i].IdPartido = var["idPartidoEq"].ToString();
                                        pnlMatch[i].LblTeam1Name.Text = var["nomEquipoLocal"].ToString();
                                        pnlMatch[i].LblTeam2Name.Text = var["nomEquipoVisitante"].ToString();
                                        //Escudos
                                        i++;
                                    }
                                    break;
                                case "individual":
                                    foreach (DataRow var in objMatch_ChampQuery.DtResults.Rows)
                                    {
                                        pnlMatch[i].IdPartido = var["idPartidoInd"].ToString();
                                        pnlMatch[i].LblTeam1Name.Text = var["idJugadorLocal"].ToString();
                                        pnlMatch[i].LblTeam2Name.Text = var["idJugadorVisitante"].ToString();
                                        //Banderas
                                        i++;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            pnlDisplayMatchs.Controls.Add(lblWithoutResults);
                        }
                    }
                    else
                    {
                        MessageBox.Show(objMatch_ChampQuery.ErrorMessage, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(objMatch_ChampQuery.ErrorMessageDB, "Mensaje de error desde base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDates_Click(object sender, EventArgs e)
        {
            Button btnDate = sender as Button;
            byte nroFecha = Convert.ToByte(btnDate.Name);

            LoadMatchs(nroFecha);
        }

        private void pnlMatch_Click(object sender, EventArgs e)
        {
            PnlMatch p = sender as PnlMatch;

            FrmResult r = new FrmResult(p.IdPartido);
            FrmHub.OpenFrame(r, FrmHub.PnlDisplay);
        }
    }
}
