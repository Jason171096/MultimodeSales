using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Vistas.Modelos;

namespace MultimodeSales.Vistas
{
    public partial class Modeloss : Form
    {
        ModelosDB modelos = new ModelosDB();
        CDataGridView cDataGrid = new CDataGridView();
        private int MX;
        private int MY;

        public Modeloss()
        {
            InitializeComponent();
            CargarModelos();
            cDataGrid.FormattingDataGridView(dgvModelos);
        }

        private void CargarModelos()
        {
            DataTable dt;
            dt = modelos.ObtenerModelos();
            dgvModelos.DataSource = dt;
            DarFormatoTabla();
        }
        private void DarFormatoTabla()
        {
            dgvModelos.Columns[1].Visible = false;
            dgvModelos.Columns[0].Width = 100;

        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Enabled)
            {
                txtBuscar.Text = "";
                txtBuscar.Enabled = false;
                dtpFecha.Enabled = true;
                btnCambiar.Text = "Modelo";
                
            }
            else
            {
                dtpFecha.Value = DateTime.Now;
                dtpFecha.Enabled = false;
                txtBuscar.Enabled = true;
                btnCambiar.Text = "Fecha";
            }
        }

        #region Panel Barras
        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbModelos_MouseMove(object sender, MouseEventArgs e)
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

        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            new EditModelo(true, "", "", "", "", "").ShowDialog();
        }

        private void btnEditarModelo_Click(object sender, EventArgs e)
        {
            string idmodelo = dgvModelos.CurrentRow.Cells[0].Value + "";
            string idmarca = dgvModelos.CurrentRow.Cells[1].Value + "";
            string color = dgvModelos.CurrentRow.Cells[3].Value + "";
            string talla = dgvModelos.CurrentRow.Cells[4].Value + "";
            string precioCliente = dgvModelos.CurrentRow.Cells[5].Value + "";
                 
            new EditModelo(false, idmodelo, idmarca, color, talla, precioCliente).ShowDialog();
        }
    }
}
