using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using MultimodeSales.Programacion.Modelo;
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
        Modelo modelo = new Modelo();
        DataTable dtPedidos;

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
            borrarLabels();
        }
        private void CargarPedidos(string idcliente)
        {
            dgvPedidosFinal.DataSource = null;
            dtPedidos = pedidosFinal.ObtenerPedidoFinalLlego(idcliente);
            dgvPedidosFinal.DataSource = dtPedidos;
        }

        private void dgvPedidosFinal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string lbprecioTotal = lbTotal.Text.Trim('$');
                    string cantidad = lbCantidad.Text;
                    string precioCliente = dgvPedidosFinal.CurrentRow.Cells[4].Value.ToString();
                    if (dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor == Color.YellowGreen)
                    {
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.Indigo;
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
                        ActualizarLabels(1, lbprecioTotal, cantidad, precioCliente);
                    }
                    else
                    {
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                        dgvPedidosFinal.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                        ActualizarLabels(2, lbprecioTotal, cantidad, precioCliente);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al seleccionar un modelo", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnVender_Click(object sender, EventArgs e)
        {
            CVenta venta = new CVenta();
            int cont = 0;
            foreach (DataGridViewRow rows in dgvPedidosFinal.Rows)
            {
                if (rows.DefaultCellStyle.BackColor == Color.YellowGreen)
                    cont++;
            }
            if(cboxCliente.SelectedIndex != cboxCliente.Items.Count - 1)
            {
                if(txtFolio.Text != "")
                {
                    if(cont >= 1)
                    {
                        int idfolio = venta.verificarFolioExistente(txtFolio.Text);
                        if (idfolio == 1)
                            MessageBox.Show("Folio existente", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else 
                        {
                            DialogVenta dialog = new DialogVenta(lbTotal.Text, txtFolio.Text);
                            dialog.ShowDialog();
                        }   
                    }
                    else
                        MessageBox.Show("Seleccionar un articulo", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No dejar el folio vacio", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Seleccionar un cliente", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PedidosFinal final = new PedidosFinal(true);
            final.ShowDialog();
            modelo = final.returnModelo();
            if (modelo.IDModelo != null)
            {
                dtPedidos.Rows.Add(modelo.IDModelo, modelo.IDMarca, modelo.Color, modelo.Talla, modelo.PrecioCliente);
                dgvPedidosFinal.DataSource = null;
                dgvPedidosFinal.DataSource = dtPedidos;
            }
        }

        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            Modeloss modelos = new Modeloss(true);
            modelos.ShowDialog();
            modelo = modelos.returnModelo();
            if (modelo.IDModelo != null)
            {
                dtPedidos.Rows.Add(modelo.IDModelo, modelo.IDMarca, modelo.Color, modelo.Talla, modelo.PrecioCliente);
                dgvPedidosFinal.DataSource = null;
                dgvPedidosFinal.DataSource = dtPedidos;
            }
        }

        private void btnSelTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvPedidosFinal.Rows)
            {
                if (rows.DefaultCellStyle.BackColor != Color.YellowGreen)
                {
                    rows.DefaultCellStyle.BackColor = Color.YellowGreen;
                    rows.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                    ActualizarLabels(2, lbTotal.Text.ToString().Trim('$'), lbCantidad.Text, rows.Cells[4].Value.ToString());
                }
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
