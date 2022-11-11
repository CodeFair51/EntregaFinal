using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ApiResults;

namespace Presentation.IntoFrmHub
{
    public partial class FrmExplore : Form
    {
        private Button[] btnChampionship;

        public FrmExplore()
        {
            InitializeComponent();
            LoadChampionship();
        }

        private void LoadChampionship()
        {
            ChampionshipQuery objChampQuery = new ChampionshipQuery();
            Point position = new Point(0, 0);

            switch (FrmHub.Deport)
            {
                case "Soccer":
                    objChampQuery.IndexName("Soccer");
                    break;
                case "Basketball":
                    objChampQuery.IndexName("Basketball");
                    break;
                case "Tennis":
                    objChampQuery.IndexName("Tennis");
                    break;
                case "Volleyball":
                    objChampQuery.IndexName("Volleyball");
                    break;
                case "Handball":
                    objChampQuery.IndexName("Handball");
                    break;
            }

            if (objChampQuery.ErrorMessageDB == null)
            {
                if (objChampQuery.ErrorMessage == null)
                {
                    btnChampionship = new Button[objChampQuery.DtResults.Rows.Count];

                    int i = 0;
                    foreach (DataRow var in objChampQuery.DtResults.Rows)
                    {
                        btnChampionship[i] = new Button()
                        {
                            Name = var["nomCampeonato"].ToString(),
                            Text = var["nomCampeonato"].ToString(),
                            Font = new Font("Microsoft Sans Serif", 16F),
                            Size = new System.Drawing.Size(350, 50),
                            Location = position
                        };
                        position.Y += 50;
                        btnChampionship[i].Click += new EventHandler(btnChampionship_Click);
                        this.pnlChampionship.Controls.Add(btnChampionship[i]);
                        i++;
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

            //Añadir los campeonatos y si no caben en la plantilla usar vScrollBar

        }

        private void btnChampionship_Click(object sender, EventArgs e)
        {
            Button btnChampionship = sender as Button;

            FrmChampionship c = new FrmChampionship(btnChampionship.Name);
            FrmHub.OpenFrame(c, FrmHub.PnlDisplay);
        }
    }
}
