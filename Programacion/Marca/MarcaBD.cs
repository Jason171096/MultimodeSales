﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Programacion.Marca
{
    class MarcaBD
    {
        Conexion conexion = new Conexion();
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        public DataTable VerMarcas()
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("VerMarcas", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            conexion.CloseConnection();
            return dt;
        }

        public void AgregarMarca(string numeromarca, string nombremarca)
        {
            conexion.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("AgregarMarca", conexion.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("numero", numeromarca));
            cmd.Parameters.Add(new MySqlParameter("nombre", nombremarca));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se agrego nueva marca", "¡EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Connection.Close();
        }
        
    }
}
