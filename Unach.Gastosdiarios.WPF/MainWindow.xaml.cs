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
using Unach.Gastosdiarios.Logica;

namespace Unach.Gastosdiarios.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Gastos.GastosUC _gasto = new Gastos.GastosUC();
            ContenedorGrid.Children.Add(_gasto);
        }
    }
}
