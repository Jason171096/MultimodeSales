using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Folios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas
{
    public partial class Folio : Form
    {
        CFolio cFolio = new CFolio();
        public Folio(bool pFolio)
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvFolio);
            if(pFolio)
            {
                lbFolio.Text = "Folios Ventas";
                cargarFoliosVentas();
            }
            else
            {
                lbFolio.Text = "Folios Devoluciones";
            }
        }

        private void cargarFoliosVentas()
        {
            dgvFolio.DataSource = null;
            DataTable dtVentas = new DataTable();
            dtVentas = cFolio.verFoliosVentas();
            dgvFolio.DataSource = dtVentas;
        }
        
    }
}
