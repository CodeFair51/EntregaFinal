using System.Windows.Forms;

namespace BackOfficeAdmin
{
    public class PnlDisplay : Panel
    {
        public PnlDisplay()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Location = new System.Drawing.Point(0, 65);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "pnlDisplay";
            this.Size = new System.Drawing.Size(800, 385);
            this.TabIndex = 1;
        }
    }
}
