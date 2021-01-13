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
            MessageBox.Show("Venta concluida", "¡Exito!", MessageBoxButton.OK, MessageBoxImage.Information);
            cmd.Connection.Close();
        }
    }
}
