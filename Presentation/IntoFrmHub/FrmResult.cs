using System.Windows.Forms;

namespace Presentation.IntoFrmHub
{
    public partial class FrmResult : Form
    {
        private string idPartido;

        public FrmResult(string idPartido)
        {
            InitializeComponent();
            this.idPartido = idPartido;
        }
    }
}
