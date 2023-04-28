using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    public interface IUlasim
    {
        string UlasimTarihiGonder();
        string UlasimGidisDonusGonder();
        string UlasimSirketGonder();

        void SqlKaydet();
    }
}
