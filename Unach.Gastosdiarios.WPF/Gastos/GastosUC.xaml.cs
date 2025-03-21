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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            CategoriasCB.ItemsSource = metodos.ObtenerCategias();
        }
    }
}
