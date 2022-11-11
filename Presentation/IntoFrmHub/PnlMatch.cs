using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.IntoFrmHub
{
    public class PnlMatch : Panel
    {
        private Label lblTeam1Name, lblTeam2Name, lblTeam1Score, lblTeam2Score, lblTeam1Shield, lblTeam2Shield, lblSeparator, lblDate;
        private string _idPartido;

        public PnlMatch()
        {
            InitializeComponent();
        }

        public Label LblTeam1Name { get => lblTeam1Name; set => lblTeam1Name = value; }
        public Label LblTeam2Name { get => lblTeam2Name; set => lblTeam2Name = value; }
        public Label LblTeam1Score { get => lblTeam1Score; set => lblTeam1Score = value; }
        public Label LblTeam2Score { get => lblTeam2Score; set => lblTeam2Score = value; }
        public Label LblTeam1Shield { get => lblTeam1Shield; set => lblTeam1Shield = value; }
        public Label LblTeam2Shield { get => lblTeam2Shield; set => lblTeam2Shield = value; }
        public Label LblDate { get => lblDate; set => lblDate = value; }
        public string IdPartido { get => _idPartido; set => _idPartido = value; }

        private void InitializeComponent()
        {
            this.Show();
            this.Size = new System.Drawing.Size(345, 80);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

            lblTeam1Name = new Label();
            lblTeam2Name = new Label();
            lblTeam1Score = new Label();
            lblTeam2Score = new Label();
            lblTeam1Shield = new Label();
            lblTeam2Shield = new Label();
            lblSeparator = new Label();
            lblDate = new Label();

            lblTeam1Shield.Location = new System.Drawing.Point(10, 10);
            lblTeam1Shield.Size = new System.Drawing.Size(35, 35);

            lblTeam2Shield.Location = new System.Drawing.Point(10, 60);
            lblTeam2Shield.Size = new System.Drawing.Size(35, 35);

            lblTeam1Name.Location = new System.Drawing.Point(50, 10);
            lblTeam1Name.AutoSize = true;
            lblTeam1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);

            lblTeam2Name.Location = new System.Drawing.Point(50, 45);
            lblTeam2Name.AutoSize = true;
            lblTeam2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);

            lblTeam1Score.Location = new System.Drawing.Point(235, 10);
            lblTeam1Score.Size = new System.Drawing.Size(20, 24);
            lblTeam1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);

            lblTeam2Score.Location = new System.Drawing.Point(235, 45);
            lblTeam2Score.Size = new System.Drawing.Size(20, 24);
            lblTeam2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);

            lblSeparator.Location = new System.Drawing.Point(245, 0);
            lblSeparator.AutoSize = true;
            lblSeparator.Text = "|";
            lblSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);

            lblDate.Location = new System.Drawing.Point(285, 22);
            lblDate.Size = new System.Drawing.Size(40, 40);
            lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);

            this.Controls.Add(lblTeam1Name);
            this.Controls.Add(lblTeam2Name);
            this.Controls.Add(lblTeam1Score);
            this.Controls.Add(lblTeam2Score);
            this.Controls.Add(LblTeam1Shield);
            this.Controls.Add(lblTeam2Shield);
            this.Controls.Add(lblSeparator);
            this.Controls.Add(lblDate);
        }
    }
}
