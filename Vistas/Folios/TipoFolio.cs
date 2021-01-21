using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Folios
{
    public partial class TipoFolio : Form
    {
        public TipoFolio()
        {
            InitializeComponent();
        }

        private void btnFolioVenta_Click(object sender, EventArgs e)
        {
            Folio folio = new Folio(true);
            Close();
            folio.Show();
            
        }

        private void btnFolioDevoluciones_Click(object sender, EventArgs e)
        {
            Folio folio = new Folio(false);
            Close();
            folio.Show();
        }
    }
}
