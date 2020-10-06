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

namespace MultimodeSales.Vistas
{
    public partial class Cliente : Form
    {
        ClienteDB cliente = new ClienteDB();
        CDataGridView CDataGrid = new CDataGridView();
        Validaciones validaciones = new Validaciones();
        DataTable dt = new DataTable();
        private int MX = 0;
        private int MY = 0;
        public Cliente()
        {
            InitializeComponent();
            CDataGrid.FormattingDataGridView(dgvClientes);
            LlenarDataGridView();
        }


        public void LlenarDataGridView()
        {
            dgvClientes.DataSource = null;
            dt.Clear();
            dt = cliente.VerClientes();
            dgvClientes.DataSource = dt;
            dgvClientes.Columns[0].Width = 200;
            dgvClientes.Columns[1].Width = 650;
            
        }

        private void lbClientes_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetrasyNumeros(sender, e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Convert(IDCliente, 'System.String') LIKE '%{0}%' OR Nombre LIKE '%{0}%'", txtBuscar.Text);
            dgvClientes.DataSource = dv;
        }
    }
}
