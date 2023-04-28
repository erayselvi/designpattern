using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class Ucak_Cadir_Fabrikasi:ISoyutFabrika
    {
        private string ad;
        private string sad;
        private string tc;
        private DateTime gidistarihi;
        private DateTime donustarihi;
        private string nereden;
        private string nereye;
        private string sirketadi;
        public Ucak_Cadir_Fabrikasi(string ad, string sad, string tc, string nereden, string nereye, DateTime gidistarihi, DateTime donustarihi, string sirketadi)
        {

            this.ad = ad;
            this.sad = sad;
            this.tc = tc;
            this.nereden = nereden;
            this.nereye = nereye;
            this.sirketadi = sirketadi;
            this.gidistarihi = gidistarihi;
            this.donustarihi = donustarihi;
        }
        public IUlasim UlasimBilgisiYukle()
        {
            return new Ucak(this.ad, this.sad, this.tc, this.nereden, this.nereye, this.gidistarihi, this.donustarihi, this.sirketadi);
        }
        public IKonaklama KonaklamaBilgisiYukle()
        {
            return new Cadir(this.ad, this.sad, this.tc, this.nereye, this.gidistarihi, this.donustarihi);
        }
    }
}
