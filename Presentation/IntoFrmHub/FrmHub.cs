using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.IntoFrmHub
{
    public partial class FrmHub : Form
    {
        private static string _deport;
        private static string _modality;
        private static PnlDisplay pnlDisplay;

        public static PnlDisplay PnlDisplay { get => pnlDisplay; set => pnlDisplay = value; }
        public static string Deport { get => _deport; set => _deport = value; }
        public static string Modality { get => _modality; set => _modality = value; }

        public FrmHub(string deport, string modality)
        {
            Deport = deport;
            Modality = modality;

            InitializeComponent();
            MyInitializeComponent();
            btnHome_Click(null, null);
        }

        private void MyInitializeComponent()
        {
            PnlDisplay = new PnlDisplay();
            this.Controls.Add(PnlDisplay);

            SelectDeport();
        }

        private void SelectDeport()
        {
            Point position1 = new Point(0, 0);
            Point position2 = new Point(0, 33);
            Point position3 = new Point(0, 66);
            Point position4 = new Point(0, 99);
            Point position5 = new Point(0, 132);

            switch (Deport)
            {
                case "Soccer":
                    this.btnSoccer.Location = position1;
                    this.btnBasket.Location = position2;
                    this.btnTennis.Location = position3;
                    this.btnVolley.Location = position4;
                    this.btnHandball.Location = position5;
                    break;
                case "Basketball":
                    this.btnBasket.Location = position1;
                    this.btnSoccer.Location = position2;
                    this.btnTennis.Location = position3;
                    this.btnVolley.Location = position4;
                    this.btnHandball.Location = position5;
                    break;
                case "Tennis":
                    this.btnTennis.Location = position1;
                    this.btnSoccer.Location = position2;
                    this.btnBasket.Location = position3;
                    this.btnVolley.Location = position4;
                    this.btnHandball.Location = position5;
                    break;
                case "Volleyball":
                    this.btnVolley.Location = position1;
                    this.btnSoccer.Location = position2;
                    this.btnBasket.Location = position3;
                    this.btnTennis.Location = position4;
                    this.btnHandball.Location = position5;
                    break;
                case "Handball":
                    this.btnHandball.Location = position1;
                    this.btnSoccer.Location = position2;
                    this.btnBasket.Location = position3;
                    this.btnTennis.Location = position4;
                    this.btnVolley.Location = position5;
                    break;
            }

            this.pnlSelectDeport.Controls.Add(btnSoccer);
            this.pnlSelectDeport.Controls.Add(btnBasket);
            this.pnlSelectDeport.Controls.Add(btnTennis);
            this.pnlSelectDeport.Controls.Add(btnVolley);
            this.pnlSelectDeport.Controls.Add(btnHandball);
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

        private void ReloadFrame(Form f)
        {
            f.Dispose();

            switch (f.Name)
            {
                case "FrmExplore":
                case "FrmChampionship":
                    f = new FrmExplore();
                    break;
                case "FrmHome":
                    f = new FrmHome();
                    break;
                case "FrmFavorites":
                    f = new FrmFavorites();
                    break;
            }

            OpenFrame(f, PnlDisplay);
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmHome", false).Length == 0)
            {
                FrmHome h = new FrmHome();
                OpenFrame(h, PnlDisplay);
            }
        }

        private void btnExplore_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmExplore", false).Length == 0)
            {
                FrmExplore fe = new FrmExplore();
                OpenFrame(fe, PnlDisplay);
            }
        }

        private void btnFavorites_Click(object sender, System.EventArgs e)
        {
            if (PnlDisplay.Controls.Find("FrmFavorites", false).Length == 0)
            {
                FrmFavorites f = new FrmFavorites();
                OpenFrame(f, PnlDisplay);
            }
        }

        private void btnDeport_Click(object sender, System.EventArgs e)
        {
            Button btnSender = sender as Button;

            switch (btnSender.Name)
            {
                case "btnSoccer":
                    Deport = "Soccer";
                    Modality = "equipo";
                    break;
                case "btnBasket":
                    Deport = "Basketball";
                    Modality = "equipo";
                    break;
                case "btnTennis":
                    Deport = "Tennis";
                    Modality = "individual";
                    break;
                case "btnVolley":
                    Deport = "Volleyball";
                    Modality = "equipo";
                    break;
                case "btnHandball":
                    Deport = "Handball";
                    Modality = "equipo";
                    break;
            }

            if (btnSender.Location != new Point(0, 0))
            {
                SelectDeport();
                ReloadFrame((Form)PnlDisplay.Controls[0]);
            }

            if (pnlSelectDeport.Size.Height != 33)
            {
                pnlSelectDeport.Size = new Size(140, 33);
            }
            else
            {
                pnlSelectDeport.Size = new Size(140, 165);
            }
        }
    }
}
