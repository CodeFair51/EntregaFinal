using Entities;
using Logic;

using System.Windows.Forms;

namespace BackOfficeAdmin.ManagementFrames
{
    public class PnlUpdateResult : Panel
    {
        private Match objMatch = null;
        private readonly MatchLogic objMatchLogic = new MatchLogic();

        private Button btnAddScore1, btnAddScore2, btnRemoveScore1, btnRemoveScore2, btnFinishMatch, btnUpdate;
        private Label lblTeam1, lblTeam2, lblScore1, lblScore2, lblDuration;

        public PnlUpdateResult()
        {
            InitializeComponent();
        }

        public Label LblTeam1 { get => lblTeam1; set => lblTeam1 = value; }
        public Label LblTeam2 { get => lblTeam2; set => lblTeam2 = value; }
        public Label LblScore1 { get => lblScore1; set => lblScore1 = value; }
        public Label LblScore2 { get => lblScore2; set => lblScore2 = value; }
        public Label LblDuration { get => lblDuration; set => lblDuration = value; }

        private void InitializeComponent()
        {
            this.Show();
            this.Size = new System.Drawing.Size(230, 70);
            this.BorderStyle = BorderStyle.FixedSingle;

            LblTeam1 = new Label()
            {
                Font = new System.Drawing.Font("", 16F),
                AutoSize = true,
                Location = new System.Drawing.Point(10, 10)
            };

            LblTeam2 = new Label()
            {
                Font = new System.Drawing.Font("", 16F),
                AutoSize = true,
                Location = new System.Drawing.Point(10, 45)
            };

            LblScore1 = new Label()
            {
                Font = new System.Drawing.Font("", 10F),
                AutoSize = true,
                Location = new System.Drawing.Point(195, 10)
            };

            LblScore2 = new Label()
            {
                Font = new System.Drawing.Font("", 10F),
                AutoSize = true,
                Location = new System.Drawing.Point(195, 45)
            };

            LblDuration = new Label()
            {
                Font = new System.Drawing.Font("", 10F),
                AutoSize = true,
                Location = new System.Drawing.Point(220, 45)
            };

            btnAddScore1 = new Button()
            {
                Font = new System.Drawing.Font("", 12F),
                Location = new System.Drawing.Point(200, 10),
                Size = new System.Drawing.Size(60, 25),
                Text = "Sumar"
            };
            btnAddScore1.Click += new System.EventHandler(btnAddScore1_Click);

            btnAddScore2 = new Button()
            {
                Font = new System.Drawing.Font("", 12F),
                Location = new System.Drawing.Point(200, 45),
                Size = new System.Drawing.Size(60, 25),
                Text = "Sumar"
            };
            btnAddScore2.Click += new System.EventHandler(btnAddScore2_Click);

            btnRemoveScore1 = new Button()
            {
                Font = new System.Drawing.Font("", 12F),
                Location = new System.Drawing.Point(200, 10),
                Size = new System.Drawing.Size(60, 25),
                Text = "Restar"
            };
            btnRemoveScore1.Click += new System.EventHandler(btnRemoveScore1_Click);

            btnRemoveScore2 = new Button()
            {
                Font = new System.Drawing.Font("", 12F),
                Location = new System.Drawing.Point(200, 45),
                Size = new System.Drawing.Size(60, 25),
                Text = "Restar"
            };
            btnRemoveScore2.Click += new System.EventHandler(btnRemoveScore2_Click);

            btnUpdate = new Button()
            {
                Font = new System.Drawing.Font("", 12F),
                Location = new System.Drawing.Point(200, 45),
                Size = new System.Drawing.Size(70, 30),
                Text = "Actualizar"
            };
            btnUpdate.Click += new System.EventHandler(btnUpdate_Click);

            btnFinishMatch = new Button()
            {
                Font = new System.Drawing.Font("", 12F),
                Location = new System.Drawing.Point(200, 45),
                Size = new System.Drawing.Size(70, 30),
                Text = "Finalizar partido"
            };
            btnFinishMatch.Click += new System.EventHandler(btnFinishMatch_Click);
        }

        private void btnAddScore1_Click(object sender, System.EventArgs e)
        {
            objMatch = new Match()
            {

            };
        }

        private void btnAddScore2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnRemoveScore1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnRemoveScore2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {

        }

        private void btnFinishMatch_Click(object sender, System.EventArgs e)
        {

        }

    }
}
