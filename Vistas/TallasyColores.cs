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

namespace MultimodeSales.Vistas
{
    public partial class TallasyColores : Form
    {
        CColoresyTallas colorytallas = new CColoresyTallas();
        private int MX;
        private int MY;

        public TallasyColores()
        {
            InitializeComponent();
            CargarColores();
            CargarTallas();
        }

        public void CargarColores()
        {
            dgvColores.DataSource = null;
            DataTable dt = colorytallas.VerColores();
            dgvColores.DataSource = dt;
            dgvColores.Columns[0].Visible = false;
        }
        public void CargarTallas()
        {
            dgvTallas.DataSource = null;
            DataTable dt = colorytallas.VerTallas();
            dgvTallas.DataSource = dt;
            dgvTallas.Columns[0].Visible = false;
        }


        #region Panel Barras
        private void lbColoresyTallas_MouseMove(object sender, MouseEventArgs e)
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
        #endregion
        #region Colores
        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtColor.Text))
            {
                colorytallas.EditarColoresyTallas(1, 1, 0, txtColor.Text);
                CargarColores();
                BorrarSelectColor();
            }
            else
                MessageBox.Show("No se puede agregar un campo vacio", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnEditarColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtTalla.Text))
                {
                    colorytallas.EditarColoresyTallas(1, 2, int.Parse(txtColor.Tag + ""), txtColor.Text);
                    btnEditarColor.Enabled = false;
                    btnAgregarColor.Enabled = true;
                    btnEliminarColor.Enabled = true;
                    btnCancelarColor.Visible = false;
                    CargarColores();
                    BorrarSelectColor();
                }
                else
                    MessageBox.Show("No se puede editar un campo vacio", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("No se puede editar sin seleccionar nada", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarColor_Click(object sender, EventArgs e)
        {
            if(dgvColores.Rows.Count != 0)
            { 
                colorytallas.EditarColoresyTallas(1, 3, int.Parse(dgvColores.CurrentRow.Cells[0].Value + ""), txtColor.Text);
                CargarColores();
                BorrarSelectColor();
            }
            else
                MessageBox.Show("No se puede eliminar sin seleccionar nada", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelarColor_Click(object sender, EventArgs e)
        {
            btnAgregarColor.Enabled = true;
            btnEliminarColor.Enabled = true;
            btnEditarColor.Enabled = false;
            btnCancelarColor.Visible = false;
            BorrarSelectColor();
        }
        private void dgvColores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtColor.Tag = dgvColores.CurrentRow.Cells[0].Value + "";
            txtColor.Text = dgvColores.CurrentRow.Cells[1].Value + "";
            btnAgregarColor.Enabled = false;
            btnEditarColor.Enabled = true;
            btnEliminarColor.Enabled = false;
            btnCancelarColor.Visible = true;
        }
        #endregion
        #region Tallas
        private void btnAgregarTalla_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtTalla.Text))
            {
                colorytallas.EditarColoresyTallas(2, 1, 0, txtTalla.Text);
                CargarTallas();
                BorrarSelectTalla();
            }
            else
                MessageBox.Show("No se puede agregar un campo vacio", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEditarTalla_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtTalla.Text))
                {
                    colorytallas.EditarColoresyTallas(2, 2, int.Parse(txtTalla.Tag + ""), txtTalla.Text);
                    btnEditarTalla.Enabled = false;
                    btnEliminarTalla.Enabled = true;
                    btnAgregarTalla.Enabled = true;
                    btnCancelarTalla.Visible = false;
                    CargarTallas();
                    BorrarSelectTalla();
                }
                else
                    MessageBox.Show("No se puede editar un campo vacio", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("No se puede editar sin seleccionar nada", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarTalla_Click(object sender, EventArgs e)
        {
            if(dgvTallas.Rows.Count != 0)
            {
                colorytallas.EditarColoresyTallas(2, 3, int.Parse(dgvTallas.CurrentRow.Cells[0].Value + ""), txtTalla.Text);
                CargarTallas();
                BorrarSelectTalla();
            }
            else
                MessageBox.Show("No se puede eliminar sin seleccionar nada", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnCancelarTalla_Click(object sender, EventArgs e)
        {
            btnAgregarTalla.Enabled = true;
            btnEliminarTalla.Enabled = true;
            btnEditarTalla.Enabled = false;
            btnCancelarTalla.Visible = false;
            BorrarSelectTalla();
        }

        private void dgvTallas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTalla.Tag = dgvTallas.CurrentRow.Cells[0].Value + "";
            txtTalla.Text = dgvTallas.CurrentRow.Cells[1].Value + "";
            btnEliminarTalla.Enabled = false;
            btnAgregarTalla.Enabled = false;
            btnEditarTalla.Enabled = true;
            btnCancelarTalla.Visible = true;
        }
        #endregion

        private void BorrarSelectColor()
        {
            txtColor.Text = "";
            if(dgvColores.Rows.Count != 0)
                dgvColores.CurrentCell = dgvColores.Rows[0].Cells[1];
        }
        private void BorrarSelectTalla()
        {
            txtTalla.Text = "";
            if (dgvTallas.Rows.Count != 0)
                dgvTallas.CurrentCell = dgvTallas.Rows[0].Cells[1];
        }
    }
}
