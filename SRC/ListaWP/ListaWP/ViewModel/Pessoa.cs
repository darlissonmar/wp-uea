using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWP.ViewModel
{
    class Pessoa
    {
        private string _nome;

        private int _idade;
        
        private float _peso;

        private float _altura; // em metros, ex. 1,74 m

        public Pessoa( string nome, int idade, float peso, float altura) 
        {
            _nome = nome;
            _idade = idade;
            _peso = peso;
            _altura = altura;
        }

        public void Envelhecer()
        {
            _idade++;

            if (_idade <= 21) 
            {
                _altura = _altura + 0.05f; 
            }
        }

        public void Engordar( int kg)
        {
            _peso += kg;
        }

        public void Emagrecer( int kg)
        {
            _peso -= kg;
        }

        public void Crescer( int cent)
        {
            _altura = _altura + (cent / 100);
        }
    }
}
