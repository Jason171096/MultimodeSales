using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion.Cliente
{
    class ClienteDB
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public DataTable VerClientes()
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerClientes", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }
        public void AgregarCliente(string idcliente, string nombre)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarCliente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            cmd.Parameters.Add(new MySqlParameter("nombre", nombre));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se edito el cliente correctamente", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Connection.Close();
        }
        public void EditarCliente(string idclienteActual, string idcliente, string nombre)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("EditarCliente", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("idclienteActual", idclienteActual));
            cmd.Parameters.Add(new MySqlParameter("idcliente", idcliente));
            cmd.Parameters.Add(new MySqlParameter("nombre", nombre));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se edito el cliente correctamente", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Connection.Close();
        }
    }
}
