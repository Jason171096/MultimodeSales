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
using System.Security.Cryptography.X509Certificates;

namespace MultimodeSales.Vistas
{
    public partial class Marca : Form
    {
        MarcaBD marca = new MarcaBD();
        Validaciones validacion = new Validaciones();

        public Marca()
        {
            InitializeComponent();
            LlenarDataGridViewMarca();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNombreMarca.Text) || String.IsNullOrWhiteSpace(txtNumeroMarca.Text))
                MessageBox.Show("No pueden estar los campos vacios de Numero de Marca o Nombre Marca", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                marca.AgregarMarca(txtNumeroMarca.Text, txtNombreMarca.Text);
                LlenarDataGridViewMarca();
            }
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {

        }

        private void LlenarDataGridViewMarca()
        {
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = marca.VerMarcas();
            dgvMarcas.Columns[1].Width = 165;
        }

        #region Validaciones
        private void txtNumeroMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }
        #endregion
    }
}
