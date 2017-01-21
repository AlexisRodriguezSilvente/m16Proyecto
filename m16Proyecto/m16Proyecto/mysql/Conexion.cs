using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace m16Proyecto.mysql
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection Conexion = new MySqlConnection("server=localhost;database=pruebausuarios;Uid=root;pwd=4fr0d1t4.");
            Conexion.Open();
            return Conexion;
#pragma warning disable CS0162 // Unreachable code detected
            Conexion.Close();
#pragma warning restore CS0162 // Unreachable code detected
        }
    }
}
