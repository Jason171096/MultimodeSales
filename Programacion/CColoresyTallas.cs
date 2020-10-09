using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimodeSales.Programacion
{
    class CColoresyTallas
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public DataTable VerColores()
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerColores", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public DataTable VerTallas()
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerTallas", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public void EditarColoresyTallas(int value, int opcion, int id, string number_name)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("ColoresyTallas", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("valor", value));
            cmd.Parameters.Add(new MySqlParameter("opcion", opcion));
            cmd.Parameters.Add(new MySqlParameter("id", id));
            cmd.Parameters.Add(new MySqlParameter("nn", number_name));
            cmd.ExecuteNonQuery();
            conexion.CloseConnection();
        }
    }
}
