using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    abstract class RaporBuilder
    {
        protected RaporBilgileri RezervasyonBilgiler;

        public RaporBuilder(RaporBilgileri rezBilgi)
        {
            this.RezervasyonBilgiler = rezBilgi;
        }

        public string BuildCikti()//Builder yapısına uygun bir şekilde içerik içerisindekilerin yerleri değişebiliyor
        {
            string cikti = BuildHeaderGetir();
            cikti += BuildIcerikKisiselGetir();
            cikti += BuildIcerikUlasimGetir();
            cikti += BuildIcerikKonaklamaGetir();
            cikti += BuildFooterGetir();
            return cikti;
        }
        public abstract string BuildHeaderGetir();
        public abstract string BuildIcerikKisiselGetir();
        public abstract string BuildIcerikUlasimGetir();
        public abstract string BuildIcerikKonaklamaGetir();
        public abstract string BuildFooterGetir();
    }
}
