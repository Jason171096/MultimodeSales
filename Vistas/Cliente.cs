using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Cliente;
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
    public partial class Cliente : Form
    {
        ClienteDB cliente = new ClienteDB();
        CDataGridView CDataGrid = new CDataGridView();
        public Cliente()
        {
            InitializeComponent();
            CDataGrid.FormattingDataGridView(dgvClientes);
            LlenarDataGridView();
        }


        public void LlenarDataGridView()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = cliente.VerClientes();
            dgvClientes.Columns[1].Width = 300;
        }
    }
}
