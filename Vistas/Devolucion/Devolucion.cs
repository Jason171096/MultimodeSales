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
    public partial class Devolucion : Form
    {

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
    }
}
