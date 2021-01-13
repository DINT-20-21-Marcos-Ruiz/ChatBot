﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Mensaje> mensajes;
        public MainWindow()
        {
            InitializeComponent();
            mensajes = new ObservableCollection<Mensaje>();
            mensajes.Add(new Mensaje("Lo siento, estoy un poco cansado para hablar.", Emisor.Robot));
            mensajes.Add(new Mensaje("Lo siento, estoy un poco cansado para hablar.", Emisor.Usuario));
            mensajesListBox.DataContext = mensajes;
        }

        //SALIR
        private void CommandBindingSalir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Windows[0].Close();
        }

        //CONEXIÓN
        private void CommandBindingConexion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexión correcta con el servidor del Bot", "Comprobar conexión", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //GUARDAR
        private void CommandBindingGuardar_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.txt|*.txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog.ShowDialog() == true)
                 File.WriteAllText(saveFileDialog.FileName, mensajesListBox.ToString());
        }
        private void CommandBindingGuardar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(mensajesListBox != null)
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        //NUEVA CONVERSACIÓN
        private void CommandBindingNueva_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            for (int i = 0; i < mensajes.Count; i++)
            {
                mensajes.RemoveAt(i);
            }
        }
        private void CommandBindingNueva_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (mensajesListBox != null)
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        //ENVIAR
        private void CommandBindingEnviar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mensajes.Add(new Mensaje(mensaje_TextBox.Text,Emisor.Usuario));
            mensajes.Add(new Mensaje("Lo siento, estoy un poco cansado para hablar.", Emisor.Robot));

        }
        private void CommandBindingEnviar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            /*if(mensaje_TextBox.Text == "")
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }*/
            e.CanExecute = false;
        }

        //CONFIGURACIÓN
        private void CommandBindingConfig_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }
        private void CommandBindingConfig_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        { 
            e.CanExecute = false;
        }

    }

    
}