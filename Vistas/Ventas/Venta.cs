using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using System;
using System.Data;
using System.Drawing;
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
            string lbprecioTotal = lbTotal.Text.Trim('$');
            string cantidad = lbCantidad.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor == Color.YellowGreen)
                {
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                    ActualizarLabels(1, lbprecioTotal, cantidad);
                }
                else
                {
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                    dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                    ActualizarLabels(2, lbprecioTotal, cantidad);
                }
                
            }
        }
        private void ActualizarLabels(int sumaoresta, string lbprecio, string cantidad)
        {
            int totalCantidad = int.Parse(cantidad);
            float precioCliente = float.Parse(dgvPedidosFinal.CurrentRow.Cells[5].Value + "".Trim('$'));
            float totalPrecio;
            if(sumaoresta == 1)
            {
                totalPrecio = float.Parse(lbprecio) - precioCliente;
                totalCantidad--;
            }
            else
            {    
                totalPrecio = float.Parse(lbprecio) + precioCliente;
                totalCantidad++;
            }
            lbTotal.Text = string.Format("{0:C}", totalPrecio);
            lbCantidad.Text = totalCantidad + "";
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            DialogVenta dialog = new DialogVenta(lbTotal.Text);
            dialog.ShowDialog();
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
    }
}
