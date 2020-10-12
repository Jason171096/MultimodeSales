using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion
{
    class CPedido
    {
        Conexion conexion = new Conexion();
        public void AgregarPedido(string idmodelo, string idcliente, string color, string talla)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarPedido", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idmodelo", idmodelo));
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            cmd.Parameters.Add(new MySqlParameter("color", color));
            cmd.Parameters.Add(new MySqlParameter("talla", talla));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
