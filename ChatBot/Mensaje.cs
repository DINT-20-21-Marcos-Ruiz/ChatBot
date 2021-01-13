using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    enum Emisor 
    {
        Usuario,
        Robot
    }
    class Mensaje : INotifyPropertyChanged
    {
        private string texto;
        private Emisor emisor;


        public string Texto
        {
            get { return texto; }
            set
            {
                if (texto != value)
                {
                    texto = value;
                    NotifyPropertyChanged("Texto");
                }
            }
        }

        public Emisor Emisor
        {
            get { return emisor; }
            set
            {
                if (emisor != value)
                {
                    emisor = value;
                    NotifyPropertyChanged("Emisor");
                }
            }
        }

        public Mensaje()
        {

        }

        public Mensaje(string texto, Emisor emisor)
        {
            this.texto = texto;
            this.emisor = emisor;
        }


        //NOTIFY
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
