using MultimodeSales.Programacion;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MultimodeSales
{
    class CVenta
    {
        Conexion conexion = new Conexion();
        
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

        public void ventaPedido(string pIDPedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VentaPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", pIDPedido));
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
