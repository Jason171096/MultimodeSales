using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;
using MultimodeSales.Programacion;

namespace MultimodeSales.Vistas
{
    public partial class PedidosFinal : Form
    {
        private int Buscar;
        ListaPedidosFinal listaPedidosFinal = new ListaPedidosFinal();
        public PedidosFinal()
        {
            InitializeComponent();
            rbtnNumPedido.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            rbtnFecha.CheckedChanged += new EventHandler(radioButtonBuscar_CheckedChanged);
            CargarLista();
        }

        private void radioButtonBuscar_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.Checked && rb.TabIndex == 10)
            {
                dateTimePicker1.Enabled = false;
                Buscar = 1;
            }
            else if(rb.Checked && rb.TabIndex == 12)
            {
                dateTimePicker1.Enabled = true;
                Buscar = 2;
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (Buscar == 1)
            {

            }
            else if (Buscar == 2)
            {

            }
        }

        private void CargarLista()
        {
            dgvPedidosFinal.DataSource = null;
            DataTable dt;
            dt = listaPedidosFinal.ObtenerListaPedidosFinal();
            dgvPedidosFinal.DataSource = dt;
        }
    }
}
