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
        private int Rowindex;

        public Marca()
        {
            InitializeComponent();
            LlenarDataGridViewMarca();
        }

        private void LlenarDataGridViewMarca()
        {
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = marca.VerMarcas();
            dgvMarcas.Columns[1].Width = 250;
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

       
    }
}
