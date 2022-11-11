using System.Windows.Forms;

namespace Presentation.IntoFrmHub
{
    public partial class FrmFavorites : Form
    {
        private Button[] btnTeam;

        public FrmFavorites()
        {
            InitializeComponent();
            loadFavoriteTeams();
        }

        private void loadFavoriteTeams()
        {
            //Obtener y cargar los equipos favoritos del usuario en los botones
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            FrmEditFavorites f = new FrmEditFavorites();
            FrmHub.OpenFrame(f, FrmHub.PnlDisplay);
        }
    }
}
