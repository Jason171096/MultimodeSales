﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultimodeSales.Programacion;
using MultimodeSales.Vistas;

namespace MultimodeSales
{
    public partial class Formulario : Form
    {
        Conexion conexion = new Conexion();
        public Formulario()
        {
            InitializeComponent();
            #region Panel Visible
            panelCliente.Visible = false;
            panelImportExcel.Visible = false;
            #endregion
            #region Labels Visisble
            lbCliente.Visible = false;
            lbImportExcel.Visible = false;
            #endregion
        }
        #region picCliente
        private void picCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void picCliente_MouseEnter(object sender, EventArgs e)
        {
            panelCliente.Visible = true;
            lbCliente.Visible = true;
        }

        private void picCliente_MouseLeave(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
            lbCliente.Visible = false;
        }
        #endregion
        #region picImportExcel
        private void picImportExcel_Click(object sender, EventArgs e)
        {
            ImportarListaMarca importarListaMarca = new ImportarListaMarca();
            importarListaMarca.Show();
        }

        private void picImportExcel_MouseEnter(object sender, EventArgs e)
        {
            panelImportExcel.Visible = true;
            lbImportExcel.Visible = true;
        }

        private void picImportExcel_MouseLeave(object sender, EventArgs e)
        {
            panelImportExcel.Visible = false;
            lbImportExcel.Visible = false;
        }
        #endregion
    }
}
