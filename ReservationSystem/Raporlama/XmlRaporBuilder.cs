using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystem
{
    class XmlRaporBuilder : RaporBuilder
    {
        public XmlRaporBuilder(RaporBilgileri rezBilgi):base(rezBilgi)
        { 
        }
        public override string BuildHeaderGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<XMLRapor>");
            return sb.ToString();
        }

        public override string BuildFooterGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("</XMLRapor>");
            return sb.ToString();
        }

        public override string BuildIcerikKisiselGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<Kisisel><RezervasyonAd> {0} </RezervasyonAd> <RezervasyonSoyad> {1} </RezervasyonSoyad> </Kisisel>", this.RezervasyonBilgiler.ad, this.RezervasyonBilgiler.soyad));
            return sb.ToString();
        }

        public override string BuildIcerikUlasimGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<Ulasim> <UlasimTuru> {0} </UlasimTuru> <UlasimUcret> {1} </UlasimUcret> <KalkisYeri> {2} </KalkisYeri> <VarisYeri> {3} </VarisYeri> <Sirket> {4} </Sirket> <GidisTarih> {5} </GidisTarih> <DonusTarih> {6} </DonusTarih> </Ulasim>", this.RezervasyonBilgiler.ulasimturu, this.RezervasyonBilgiler.ulasimucreti, this.RezervasyonBilgiler.kalkis, this.RezervasyonBilgiler.varis, this.RezervasyonBilgiler.sirketad, this.RezervasyonBilgiler.gidistarih, this.RezervasyonBilgiler.donustarih));
            return sb.ToString();
        }

        public override string BuildIcerikKonaklamaGetir()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<Konaklama> <KonaklamaTuru> {0} </KonaklamaTuru> <KonaklamaUcret> {1} </KonaklamaUcret> <KonaklamaGirisTarih> {2} </KonaklamaGirisTarih> <KonaklamaCikisTarih> {3} </KonaklamaCikisTarih> </Konaklama>", this.RezervasyonBilgiler.konaklamaturu, this.RezervasyonBilgiler.konaklamaucreti, this.RezervasyonBilgiler.gidistarih, this.RezervasyonBilgiler.donustarih));
            return sb.ToString();
        }
    }
}
