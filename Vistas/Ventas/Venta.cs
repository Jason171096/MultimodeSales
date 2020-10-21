using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Ventas
{
    public partial class Venta : Form
    {
        private int MX;
        private int MY;
        ListaPedidosFinal pedidosFinal = new ListaPedidosFinal();
        CDataGridView cDataGrid = new CDataGridView();
        ClienteDB cliente = new ClienteDB();
        private bool SelectIndexChange = false;

        public Venta()
        {
            InitializeComponent();
            cDataGrid.FormattingDataGridView(dgvPedidosFinal);
            Clientes();
        }
        private void Clientes()
        {
            DataTable dt = cliente.VerClientes();
            cboxCliente.DisplayMember = "Nombre";
            cboxCliente.ValueMember = "IDCliente";
            dt.Rows.Add(0, "--Seleccione el cliente--");
            cboxCliente.DataSource = dt;
            cboxCliente.SelectedIndex = cboxCliente.Items.Count - 1;
        }

        #region Panel Barras
        private void lbVentas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void panelVentas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private new void MouseMove(object sender, MouseEventArgs e)
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

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectIndexChange)
            {
                string idcliente = cboxCliente.SelectedValue + "";
                CargarPedidos(idcliente);
            }
            SelectIndexChange = true;
        }
        private void CargarPedidos(string idcliente)
        {
            dgvPedidosFinal.DataSource = null;
            DataTable dt = pedidosFinal.ObtenerPedidoFinalLlego(idcliente);
            dgvPedidosFinal.DataSource = dt;
        }

        private void dgvPedidosFinal_KeyDown(object sender, KeyEventArgs e)
        {
            string precioCliente;
            string lbprecio = lbTotal.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor == Color.YellowGreen)
                {
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                    precioCliente = dgvPedidosFinal.CurrentRow.Cells[4].Value + "";
                    int suma = Convert.ToInt32(lbprecio) + Convert.ToInt32(precioCliente);
                    //lbTotal.Text = string.Format("{0:C}", suma + "");
                }
                else
                {
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Black;
                    precioCliente = dgvPedidosFinal.CurrentRow.Cells[4].Value + "";
                    int resta = Convert.ToInt32(lbprecio) - Convert.ToInt32(precioCliente);
                    //lbTotal.Text = string.Format("{0:C}", resta + "");
                }
                
            }
        }
    }
}
