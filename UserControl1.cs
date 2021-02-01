using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultimodeSales.Programacion.Cliente;

namespace MultimodeSales
{
    public partial class UserControl1 : UserControl
    {
        CClienteDB cliente = new CClienteDB();
        public UserControl1()
        {
            InitializeComponent();
            cargarClientes();
        }
        private void cargarClientes()
        {
            DataTable dt = cliente.VerClientes();
            cboxCliente.DisplayMember = "Nombre";
            cboxCliente.ValueMember = "IDCliente";
            dt.Rows.Add(0, "--Seleccione el cliente--");
            cboxCliente.DataSource = dt;
            cboxCliente.SelectedIndex = cboxCliente.Items.Count - 1;
        }
    }
}
