using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m16Proyecto.mysql
{
    public class usuario
    {
        public string idUsuario { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string dni { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string contraseña { get; set; }
        public string categoria { get; set; }
        public usuario() { }

        public usuario(string idUsuario, string nombre, string primerApellido, string segundoApellido,
                       string dni, string correo, string telefono, string direccion,
                       string ciudad, string contraseña, string categoria)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.dni = dni;
            this.correo = correo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.contraseña = contraseña;
            this.categoria = categoria;

        }
    }
}
