using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultimodeSales.Vistas
{
    public partial class Devolucion : Form
    {
        private int MX;
        private int MY;
        public Devolucion()
        {
            InitializeComponent();
            Size = new Size(880, 475);
            btnCancelar.Location = new Point(11, 407);
            btnAceptar.Location = new Point(718, 407);
            mtDivider.Visible = false;
            gBoxCambio.Visible = false;
        }

        private void checkCambioModelo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCambioModelo.Checked)
            {
                Size = new Size(880, 705);
                btnCancelar.Location = new Point(17, 650);
                btnAceptar.Location = new Point(718, 650);
                mtDivider.Visible = true;
                gBoxCambio.Visible = true;
            }
            else
            {
                Size = new Size(880, 475);
                btnCancelar.Location = new Point(11, 407);
                btnAceptar.Location = new Point(718, 407);
                mtDivider.Visible = false;
                gBoxCambio.Visible = false;
            }
        }

        #region Panel Barras
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelBarras_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void lbDevolucion_MouseMove(object sender, MouseEventArgs e)
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
        #endregion
    }
}
