using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class RezervasyonClient
    {
        private ISoyutFabrika _soyutFabrika;
        private IKonaklama _konaklama;
        private IUlasim _ulasim;

        public RezervasyonClient(ISoyutFabrika soyutFabrika)
        {
            _soyutFabrika = soyutFabrika;
            _ulasim = _soyutFabrika.UlasimBilgisiYukle();
            _konaklama = _soyutFabrika.KonaklamaBilgisiYukle();
        }
    }
}
