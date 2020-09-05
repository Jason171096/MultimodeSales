using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion.Excel
{
    class ExcelDB
    {
        Conexion conexion = new Conexion();
        public bool AgregarListaMarca(string marca, string modelo, string color, string talla, string precio)
        {
            conexion.OpenConnection();
            try
            {    
                MySqlCommand cmd = new MySqlCommand("AgregarListaMarca", conexion.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("idmarca", marca));
                cmd.Parameters.Add(new MySqlParameter("modelo", modelo));
                cmd.Parameters.Add(new MySqlParameter("color", color));
                cmd.Parameters.Add(new MySqlParameter("talla", talla));
                cmd.Parameters.Add(new MySqlParameter("precioCliente", precio));
                cmd.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch(Exception ex)
            {
                conexion.CloseConnection();
                return false;
            }
        }

        public bool AgregarPedidosFinal(string modelo, string idusuario)
        {
            conexion.OpenConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("AgregarPedidosFinal", conexion.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("modelo", modelo));
                cmd.Parameters.Add(new MySqlParameter("idusuario", idusuario));
                cmd.ExecuteNonQuery();
                conexion.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                conexion.CloseConnection();
                return false;
            }
        }
    }
}
