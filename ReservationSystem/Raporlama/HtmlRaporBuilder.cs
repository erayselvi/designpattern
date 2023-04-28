using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class HtmlRaporBuilder:RaporBuilder
    {
        public HtmlRaporBuilder(RaporBilgileri rezBilgi):base(rezBilgi)
        {

        }
        public override string BuildHeaderGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body>");
            return sb.ToString();
            
        }
        public override string BuildFooterGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("</body></html>");
            return sb.ToString();
        }

        public override string BuildIcerikKisiselGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<h1>Seyahat Rapor </h1><br>Ad Soyad:{0} {1}</br>", this.RezervasyonBilgiler.ad, this.RezervasyonBilgiler.soyad));
            return sb.ToString();
        }

        public override string BuildIcerikUlasimGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<h1>Ulasim Turu: {0}</h1>   Ücret:{1}  Nereden-Nereye:{2}/{3} Sirket:{4}  ", this.RezervasyonBilgiler.ulasimturu, this.RezervasyonBilgiler.ulasimucreti, this.RezervasyonBilgiler.kalkis, this.RezervasyonBilgiler.varis, this.RezervasyonBilgiler.sirketad));
            return sb.ToString();
        }

        public override string BuildIcerikKonaklamaGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<h1>Konaklama: {0} </h1>  Ucreti: {1} Konaklama Giris:{2} Konaklama Çıkış:{3}</h1>", this.RezervasyonBilgiler.konaklamaturu, this.RezervasyonBilgiler.konaklamaucreti, this.RezervasyonBilgiler.gidistarih, this.RezervasyonBilgiler.donustarih));
            return sb.ToString();
        }
    }
}
