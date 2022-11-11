using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ApiResults;

namespace Presentation.IntoFrmHub
{
    public class PnlChampionship : Panel
    {
        private readonly Match_ChampionshipQuery objMatch_ChampQuery = new Match_ChampionshipQuery();

        private Label lblChampName;
        private PnlMatch[] pnlMatch;

        private string championshipName;

        public PnlChampionship(string championshipName)
        {
            this.championshipName = championshipName;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Show();
            this.Size = new Size(347, 420);
            this.AutoScroll = true;
            this.VerticalScroll.Enabled = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Anchor = ((AnchorStyles) AnchorStyles.Top | AnchorStyles.Bottom);

            lblChampName = new Label()
            {
                Text = championshipName,
                Location = new Point(0, 2),
                Size = new Size(347, 32),
                Font = new Font("Microsoft Sans Serif", 20F),
                Anchor = ((AnchorStyles)AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.Controls.Add(lblChampName);
        }

        public void LoadMatchPanels()
        {
            try
            {
                Point position;

                objMatch_ChampQuery.IndexNow(championshipName);

                if (objMatch_ChampQuery.ErrorMessageDB == null)
                {
                    if (objMatch_ChampQuery.ErrorMessage == null)
                    {
                        position = new Point(0, 45);

                        pnlMatch = new PnlMatch[objMatch_ChampQuery.DtResults.Rows.Count];

                        int i = 0;

                        foreach (DataRow var in objMatch_ChampQuery.DtResults.Rows)
                        {
                            pnlMatch[i] = new PnlMatch();
                            pnlMatch[i].Name = "PnlMatch" + (i + 1);
                            pnlMatch[i].Location = position;
                            position.Y += 82;
                            pnlMatch[i].Click += new EventHandler(pnlMatch_Click);
                            this.Controls.Add(pnlMatch[i]);
                            pnlMatch[i].LblTeam1Score.Text = var["anotacionLocal"].ToString();
                            pnlMatch[i].LblTeam2Score.Text = var["anotacionVisitante"].ToString();
                            pnlMatch[i].LblDate.Text = var["fecha"].ToString();
                            //Hora
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
                                    //Caras
                                    i++;
                                }
                                break;
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

        private void pnlMatch_Click(object sender, EventArgs e)
        {
            PnlMatch pnlSender = sender as PnlMatch;

            FrmResult r = new FrmResult(pnlSender.IdPartido);
            FrmHub.OpenFrame(r, FrmHub.PnlDisplay);
        }
    }
}
