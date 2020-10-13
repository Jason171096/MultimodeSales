using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion.Modelo
{
    class ModelosDB
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public DataTable ObtenerModelos()
        {
            conexion.OpenConnection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("VerModelos", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public void AgregarModelo(string idmodelo, string idmarca, string color, string talla, string preciocliente)
        {
            try
            {
                conexion.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("AgregarModelo", conexion.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("idmodelo", idmodelo));
                cmd.Parameters.Add(new MySqlParameter("idmarca", idmarca));
                cmd.Parameters.Add(new MySqlParameter("color", color));
                cmd.Parameters.Add(new MySqlParameter("talla", talla));
                cmd.Parameters.Add(new MySqlParameter("preciocliente", preciocliente));
                cmd.ExecuteNonQuery();
                conexion.CloseConnection();
            }
            catch
            {
                MessageBox.Show($"Error en subir el modelo {idmodelo} ya existe en la BASE de DATOS", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarModelo(string idmodeloActual, string idmodelo, string idmarca, string color, string talla, string preciocliente)
        {
            try
            {
                conexion.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("EditarModelo", conexion.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("idmodeloActual", idmodeloActual));
                cmd.Parameters.Add(new MySqlParameter("idmodelo", idmodelo));
                cmd.Parameters.Add(new MySqlParameter("idmarca", idmarca));
                cmd.Parameters.Add(new MySqlParameter("color", color));
                cmd.Parameters.Add(new MySqlParameter("talla", talla));
                cmd.Parameters.Add(new MySqlParameter("preciocliente", preciocliente));
                cmd.ExecuteNonQuery();
                conexion.CloseConnection();
            }
            catch
            {
                MessageBox.Show($"Error en subir el modelo {idmodelo} ya existe en la BASE de DATOS", "¡ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
