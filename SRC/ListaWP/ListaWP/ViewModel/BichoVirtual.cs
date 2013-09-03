using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWP.ViewModel
{
    class BichoVirtual
    {
   
        private string _nome;
   
        private int _fome; // 0 - 5
    
        private int _saude; // 0 - 5
    
        private int _idade;

        public BichoVirtual(string nome)
        {
            _nome = nome;
            _fome = 3;
            _idade = 0;
            _saude = 3;
        }

        public string Nome
        {
            get { return _nome;}
            set { _nome = value;}
        }
    
        public int Idade
        {
            get { return _idade;}
            set { _idade = value;}
        }

        public int Saude
        {
            get { return _saude; }
        }

        public int Fome
        {
            get { return _fome; }
        }

        public void AumentarSaude()
        {
            if( _saude < 5 )
            {
                _saude++;
            }
        }

        public void DiminuirSaude()
        {
            if( _saude > 0 )
            {
                _saude--;
            }
        }

        public void AumentarFome()
        {
            if ( _fome < 5 )
            {
                _fome++;
            }
        }

        public void DiminuirFome()
        {
            if ( _fome < 0 )
            {
                _fome++;
            }
        }
        public int GetHumor()
        {
            return (_fome + _saude) / 2;
        }
    
     }
}