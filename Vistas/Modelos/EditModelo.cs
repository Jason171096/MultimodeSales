using MultimodeSales.Programacion.Marca;
using MultimodeSales.Programacion.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Modelos
{
    public partial class EditModelo : Form
    {
        MarcaBD marca = new MarcaBD();
        ModelosDB modelo = new ModelosDB();
        private readonly bool Bandera;
        private int MX;
        private int MY;

        public EditModelo(bool agregar, string idmodelo, string idmarca, string color, string talla, string precioCliente)
        {
            InitializeComponent();
            this.Bandera = agregar;
            LlenarComboBoxMarca();
            if(agregar)
            {
                lb.Text = "Agregar Modelo";
                btnModelo.Text = "Agregar Modelo";
            }
            else
            {
                lb.Text = "Editar Modelo";
                btnModelo.Text = "Editar Modelo";
                txtIDModelo.Tag = idmodelo;
                txtIDModelo.Text = idmodelo;
                cobxMarca.SelectedValue = idmarca;
                txtColor.Text = color;
                txtTalla.Text = talla;
                txtPrecioCliente.Text = precioCliente;
            }
        }
        public void LlenarComboBoxMarca()
        {
            List<object[]> list = marca.VerMarcas2();
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("0", "--Elegir Marca--");
            foreach (object[] item in list)
            {
                keyValues.Add(item[0].ToString(), item[1].ToString());
            }
            cobxMarca.DataSource = new BindingSource(keyValues, null);
            cobxMarca.DisplayMember = "Value";
            cobxMarca.ValueMember = "Key";
        }
        private void btnModelo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIDModelo.Text) || !String.IsNullOrWhiteSpace(txtColor.Text)
                || !String.IsNullOrWhiteSpace(txtTalla.Text) || !String.IsNullOrWhiteSpace(txtPrecioPublico.Text))
            {
                if (cobxMarca.SelectedIndex != 0)
                    if (Bandera)
                        modelo.AgregarModelo(txtIDModelo.Text, cobxMarca.SelectedValue + "", txtColor.Text, txtTalla.Text, txtPrecioPublico.Text);
                    else
                        modelo.EditarModelo(txtIDModelo.Tag + "", txtIDModelo.Text, cobxMarca.SelectedValue + "", txtColor.Text, txtTalla.Text, txtPrecioCliente.Text);
                else
                    MessageBox.Show("Por favor de escoger la marca para el modelo", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Por favor de rellenar los espacios", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Panel Barras
        private void lb_MouseMove(object sender, MouseEventArgs e)
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
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        
    }
}
