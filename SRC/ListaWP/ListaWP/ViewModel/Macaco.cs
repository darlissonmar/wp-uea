using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWP.ViewModel
{
    class Macaco
    {
        private string _nome;

        private List<string> _bucho;

        public string Nome 
        {
            get { return _nome; }
            set { _nome = value;}
        }

        public void Comer( string alimento )
        {
            _bucho.Add(alimento);
        }

        public List<string> VerBucho
        {
            get { return _bucho;}
        }

        public void Digerir()
        {
            _bucho.Clear();
        }
    }
}
