﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace m16Proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botonUsuarios_Click(object sender, RoutedEventArgs e)
        {
            GestionarUsuarios gusuarios = new GestionarUsuarios();
            gusuarios.Show();
            
        }


        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuGestionUsuarios_Click(object sender, RoutedEventArgs e)
        {
            GestionarUsuarios gusuarios = new GestionarUsuarios();
            gusuarios.Show();
            
        }

        private void botonInventario_Click(object sender, RoutedEventArgs e)
        {

        }
<<<<<<< HEAD
=======

        private void botonFinanzas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonVentas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonCompras_Click(object sender, RoutedEventArgs e)
        {

        }

        private void botonProveedores_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonConectar_Click(object sender, RoutedEventArgs e)
        {
            Conexion.obtenerConexion();
            MessageBox.Show("LA CONEXION ESTA DE PUTA MADRE TIO ");
        }
>>>>>>> parent of a8e1b40... guardar
    }
}
