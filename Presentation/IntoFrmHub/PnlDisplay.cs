using System.Windows.Forms;

namespace Presentation.IntoFrmHub
{
    public class PnlDisplay : Panel
    {
        public PnlDisplay()
        {
            InitializePanel();
        }

        private void InitializePanel()
        {
            this.Anchor = this.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.Location = new System.Drawing.Point(0, 60);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(1100, 559);
            this.TabIndex = 2;
            this.Show();
        }
    }
}
