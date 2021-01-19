using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatBot
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Salir = new RoutedUICommand(
            "Salir",
            "Salir",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.S,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand ComprobarConexion = new RoutedUICommand(
            "ComprobarConexion",
            "ComprobarConexion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.O,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand GuardarConv = new RoutedUICommand(
            "GuardarConv",
            "GuardarConv",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.G,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand NuevaConv = new RoutedUICommand(
            "NuevaConv",
            "NuevaConv",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.N,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand Enviar = new RoutedUICommand(
            "Enviar",
            "Enviar",
            typeof(CustomCommands)
            );
        public static readonly RoutedUICommand Config = new RoutedUICommand(
            "Config",
            "Config",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.C,ModifierKeys.Control)
            }
            );
    }
}
