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
        //Problems with Stored Procedure
        public void UpdatePedidoLlego(string idcliente, string idmodelo)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ActualizarPedidoFinal", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idmodelo", idmodelo));
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
        }
        //
        public void UpdatePedidoLlego2(string idpedido)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion.GetConnection();
            cmd.CommandText = $"UPDATE pedidos SET Llego = 1 WHERE IDPedido = {idpedido}";
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
