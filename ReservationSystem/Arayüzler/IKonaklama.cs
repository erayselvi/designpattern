using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public interface IKonaklama
    {
        string KonaklamaTarihiGonder();
        string KonaklamaGidisDonusGonder();
        string KonaklamaSirketGonder();

        void SqlKaydet();
    }
}
