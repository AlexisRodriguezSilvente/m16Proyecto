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
    /// Interaction logic for GestionarUsuarios.xaml
    /// </summary>
    public partial class GestionarUsuarios : Window
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
        }


        private void botonAgregar_Click(object sender, RoutedEventArgs e)
        {
            RegistrarUsuario register = new RegistrarUsuario();
            register.Show();
        }

        private void botonEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonConsultar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
