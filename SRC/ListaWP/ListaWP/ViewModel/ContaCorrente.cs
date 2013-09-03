using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWP.ViewModel
{

    class ContaCorrente
    {
        private int _numero;

        private string _correntista;

        private float _saldo;

        // public ContaCorrente( string nome, int numero, float saldo = 0.0f) like python???
        public ContaCorrente( string nome, int numero, float saldo)
        {
            _correntista = nome;
            _numero = numero;
            _saldo = saldo;
        }

        public ContaCorrente(string nome, int numero)
        {
            _correntista = nome;
            _numero = numero;
            _saldo = 0.0f;
        }

        public string Correntista
        {
            get { return _correntista; }
            set { _correntista = value; }
        }

        public void Depositar( float valor )
        {
            _saldo += valor;
        }

        public void Sacar(int valor)
        {
            _saldo -= valor;
        }
        
    }
}
