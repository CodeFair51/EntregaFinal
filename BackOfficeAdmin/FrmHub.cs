using BackOfficeAdmin.ManagementFrames;
using System.Windows.Forms;

namespace BackOfficeAdmin
{
    public partial class FrmHub : Form
    {
        private static PnlDisplay pnlDisplay;

        public static PnlDisplay PnlDisplay { get => pnlDisplay; set => pnlDisplay = value; }

        public FrmHub()
        {
            InitializeComponent();
            MyInitializeComponent();
            btnAdminMan_Click(null, null);
        }

        private void MyInitializeComponent()
        {
            PnlDisplay = new PnlDisplay();
            this.Controls.Add(PnlDisplay);
        }

        private void btnAdminMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmAdminMan", false).Length == 0)
            {
                FrmAdminMan a = new FrmAdminMan();
                FrmMain.OpenFrame(a, PnlDisplay);
            }
        }

        private void btnUserMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmClientMan", false).Length == 0)
            {
                FrmClientMan u = new FrmClientMan();
                FrmMain.OpenFrame(u, PnlDisplay);
            }
        }

        private void btnBannerMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmBannerMan", false).Length == 0)
            {
                FrmBannerMan b = new FrmBannerMan();
                FrmMain.OpenFrame(b, PnlDisplay);
            }
        }

        private void btnChampionshipMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmChampionshipMan", false).Length == 0)
            {
                FrmChampionshipMan c = new FrmChampionshipMan();
                FrmMain.OpenFrame(c, PnlDisplay);
            }
        }

        private void btnTeamMatchMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmTeamMatchMan", false).Length == 0)
            {
                FrmTeamMatchMan tm = new FrmTeamMatchMan();
                FrmMain.OpenFrame(tm, PnlDisplay);
            }
        }

        private void btnSingleMatchMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmSingleMatchMan", false).Length == 0)
            {
                FrmSingleMatchMan sm = new FrmSingleMatchMan();
                FrmMain.OpenFrame(sm, PnlDisplay);
            }
        }

        private void btnTeamMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmTeamMan", false).Length == 0)
            {
                FrmTeamMan t = new FrmTeamMan();
                FrmMain.OpenFrame(t, PnlDisplay);
            }
        }

        private void btnMatchChampionshipMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmMatchChampionshipMan", false).Length == 0)
            {
                FrmMatchChampionshipMan mc = new FrmMatchChampionshipMan();
                FrmMain.OpenFrame(mc, PnlDisplay);
            }
        }

        private void btnTeamPlayerMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmTeamPlayerMan", false).Length == 0)
            {
                FrmTeamPlayerMan tp = new FrmTeamPlayerMan();
                FrmMain.OpenFrame(tp, PnlDisplay);
            }
        }

        private void btnSinglePlayerMan_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmSinglePlayerMan", false).Length == 0)
            {
                FrmSinglePlayerMan sp = new FrmSinglePlayerMan();
                FrmMain.OpenFrame(sp, PnlDisplay);
            }
        }
    }
}
