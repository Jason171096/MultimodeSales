using MultimodeSales.Programacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Excel
{
    public partial class ImportarPor : Form
    {
        CPanelBarras cPanel = new CPanelBarras();
        private int MX = 0;
        private int MY = 0;
        public ImportarPor()
        {
            InitializeComponent();

        }
        private void btnImportarPrecios_Click_1(object sender, EventArgs e)
        {
            ImportarListaMarca importarLista = new ImportarListaMarca();
            importarLista.ShowDialog();
        }

        private void btnImportarPedidos_Click_1(object sender, EventArgs e)
        {
            ImportarPedidosFinal importarPedidos = new ImportarPedidosFinal();
            importarPedidos.ShowDialog();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MX = e.X;
                MY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MX);
                Top = Top + (e.Y - MY);
            }
        }
    }
}
