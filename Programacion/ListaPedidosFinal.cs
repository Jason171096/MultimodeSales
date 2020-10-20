using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion
{
    class ListaPedidosFinal
    {
        Conexion conexion = new Conexion();
        public DataTable ObtenerListaPedidosFinal()
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerListaPedidoFinal", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            conexion.CloseConnection();
            return dt;
        }
        public void UpdatePedidoLlego(string idpedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ActualizarPedidoFinal", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idpedido", idpedido));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
