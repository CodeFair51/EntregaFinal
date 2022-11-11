using System;
using System.Windows.Forms;

using Presentation.IntoFrmHub;

namespace Presentation.FrmsInit
{
    public partial class FrmSelectDeport : Form
    {
        public FrmSelectDeport()
        {
            InitializeComponent();
        }

        private void btnSoccer_Click(object sender, EventArgs e)
        {
            FrmHub h = new FrmHub("Soccer", "equipo");
            FrmHub.OpenFrame(h, FrmMain.PnlContainer);
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            FrmHub h = new FrmHub("Basketball", "equipo");
            FrmHub.OpenFrame(h, FrmMain.PnlContainer);
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            FrmHub h = new FrmHub("Tennis", "individual");
            FrmHub.OpenFrame(h, FrmMain.PnlContainer);
        }

        private void btnVolley_Click(object sender, EventArgs e)
        {
            FrmHub h = new FrmHub("Volleyball", "equipo");
            FrmHub.OpenFrame(h, FrmMain.PnlContainer);
        }

        private void btnHandball_Click(object sender, EventArgs e)
        {
            FrmHub h = new FrmHub("Handball", "equipo");
            FrmHub.OpenFrame(h, FrmMain.PnlContainer);
        }
    }
}
