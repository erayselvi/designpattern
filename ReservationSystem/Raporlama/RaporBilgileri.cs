using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    //string ad,string sad,string gidisyer,string donusyer,string gidistarih,string donustarih,string konaktip,string konakucret,string ulasimtip,string ulasimucret
    public class RaporBilgileri
    {
        public string ad;
        public string soyad;
        public string kalkis;
        public string varis;
        public string gidistarih;
        public string donustarih;
        public string konaklamaturu;
        public string konaklamaucreti;
        public string ulasimturu;
        public string ulasimucreti;
        public string sirketad;

        public RaporBilgileri(string ad, string sad, string kalkis, string varis, string gidistarih, string donustarih, string konaktip, string konakucret, string ulasimtip, string ulasimucret, string sirketad)
        {
            this.ad = ad;
            this.soyad = sad;
            this.kalkis = kalkis;
            this.varis = varis;
            this.gidistarih = gidistarih;
            this.donustarih = donustarih;
            this.konaklamaturu = konaktip;
            this.konaklamaucreti = konakucret;
            this.ulasimturu = ulasimtip;
            this.ulasimucreti = ulasimucret;
            this.sirketad = sirketad;
        }
    }
}
