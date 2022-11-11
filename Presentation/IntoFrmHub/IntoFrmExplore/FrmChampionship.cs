using System.Windows.Forms;

namespace Presentation.IntoFrmHub
{
    public partial class FrmChampionship : Form
    {
        private string _championshipName;

        public FrmChampionship(string championshipName)
        {
            InitializeComponent();
            ChampionshipName = championshipName;
            lblChampionshipName.Text = ChampionshipName;
            btnMatchs_Click(null, null);
        }

        public string ChampionshipName { get => _championshipName; set => _championshipName = value; }

        private void btnMatchs_Click(object sender, System.EventArgs e)
        {
            FrmMatchs m = new FrmMatchs(ChampionshipName);
            FrmHub.OpenFrame(m, pnlDisplay);
        }

        private void btnPositions_Click(object sender, System.EventArgs e)
        {
            FrmPositions p = new FrmPositions();
            FrmHub.OpenFrame(p, pnlDisplay);
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            FrmExplore fe = new FrmExplore();
            FrmHub.OpenFrame(fe, FrmHub.PnlDisplay);
        }
    }
}
