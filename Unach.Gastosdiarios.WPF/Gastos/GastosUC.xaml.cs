using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Unach.Gastosdiarios.Conexion;

namespace Unach.Gastosdiarios.WPF.Gastos
{
    /// <summary>
    /// Lógica de interacción para GastosUC.xaml
    /// </summary>
    public partial class GastosUC : UserControl
    {
        public GastosUC()
        {
            InitializeComponent();
            Unach.Gastosdiarios.Logica.GastoMetodos metodos = 
                new Logica.GastoMetodos();
            CategoriasCB.ItemsSource = metodos.ObtenerCategorias();

        }

        private void CategoriasCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var categoriaSeleccionada = (Categoria)CategoriasCB.SelectedItem;
            MessageBox.Show(categoriaSeleccionada.Descripcion);
        }

        private void AgregarBT_Click(object sender, RoutedEventArgs e)
        {
            NuevoGastoWindow nuevo = new NuevoGastoWindow();
            nuevo.ShowDialog();
        }
    }
}
