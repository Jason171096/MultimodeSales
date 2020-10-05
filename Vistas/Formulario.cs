using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultimodeSales.Vistas;
using MultimodeSales.Vistas.Buscar;
using MultimodeSales.Vistas.Excel;

namespace MultimodeSales
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            #region Panel Visible
            panelCliente.Visible = false;
            panelImportExcel.Visible = false;
            panelMarca.Visible = false;
            panelPedidosFinal.Visible = false;
            panelBuscar.Visible = false;
            panelModelos.Visible = false;
            #endregion
            #region Labels Visible
            lbCliente.Visible = false;
            lbImportExcel.Visible = false;
            lbMarca.Visible = false;
            lbPedidosFinal.Visible = false;
            lbBuscar.Visible = false;
            lbModelos.Visible = false;
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
        #region picBuscar
        private void picBuscar_Click(object sender, EventArgs e)
        {
            BuscarPor buscar = new BuscarPor();
            buscar.ShowDialog();
        }

        private void picBuscar_MouseEnter(object sender, EventArgs e)
        {
            panelBuscar.Visible = true;
            lbBuscar.Visible = true;
        }

        private void picBuscar_MouseLeave(object sender, EventArgs e)
        {
            panelBuscar.Visible = false;
            lbBuscar.Visible = false;
        }
        #endregion
        #region picModelos
        private void picModelos_Click(object sender, EventArgs e)
        {
            Modelos modelos = new Modelos();
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
        #endregion}

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        
    }
}
