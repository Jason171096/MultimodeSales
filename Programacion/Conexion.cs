using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultimodeSales.Programacion
{
    class Conexion
    {
        
        public string ConnectionString()
        {
            string conststring = "Server=localhost;Database=multimodesales;Uid=root;Pwd=''";
            return conststring;
        }

        public void ProbarConexion()
        {
            MySqlConnection con = new MySqlConnection(ConnectionString());
            con.Open();
            if (con.State == ConnectionState.Open)
                MessageBox.Show("Conexion existosa");
            else
                MessageBox.Show("Conexion fallida");
        }
        
    }
}
