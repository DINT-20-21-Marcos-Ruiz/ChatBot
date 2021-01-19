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

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public Configuracion()
        {
            
            InitializeComponent();
            this.DataContext = this;
            fondoColors_ComboBox.ItemsSource = typeof(Colors).GetProperties();
            userColors_ComboBox.ItemsSource = typeof(Colors).GetProperties();
            robotColors_ComboBox.ItemsSource = typeof(Colors).GetProperties();
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
