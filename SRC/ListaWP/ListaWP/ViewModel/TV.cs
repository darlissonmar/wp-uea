using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaWP.ViewModel
{
    class TV
    {
        private int _canal; // entre 1 e 99

        private int _numCanais;

        private bool _ligada;

        private int _volume;
        
        private int _maxVolume;


        public TV( int numCanais, int maxVolume) 
        {
            _numCanais = numCanais;
            _maxVolume = maxVolume;
            _ligada = false;
            _canal = 1;
            _volume = 0;
        }

        public void ApertarBotaoPower()
        { 
            if (_ligada)
            {
                _ligada = false;
            }
            else
            {
                _ligada = true;
            }
        }

        public void AumentarCanal()
        {
            if ( _ligada && _canal < _numCanais) 
            {
                _canal++;
            }
        }

        public void DiminuirCanal() 
        {
            if (_ligada && _canal > 1)
            {
                _canal--;
            }
        }

        public void AumentarVolume()
        {
            if ( _ligada && _volume < _maxVolume )
            {
                _volume++;
            }
        }

        public void DiminuirVolume()
        {
            if ( _ligada && _volume > 0 )
            {
                _volume--;
            }
        }
     }
}
