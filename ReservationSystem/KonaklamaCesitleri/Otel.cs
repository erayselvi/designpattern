using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ReservationSystem
{
    class Otel:IKonaklama
    { 
        private string ad;
        private string sad;
        private string tc;
        private string konaklama; //Konaklama yapılan yer
        private DateTime giristarihi; //konaklamadan çıkış tarihi
        private DateTime cikistarihi;
        private string ucret;
        private string konaklamatipi;
     
        public Otel(string ad,string sad,string tc,string nereye,DateTime gidistarihi,DateTime donustarihi)
        {
            
            this.ad = ad;
            this.sad = sad;
            this.tc = tc;
            this.konaklama = "Palas Otel"; // gidilecek otel adı gidilecek ildeki il + otel
            this.giristarihi = gidistarihi; // otel giris tarihi gidistarihinden çeker
            this.cikistarihi = donustarihi; // otelden cıkıs tarihi dönüs tarihinden ceker
            this.konaklamatipi = "Otel";
            this.ucret = "625";
            SqlKaydet();//abstract factory ile ürün ailesi oluşur rezervasyon veritabanına kaydedilir.
        }
        public void SqlKaydet()
        {
            DataBase db = new DataBase();
            db.KomutExecuteScalar("insert into KonaklamaRezerve(RezervasyonAd,RezervasyonSoyad,RezervasyonTC,RezervasyonGirisTarihi,RezervasyonCikisTarihi,RezervasyonKalinacakYer,RezervasyonKonaklamaTipi,RezervasyonUcreti)Values ('" + this.ad + "','" + this.sad + "','" + this.tc + "','" + this.giristarihi + "','" + this.cikistarihi + "','" + this.konaklama + "','" + this.konaklamatipi + "','" + this.ucret + "')");
            MessageBox.Show("otelok");
        }


        public string KonaklamaGidisDonusGonder()
        {
            throw new NotImplementedException();
        }

        public string KonaklamaSirketGonder()
        {
            throw new NotImplementedException();
        }

        public string KonaklamaTarihiGonder()
        {
            throw new NotImplementedException();
        }

    }
}
