﻿using MultimodeSales.Programacion;
using System;
using System.Drawing;
using System.Windows.Forms;
using MultimodeSales.Programacion.Utilerias;

namespace MultimodeSales.Vistas.Ventas
{
    public partial class DialogVenta : Form
    {
        CVenta venta = new CVenta();
        Validaciones validaciones = new Validaciones();
        
        string total, idfolio;
        public DialogVenta(string pTotal, string pIDFolio)
        {
            InitializeComponent();
            total = pTotal;
            idfolio = pIDFolio;
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void DialogVenta_Load(object sender, EventArgs e)
        {
            lbTotal.Text = total;
            lbCambio.Text = "$0.00";
            //txtCantidad.Text = "$0.00";
            lbCambio.ForeColor = Color.Red;
            txtCantidad.Focus();
            txtCantidad.SelectAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //float floatCantidad = float.Parse(txtCantidad.Text.Replace("$", ""));
        //txtCantidad.Text = string.Format("{0:C}", floatCantidad);

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloDecimales(sender, e);
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            calcularCambio();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            calcularCambio();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (lbCambio.ForeColor != Color.Red)
            {
                venta.ventaPedido(idfolio, DateTime.Now, Convert.ToDouble(total.Trim('$')));
                CMsgBox.DisplayInfo("Venta concluida");
            }
            else
                CMsgBox.DisplayWarning("Ingrese una cantidad");
        }

        private void calcularCambio()
        {
            if (!String.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                double doubleTotal = Double.Parse(total.Replace("$", ""));
                double doubleCantidad = Double.Parse(txtCantidad.Text);
                if (doubleTotal <= doubleCantidad)
                {
                    lbCambio.ForeColor = Color.Black;
                    btnVender.Enabled = true;
                    lbCambio.Text = string.Format("{0:C}", doubleCantidad - doubleTotal);
                }
                else
                {
                    lbCambio.ForeColor = Color.Red;
                    btnVender.Enabled = false;
                    lbCambio.Text = "$0.00";
                }
            }
        }
    }
}
