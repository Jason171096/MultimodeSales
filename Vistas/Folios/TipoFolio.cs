using MultimodeSales.Programacion.Utilerias;
using System;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Folios
{
    public partial class TipoFolio : Form
    {
        public TipoFolio()
        {
            InitializeComponent();
            CRoundButton.FormattedRoundButtonAceptar(rbtnFolioDevoluciones);
            CRoundButton.FormattedRoundButtonAceptar(rbtnFolioVentas);
        }

        private void rbtnFolioVentas_Click(object sender, EventArgs e)
        {
            Folio folio = new Folio(true);
            Close();
            folio.Show();
        }

        private void rbtnFolioDevoluciones_Click(object sender, EventArgs e)
        {
            Folio folio = new Folio(false);
            Close();
            folio.Show();
        }
    }
}
