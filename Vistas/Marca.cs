using MultimodeSales.Programacion;
using System;
using System.Data;
using System.Windows.Forms;
using MultimodeSales.Programacion.Marca;
using MultimodeSales.Programacion.Utilerias;

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
            dgvMarcas.Columns[0].HeaderText = "ID Marca";
            dgvMarcas.Columns[0].Width = 200;
            dgvMarcas.Columns[1].Width = 650;
        }
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombreMarca.Text) || String.IsNullOrWhiteSpace(txtIDMarca.Text))
                CMsgBox.DisplayWarning("No pueden estar los campos vacios de ID de Marca o Nombre");
            else
            {
                int cont = 0;
                for (int i = 0; i < dgvMarcas.Rows.Count; i++)
                {
                    if (txtIDMarca.Text == dgvMarcas.Rows[i].Cells[0].Value.ToString())
                        cont++;
                }
                if (cont >= 1)
                    CMsgBox.DisplayWarning("No pueden existir dos ID's iguales, intente con otro ID");
                else
                {
                    marca.AgregarMarca(txtIDMarca.Text, txtNombreMarca.Text);
                    CMsgBox.DisplayConfirmation("Se agrego nueva marca");
                    LlenarDataGridViewMarca();
                }
            }
        }
        private void btnEditarMarca_Click_1(object sender, EventArgs e)
        {
            int cont = 0;
            for (int i = 0; i < dgvMarcas.Rows.Count; i++)
            {
                if (txtIDMarca.Text == dgvMarcas.Rows[i].Cells[0].Value.ToString())
                    if (Rowindex != dgvMarcas.Rows[i].Index)
                        cont++;
            }
            if (cont >= 1)
                CMsgBox.DisplayWarning("No pueden existir dos marcas con ID's Iguales, intente con otro ID");
            else
            {
                btnAgregarMarca.Enabled = true;
                btnEditarMarca.Enabled = false;
                btnCancelar.Visible = false;
                marca.EditarMarca(txtIDMarca.Tag + "", txtIDMarca.Text, txtNombreMarca.Text);
                CMsgBox.DisplayInfo("Se edito la marca correctamente");
                BorrarDatos();
                LlenarDataGridViewMarca();
            }

        }
        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                btnAgregarMarca.Enabled = false;
                btnEditarMarca.Enabled = true;
                btnCancelar.Visible = true;
                txtIDMarca.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                txtNombreMarca.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
                txtIDMarca.Tag = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                Rowindex = e.RowIndex;
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Convert(IDMarca, 'System.String') LIKE '%{0}%' OR Nombre LIKE '%{0}%'", txtBuscar.Text);
            dgvMarcas.DataSource = dv;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BorrarDatos();
            btnAgregarMarca.Enabled = true;
            btnEditarMarca.Enabled = false;
            btnCancelar.Visible = false;
        }
        private void BorrarDatos()
        {
            txtIDMarca.Text = "";
            txtNombreMarca.Text = "";
        }
        #region Validaciones
        private void txtNumeroMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetrasyNumeros(sender, e);
        }
        #endregion
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
