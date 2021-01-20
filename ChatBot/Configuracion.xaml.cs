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
        List<String> sexo;
        public string FondoColor { get; set; }
        public string UserColor { get; set; }
        public string RobotColor { get; set; }
        public string Sexo { get; set; }

        public Configuracion()
        {
            
            InitializeComponent();
            this.DataContext = this;
            sexo = new List<string>() {"Hombre","Mujer" };
            sexo_ComboBox.ItemsSource = sexo;
            fondoColors_ComboBox.ItemsSource = typeof(Colors).GetProperties();
            userColors_ComboBox.ItemsSource = typeof(Colors).GetProperties();
            robotColors_ComboBox.ItemsSource = typeof(Colors).GetProperties();
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
