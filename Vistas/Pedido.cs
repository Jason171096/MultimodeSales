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
        private bool CellValueChange = false;
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
        }
        private void Clientes()
        {
            DataTable dt = cliente.VerClientes();
            cboxCliente.DisplayMember = "Nombre";
            cboxCliente.ValueMember = "IDCliente";
            cboxCliente.DataSource = dt;
        }
        private void Modelos()
        {
            DataTable dt = modelos.ObtenerModelos2();
            IDModelo.DisplayMember = "IDModelo";
            IDModelo.DataSource = dt;
            DataModels = dt;
            //foreach (DataRow rows in dt.Rows)
            //{
            //    IDColor.Items.Add(rows[0].ToString());
            //}
        }
        private void Colores()
        {
            DataTable dt = ColoresyTallas.VerColores();
            IDColor.DisplayMember = "Nombre";
            IDColor.DataSource = dt;
            //foreach (DataRow rows in dt.Rows)
            //{
            //    auto.Add(rows[1].ToString());
            //}
        }
        private void Tallas()
        {
            DataTable dt = ColoresyTallas.VerTallas();
            IDTalla.DisplayMember = "Numero";
            IDTalla.DataSource = dt;
            //foreach (DataRow rows in dt.Rows)
            //{
            //    auto.Add(rows[1].ToString());
            //}
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
            Close();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dgvPedido.Rows)
            {
                if (rows.Cells[0].Value + "" != "")
                {
                    pedido.AgregarPedido(rows.Cells[0].Value + "", cboxCliente.SelectedValue + "", rows.Cells[2].Value + "", rows.Cells[3].Value + "");
                }
                MessageBox.Show("Pedido ingresado correctamente", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            Close();
        }


        #endregion

        private void dgvPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (CellValueChange != false)
            {
                //dgvPedido.CellValueChanged += dgvPedido_CellValueChanged;
                if (e.ColumnIndex == 0)
                {
                    string value = dgvPedido.Rows[e.RowIndex].Cells[0].Value + "";
                    string marca = "";
                    foreach (DataRow rows in DataModels.Rows)
                    {
                        if (value == rows[0] + "")
                            marca = rows[2] + "";
                    }
                    dgvPedido.Rows[e.RowIndex].Cells[1].Value = marca;
                }
            }
            CellValueChange = true;
            
        }
    }
}
