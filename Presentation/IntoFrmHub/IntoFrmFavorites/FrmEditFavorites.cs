using System.Windows.Forms;

namespace Presentation.IntoFrmHub
{
    public partial class FrmEditFavorites : Form
    {
        private Button[] btnLigue, btnTeam;

        public FrmEditFavorites()
        {
            InitializeComponent();
        }

        private void LoadLigues()
        {
            //Cargar las ligas dependiendo del deporte

            switch (FrmHub.Deport)
            {
                case "Soccer":

                    break;
                case "Basketball":

                    break;
                case "Tennis":

                    break;
                case "Volleyball":

                    break;
                case "Handball":

                    break;
            }
        }

        private void LoadTeams()
        {
            //Cargar los equipos dependiendo de la liga
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            FrmFavorites f = new FrmFavorites();
            FrmHub.OpenFrame(f, FrmHub.PnlDisplay);
        }
    }
}
