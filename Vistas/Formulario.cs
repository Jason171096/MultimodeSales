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

namespace MultimodeSales
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }
        Conexion conexion = new Conexion();
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            conexion.OpenConection();
        }
    }
}
