using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace m16Proyecto.mysql
{
    public class funciones
    {
        public static int agregar(usuario add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into usuarios(idUsuario, nombre, primerApellido, segundoApellido, dni, correo , telefono, direccion, ciudad, contraseña , categoria)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')"
                ,add.idUsuario,add.nombre,add.primerApellido,add.segundoApellido,
                add.dni,add.correo,add.telefono,add.direccion,add.ciudad,add.contraseña,add.categoria));
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
