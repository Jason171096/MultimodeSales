﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion.Modelo
{
    public class Modelo
    {
        private string iDModelo;
        public string IDMarca;
        public string Color;
        public string Talla;
        public string PrecioCliente;

        public string IDModelo { get => iDModelo; set => iDModelo = value; }

        //public Modelo(string pIDModelo, string pIDMarca, string pColor, string pTalla, string pPrecioCliente)
        //{
        //    IDModelo = pIDModelo;
        //    IDMarca = pIDMarca;
        //    Color = pColor;
        //    Talla = pTalla;
        //    PrecioCliente = pPrecioCliente;
        //}
    }
}
