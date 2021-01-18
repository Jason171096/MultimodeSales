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
        
        public void ventaPedido(string pIDFolio, DateTime pFecha, double pTotal)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VentaPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idfolio", pIDFolio));
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
    }
}
