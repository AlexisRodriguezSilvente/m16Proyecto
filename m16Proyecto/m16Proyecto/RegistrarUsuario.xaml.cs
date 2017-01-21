using m16Proyecto.mysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace m16Proyecto
{
    /// <summary>
    /// Interaction logic for RegistrarUsuario.xaml
    /// </summary>
    public partial class RegistrarUsuario : Window
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void botonRegistrar_Click(object sender, RoutedEventArgs e)
        {
            usuario agregar = new usuario();
            agregar.idUsuario = txtIdUsuario.Text();
            agregar.nombre = txtNombre.Text();
            agregar.primerApellido = txtPrimerApellido.Text();
            agregar.segundoApellido = txtSegundoApellido.Text();
            agregar.dni = txtDni.Text();
            agregar.correo = txtCorreo.Text();
            agregar.telefono = txtTelefono.Text();
            agregar.direccion = txtDireccion.Text();
            agregar.ciudad = txtCiudad.Text();
            agregar.contraseña = txtContraseña.Text();
            agregar.categoria = txtCategoria.Text();
            int retorno = funciones.agregar(agregar);
            if(retorno > 0)
            {
                MessageBox.Show("si que se ha agregado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
