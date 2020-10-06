using MultimodeSales.Programacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultimodeSales.Programacion.Marca;

namespace MultimodeSales.Vistas
{
    public partial class Marca : Form
    {
        MarcaBD marca = new MarcaBD();
        Validaciones validacion = new Validaciones();
        CDataGridView CDataGrid = new CDataGridView();
        DataTable dt = new DataTable();
        private int MX = 0;
        private int MY = 0;
        private int Rowindex;

        public Marca()
        {
            InitializeComponent();
            CDataGrid.FormattingDataGridView(dgvMarcas);
            LlenarDataGridViewMarca();
        }

        private void LlenarDataGridViewMarca()
        {
            dgvMarcas.DataSource = null;
            dt.Clear();
            dt = marca.VerMarcas();
            dgvMarcas.DataSource = dt;
            dgvMarcas.Columns[0].Width = 200;
            dgvMarcas.Columns[1].Width = 650;
        }
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombreMarca.Text) || String.IsNullOrWhiteSpace(txtNumeroMarca.Text))
                MessageBox.Show("No pueden estar los campos vacios de Numero de Marca o Nombre Marca", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int cont = 0;
                for (int i = 0; i < dgvMarcas.Rows.Count; i++)
                {
                    if (txtNumeroMarca.Text == dgvMarcas.Rows[i].Cells[0].Value.ToString())
                        cont++;
                }
                if (cont >= 1)
                    MessageBox.Show("No pueden existir dos marcas con Numeros Iguales, intente con otro NUMERO", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    marca.AgregarMarca(txtNumeroMarca.Text, txtNombreMarca.Text);
                    LlenarDataGridViewMarca();
                }
            }
        }

        private void btnEditarMarca_Click_1(object sender, EventArgs e)
        {
            btnAgregarMarca.Enabled = true;
            int cont = 0;
            for (int i = 0; i < dgvMarcas.Rows.Count; i++)
            {
                if (txtNumeroMarca.Text == dgvMarcas.Rows[i].Cells[0].Value.ToString())
                    if (Rowindex != dgvMarcas.Rows[i].Index)
                        cont++;
            }
            if (cont >= 1)
                MessageBox.Show("No pueden existir dos marcas con Numeros Iguales, intente con otro NUMERO", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                marca.EditarMarca(txtNumeroMarca.Text, txtNombreMarca.Text);
                LlenarDataGridViewMarca();
            }

        }
        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarMarca.Enabled = false;
            txtNumeroMarca.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
            txtNombreMarca.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
            Rowindex = e.RowIndex;
        }

        #region Validaciones
        private void txtNumeroMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        #endregion

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetrasyNumeros(sender, e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Convert(IDMarca, 'System.String') LIKE '%{0}%' OR Nombre LIKE '%{0}%'", txtBuscar.Text);
            dgvMarcas.DataSource = dv;
        }

        #region Panel Barras
        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbClientes_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
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
