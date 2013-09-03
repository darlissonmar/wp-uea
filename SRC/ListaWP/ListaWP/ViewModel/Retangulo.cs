using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWP.ViewModel
{
    class Retangulo
    {
        private int _base;

        private int _altura;

        public Retangulo( int bs, int altura) 
        {
            _altura = altura;
            _base = bs;
        }

        public int Base
        {
            get { return _base;}
            set { _base = value;}
        }

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public int GetArea()
        {
            return _base * _altura; 
        }

        public int GetPerimetro() 
        {
            return (2 * (_base + _altura));
        }
    }
}
