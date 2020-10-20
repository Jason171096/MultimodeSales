using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Vistas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MultimodeSales.Vistas
{
    public partial class Pedido : Form
    {
        CDataGridView cDataGrid = new CDataGridView();
        ClienteDB cliente = new ClienteDB();
        ModelosDB modelos = new ModelosDB();
        CPedido pedido = new CPedido();
        CColoresyTallas ColoresyTallas = new CColoresyTallas();
        DataTable DataModels = new DataTable();
        private bool CellValueChange = false, SelectIndexChange = false;
        private int MX;
        private int MY;

        public Pedido()
        {
            InitializeComponent();
            cDataGrid.FormattingDataGridView(dgvPedido);
            Clientes();
            Modelos();
            Colores();
            Tallas();
            IDMarca.ReadOnly = true;
            dgvPedido.Columns[0].Visible = false;
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
        private void Modelos()
        {
            DataTable dt = modelos.ObtenerModelos2();
            IDModelo.DisplayMember = "IDModelo";
            IDModelo.DataSource = dt;
            DataModels = dt;
        }
        private void Colores()
        {
            DataTable dt = ColoresyTallas.VerColores();
            IDColor.DisplayMember = "Nombre";
            IDColor.DataSource = dt;
        }
        private void Tallas()
        {
            DataTable dt = ColoresyTallas.VerTallas();
            IDTalla.DisplayMember = "Numero";
            IDTalla.DataSource = dt;
        }
        private void btnAgregarModelo_Click(object sender, EventArgs e)
        {
            EditModelo modelo = new EditModelo(true, "", "", "", "", "");
            modelo.ShowDialog();
            Modelos();
        }
        private void btnAgregarColorTalla_Click(object sender, EventArgs e)
        {
            TallasyColores tallasyColores = new TallasyColores();
            tallasyColores.ShowDialog();
            Colores();
            Tallas();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                Close();
        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            int index = cboxCliente.Items.Count - 1;
            if (index != cboxCliente.SelectedIndex)
            {
                foreach (DataGridViewRow rows in dgvPedido.Rows)
                {
                
                    if (rows.Cells[1].Value + "" != "")
                    {
                        pedido.AgregarPedido(rows.Cells[0].Value + "", rows.Cells[1].Value + "", cboxCliente.SelectedValue + "", rows.Cells[3].Value + "", rows.Cells[4].Value + "");
                    }                 
                }
                MessageBox.Show("Pedido ingresado correctamente", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Seleccione Cliente", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void dgvPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == 1)
            {
                if (CellValueChange)
                {
                    string value = dgvPedido.Rows[e.RowIndex].Cells[1].Value + "";
                    string marca = "";
                    foreach (DataRow rows in DataModels.Rows)
                    {
                        if (value == rows[0] + "")
                        {
                            marca = rows[2] + "";
                            break;
                        }
                    }
                    dgvPedido.Rows[e.RowIndex].Cells[2].Value = marca;
                }
                CellValueChange = true;
            }
        }
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    if (!dgvPedido.Rows[e.RowIndex].Cells[0].Value.Equals(""))
                        pedido.EliminarPedido(dgvPedido.Rows[e.RowIndex].Cells[0].Value + "");
                    dgvPedido.Rows.Remove(dgvPedido.Rows[e.RowIndex]);
                }
            }
            catch
            {
                MessageBox.Show("No se puede eliminar", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dgvPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvPedido.Rows[e.RowIndex].Cells[5].Value = Properties.Resources.basura24px;
        }
        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectIndexChange)
            {
                dgvPedido.Rows.Clear();
                DataTable dt = pedido.CargarPedido(cboxCliente.SelectedValue + "");
                int i = 0;
                foreach (DataRow rows in dt.Rows)
                {
                    dgvPedido.Rows.Add();
                    dgvPedido.Rows[i].Cells[0].Value = rows[0];
                    dgvPedido.Rows[i].Cells[1].Value = rows[1];
                    dgvPedido.Rows[i].Cells[3].Value = rows[2];
                    dgvPedido.Rows[i].Cells[4].Value = rows[3];
                    i++;
                }
            }
            SelectIndexChange = true;
        }

        #region Panel Barra
        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbPedido_MouseMove(object sender, MouseEventArgs e)
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
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                Close();
        }
        #endregion
    }
}
