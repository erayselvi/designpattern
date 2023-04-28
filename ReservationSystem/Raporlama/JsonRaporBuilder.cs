using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class JsonRaporBuilder:RaporBuilder
    {
       public JsonRaporBuilder(RaporBilgileri rezBilgi):base(rezBilgi)
        {

        }

        public override string BuildHeaderGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ [");
            return sb.ToString();
        }
        public override string BuildFooterGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("]  }");
            return sb.ToString();

        }

        public override string BuildIcerikKisiselGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} {1} ", this.RezervasyonBilgiler.ad, this.RezervasyonBilgiler.soyad));
            return sb.ToString();
        }

        public override string BuildIcerikUlasimGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" {0}{1}{2}{3}{4}  ", this.RezervasyonBilgiler.ulasimturu, this.RezervasyonBilgiler.ulasimucreti, this.RezervasyonBilgiler.kalkis, this.RezervasyonBilgiler.varis, this.RezervasyonBilgiler.sirketad, this.RezervasyonBilgiler.gidistarih, this.RezervasyonBilgiler.donustarih));
            return sb.ToString();
        }

        public override string BuildIcerikKonaklamaGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(" {0} {1} {2} {3}", this.RezervasyonBilgiler.konaklamaturu, this.RezervasyonBilgiler.konaklamaucreti, this.RezervasyonBilgiler.gidistarih, this.RezervasyonBilgiler.donustarih));
            return sb.ToString();
        }
    }
}
