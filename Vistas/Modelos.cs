using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultimodeSales.Programacion.Modelo;

namespace MultimodeSales.Vistas
{
    public partial class Modelos : Form
    {
        ModelosDB modelos = new ModelosDB();
        public Modelos()
        {
            InitializeComponent();
            CargarModelos();
        }

        private void CargarModelos()
        {
            DataTable dt;
            dt = modelos.ObtenerModelos();
            dgvModelos.DataSource = dt;
        }
    }
}
