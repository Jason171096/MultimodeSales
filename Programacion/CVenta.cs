﻿using MultimodeSales.Programacion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MultimodeSales.Programacion.Modelo;

namespace MultimodeSales
{
    public class CVenta
    {
        private string idVenta;

        public string IDVenta { get => idVenta; set => idVenta = value; }
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();

        public void ventaFolio(string pIDFolio, string pIDCliente, DateTime pFecha, double pTotal)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VentaFolio", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            cmd.Parameters.Add(new MySqlParameter("idcliente", pIDCliente));
            cmd.Parameters.Add(new MySqlParameter("fecha", pFecha));
            cmd.Parameters.Add(new MySqlParameter("total", pTotal));
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public int verificarFolioExistente(string pIDFolio)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("FolioExistente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            object existeFolio = cmd.ExecuteScalar();
            cmd.Connection.Close();
            if (Convert.ToInt32(existeFolio) == 1)
                return 1;
            return 0;
        }

        public void ventaPedido(string pIDFolio, string pIDPedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VentaPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public DataTable verVentaPedidoModelo(string pIDFolio)
        {
            DataTable dt = new DataTable();
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerVentaPedidoModelo", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
    }
}
