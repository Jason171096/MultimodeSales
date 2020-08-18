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
        public void AgregarListaMarca(string marca, string modelo, string precio)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarListaMarca", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("marca", marca));
            cmd.Parameters.Add(new MySqlParameter("modelo", modelo));
            cmd.Parameters.Add(new MySqlParameter("precioCliente", precio));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
