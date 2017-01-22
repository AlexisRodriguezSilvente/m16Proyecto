using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Security.Cryptography;

namespace m16Proyecto.mysql
{
    class Conexion
    {
        // Singletone
        protected static Conexion _instance = null;

        public static Conexion instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Conexion();
                return _instance;
            }
        }
        //Atributos
        protected string connStr;
        protected MySqlConnection connection = null;
        protected string serverName = "127.0.0.1";
        protected string serverUser = "root";
        protected string database = "pruebausuarios";
        protected string password = "4fr0d1t4.";
        protected uint serverPort = 3306;

        protected Conexion()
        {
            // Create connection to MySql database
            connStr = "server=" + serverName + "; user=" + serverUser + ";database=" + database + ";port=" + serverPort + ";password=" + password + ";";
            connection = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                connection.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Done.");
        }

        //        public static MySqlConnection obtenerConexion()
        //        {
        //            MySqlConnection Conexion = new MySqlConnection("server=localhost;database=pruebausuarios;Uid=root;pwd=4fr0d1t4.");
        //            Conexion.Open();
        //            return Conexion;
        //#pragma warning disable CS0162 // Unreachable code detected
        //            Conexion.Close();
        //#pragma warning restore CS0162 // Unreachable code detected
        //        }
    }
}
