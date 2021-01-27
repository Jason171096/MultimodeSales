using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;
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
        ClienteDB cliente = new ClienteDB();
        private bool SelectIndexChange = false;
        Modelo modelo = new Modelo();
        DataTable dtPedidos;
        private bool ventaCompleta;
        private string idcliente;

        public Venta()
        {
            InitializeComponent();
            CDataGridView.FormattedDataGridView(dgvVentasPedido);
            CRoundButton.FormattedRoundButtonAceptar(rbtnSelTodo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarModelo);
            CRoundButton.FormattedRoundButtonAceptar(rbtnAgregarPedido);
            CRoundButton.FormattedRoundButtonCancelar(rbtnVender);
            Clientes();
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                idcliente = cboxCliente.SelectedValue + "";
                CargarPedidos(idcliente);
            }
            SelectIndexChange = true;
            borrarLabels();
        }
        private void CargarPedidos(string idcliente)
        {
            dgvVentasPedido.DataSource = null;
            dtPedidos = pedidosFinal.ObtenerPedidoFinalLlego(idcliente);
            dgvVentasPedido.DataSource = dtPedidos;
            dgvVentasPedido.Columns[0].Visible = false;
        }

        private void dgvPedidosFinal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string lbprecioTotal = lbTotal.Text.Trim('$');
                    string cantidad = lbCantidad.Text;
                    string precioCliente = dgvVentasPedido.CurrentRow.Cells[4].Value.ToString();
                    if (dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor == Color.YellowGreen)
                    {
                        dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                        dgvVentasPedido.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                        ActualizarLabels(1, lbprecioTotal, cantidad, precioCliente);
                    }
                    else
                    {
                        dgvVentasPedido.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                        dgvVentasPedido.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                        ActualizarLabels(2, lbprecioTotal, cantidad, precioCliente);
                    }
                }
            }
            catch(Exception ex)
            {
                CMsgBox.DisplayError($"Error al seleccionar un modelo \n Mensaje: \n {ex.Message}");
            }
        }
        private void ActualizarLabels(int pSumaoResta, string plbPrecio, string pCantidad, string pPrecioCliente)
        {
            int totalCantidad = int.Parse(pCantidad);
            float precioCliente = float.Parse(pPrecioCliente.Trim('$'));
            float totalPrecio;
            if(pSumaoResta == 1)
            {
                totalPrecio = float.Parse(plbPrecio) - precioCliente;
                totalCantidad--;
            }
            else
            {    
                totalPrecio = float.Parse(plbPrecio) + precioCliente;
                totalCantidad++;
            }
            lbTotal.Text = string.Format("{0:C}", totalPrecio);
            lbCantidad.Text = totalCantidad + "";
        }
        private void rbtnSelTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor != Color.YellowGreen)
                {
                    rows.DefaultCellStyle.BackColor = Color.YellowGreen;
                    rows.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                    ActualizarLabels(2, lbTotal.Text.ToString().Trim('$'), lbCantidad.Text, rows.Cells[5].Value.ToString());
                }
            }
        }

        private void rbtnVender_Click(object sender, EventArgs e)
        {
            CVenta venta = new CVenta();
            int cont = 0;
            foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                    cont++;
            }
            if (cboxCliente.SelectedIndex != cboxCliente.Items.Count - 1)
            {
                if (txtFolio.Text != "")
                {
                    if (cont >= 1)
                    {
                        int idfolio = venta.verificarFolioExistente(txtFolio.Text);
                        if (idfolio == 1)
                            CMsgBox.DisplayWarning("Folio existente");
                        else
                        {
                            DialogVenta dialog = new DialogVenta(lbTotal.Text, txtFolio.Text);
                            dialog.ShowDialog();
                            ventaCompleta = dialog.ventaCompletada();
                            if(ventaCompleta)
                            {
                                foreach (DataGridViewRow rows in dgvVentasPedido.Rows)
                                {
                                    venta.ventaPedido(rows.Cells[0].Value.ToString());
                                }
                                CargarPedidos(idcliente);
                            }
                        }
                    }
                    else
                        CMsgBox.DisplayWarning("Seleccionar un articulo");
                }
                else
                    CMsgBox.DisplayWarning("No dejar el folio vacio");
            }
            else
                CMsgBox.DisplayWarning("Seleccionar un cliente");
        }

        private void rbtnAgregarPedido_Click(object sender, EventArgs e)
        {
            borrarLabels();
            PedidosFinal final = new PedidosFinal(true);
            final.ShowDialog();
            modelo = final.returnModelo();
            if (modelo.IDModelo != null)
            {
                dtPedidos.Rows.Add(modelo.IDModelo, modelo.IDMarca, modelo.Color, modelo.Talla, modelo.PrecioCliente);
                dgvVentasPedido.DataSource = null;
                dgvVentasPedido.DataSource = dtPedidos;
            }
        }

        private void rbtnAgregarModelo_Click(object sender, EventArgs e)
        {
            borrarLabels();
            Modeloss modelos = new Modeloss(true);
            modelos.ShowDialog();
            modelo = modelos.returnModelo();
            if (modelo.IDModelo != null)
            {
                dtPedidos.Rows.Add(modelo.IDModelo, modelo.IDMarca, modelo.Color, modelo.Talla, modelo.PrecioCliente);
                dgvVentasPedido.DataSource = null;
                dgvVentasPedido.DataSource = dtPedidos;
            }
        }

        private void borrarLabels()
        {
            lbCantidad.Text = "0";
            lbTotal.Text = "$0.00";
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
