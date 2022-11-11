using System.Windows.Forms;

namespace BackOfficeAdmin
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
            FrmLogin l = new FrmLogin();
            OpenFrame(l, pnlContainer);
        }

        public static Panel PnlContainer
        {
            get => pnlContainer; set => pnlContainer = value;
        }

        public static void OpenFrame(Form f, Panel p)
        {
            if (p.Controls.Count > 0)
            {
                p.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.Show();
            p.Controls.Add(f);
            p.Tag = f;
        }
    }
}
