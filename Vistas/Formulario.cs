using System;
using System.Windows.Forms;
using MultimodeSales.Vistas;
using MultimodeSales.Vistas.Buscar;
using MultimodeSales.Vistas.Excel;
using MultimodeSales.Programacion;
using MultimodeSales.Vistas.Ventas;

namespace MultimodeSales
{
    public partial class Formulario : Form
    {
        private int MX = 0;
        private int MY = 0;
        public Formulario()
        {
            InitializeComponent();
            #region Panel Visible
            panelCliente.Visible = false;
            panelImportExcel.Visible = false;
            panelMarca.Visible = false;
            panelPedidosFinal.Visible = false;
            panelModelos.Visible = false;
            panelColTall.Visible = false;
            panelPedido.Visible = false;
            panelVenta.Visible = false;
            panelDevolucion.Visible = false;
            lbDevolucion.Visible = false;
            #endregion
            #region Labels Visible
            lbCliente.Visible = false;
            lbImportExcel.Visible = false;
            lbMarca.Visible = false;
            lbPedidosFinal.Visible = false;
            lbModelos.Visible = false;
            lbColTall.Visible = false;
            lbPedido.Visible = false;
            lbVenta.Visible = false;
            lbDevolucion.Visible = false;
            #endregion

        }
        #region picCliente
        private void picCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void picCliente_MouseEnter(object sender, EventArgs e)
        {
            panelCliente.Visible = true;
            lbCliente.Visible = true;
        }

        private void picCliente_MouseLeave(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
            lbCliente.Visible = false;
        }
        #endregion
        #region picImportExcel
        private void picImportExcel_Click(object sender, EventArgs e)
        {
            ImportarPor importarPor = new ImportarPor();
            importarPor.ShowDialog();         
        }

        private void picImportExcel_MouseEnter(object sender, EventArgs e)
        {
            panelImportExcel.Visible = true;
            lbImportExcel.Visible = true;
        }

        private void picImportExcel_MouseLeave(object sender, EventArgs e)
        {
            panelImportExcel.Visible = false;
            lbImportExcel.Visible = false;
        }
        #endregion
        #region picMarca
        private void picMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Show();
        }
       
        private void picMarca_MouseEnter(object sender, EventArgs e)
        {
            panelMarca.Visible = true;
            lbMarca.Visible = true;
        }

        private void picMarca_MouseLeave(object sender, EventArgs e)
        {
            panelMarca.Visible = false;
            lbMarca.Visible = false;
        }
        #endregion
        #region picPedidos Final
        private void picPedidosFinal_Click(object sender, EventArgs e)
        {
            PedidosFinal pedidosFinal = new PedidosFinal();
            pedidosFinal.Show();
        }

        private void picPedidosFinal_MouseEnter(object sender, EventArgs e)
        {
            panelPedidosFinal.Visible = true;
            lbPedidosFinal.Visible = true;
        }

        private void picPedidosFinal_MouseLeave(object sender, EventArgs e)
        {
            panelPedidosFinal.Visible = false;
            lbPedidosFinal.Visible = false;
        }
        #endregion
        #region picModelos
        private void picModelos_Click(object sender, EventArgs e)
        {
            Modeloss modelos = new Modeloss();
            modelos.ShowDialog();
        }
        private void picModelos_MouseEnter(object sender, EventArgs e)
        {
            panelModelos.Visible = true;
            lbModelos.Visible = true;
        }
        private void picModelos_MouseLeave(object sender, EventArgs e)
        {
            panelModelos.Visible = false;
            lbModelos.Visible = false;
        }
        #endregion
        #region picColTall
        private void picColTall_MouseEnter(object sender, EventArgs e)
        {
            panelColTall.Visible = true;
            lbColTall.Visible = true;
        }

        private void picColTall_MouseLeave(object sender, EventArgs e)
        {
            panelColTall.Visible = false;
            lbColTall.Visible = false;
        }

        private void picColTall_Click(object sender, EventArgs e)
        {
            TallasyColores tallasyColores = new TallasyColores();
            tallasyColores.Show();
            
            
        }
        #endregion
        #region picPedido
        private void picPedido_MouseEnter(object sender, EventArgs e)
        {
            panelPedido.Visible = true;
            lbPedido.Visible = true;
        }
        private void picPedido_MouseLeave(object sender, EventArgs e)
        {
            panelPedido.Visible = false;
            lbPedido.Visible = false;
        }
        private void picPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
        }
        #endregion
        #region picVenta
        private void picVenta_MouseEnter(object sender, EventArgs e)
        {
            panelVenta.Visible = true;
            lbVenta.Visible = true;
        }

        private void picVenta_MouseLeave(object sender, EventArgs e)
        {
            panelVenta.Visible = false;
            lbVenta.Visible = false;
        }

        private void picVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.ShowDialog();
        }
        #endregion
        #region picDevolucion
        private void picDevolucion_MouseEnter(object sender, EventArgs e)
        {
            panelDevolucion.Visible = true;
            lbDevolucion.Visible = true;
        }

        private void picDevolucion_MouseLeave(object sender, EventArgs e)
        {
            panelDevolucion.Visible = false;
            lbDevolucion.Visible = false;
        }
        #endregion

        #region Barra Superior
        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lbFecha_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbHora_MouseMove(object sender, MouseEventArgs e)
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





        #endregion


    }
}
