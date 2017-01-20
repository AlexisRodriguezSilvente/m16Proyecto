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
            MySqlConnection Conexion = new MySqlConnection("server=127.0.0.1;database=pruebalogin;Uid=root;pwd=4fr0dt4.");
            Conexion.Open();
            return Conexion;
        }
    }
}
