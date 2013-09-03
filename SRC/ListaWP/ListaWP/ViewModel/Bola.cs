using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ListaWP
{
    public class Bola : INotifyPropertyChanged
    {
        private event PropertyChangedEventHandler PropertyChanged;

        public Bola(string cor) 
        {
            _cor = cor;
        }

        private string _cor;
        public string Cor
        {
            get { return _cor; }
            set {
                    if (value != _cor)
                        {
                            _cor = value;
                            OnPropertyChanged("Cor");
                        }
                }
        }

        private int _cirunferencia;
        private string _material;
        

         
       public void OnPropertyChanged(string propertyName)
       {
           var propertyChanged = PropertyChanged;
           if (propertyChanged != null)
               {
                    propertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
        }
    }
}