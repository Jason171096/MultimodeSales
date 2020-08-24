﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Excel
{
    public partial class ImportarPor : Form
    {
        public ImportarPor()
        {
            InitializeComponent();
        }

        private void btnImportarPrecios_Click(object sender, EventArgs e)
        {
            ImportarListaMarca importarLista = new ImportarListaMarca();
            importarLista.ShowDialog();
        }

        private void btnImportarPedidos_Click(object sender, EventArgs e)
        {
            ImportarPedidosFinal importarPedidos = new ImportarPedidosFinal();
            importarPedidos.ShowDialog();
        }
    }
}