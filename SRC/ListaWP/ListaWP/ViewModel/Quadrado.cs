using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWP.ViewModel
{
    class Quadrado
    {
        private int _lado;

        public Quadrado(int lado) 
        {
            _lado = lado;
        }

        public int Lado
        {
            get { return _lado; }
            set { _lado = value;}
        }

        public int GetArea()
        {
            return _lado * _lado;
        }

    }
}
