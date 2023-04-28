﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    class Otobus:IUlasim
    {
        private string ad;
        private string sad;
        private string tc;
        private string nereden;
        private string nereye;
        private string sirketad;
        private DateTime gidistarih;
        private DateTime donustarih;
        private string UlasimTipi;
        private string ucret;
        public Otobus(string ad,string sad,string tc,string nereden, string nereye, DateTime gidistarih, DateTime donustarih, string sirketad)
        {

            this.ad = ad;
            this.sad = sad;
            this.tc = tc;
            this.nereden = nereden;
            this.nereye = nereye;
            this.sirketad = sirketad;
            this.gidistarih = gidistarih;
            this.donustarih = donustarih;
            this.UlasimTipi = "Otobüs";
            this.ucret = "50";
            SqlKaydet();
        }

        public void SqlKaydet()
        {
            DataBase db = new DataBase();
            db.KomutExecuteScalar("insert into UlasimRezerve(RezervasyonAd,RezervasyonSoyad,RezervasyonTC,RezervasyonKalkisYeri,RezervasyonVarisYeri,RezervasyonGidisTarih,RezervasyonDonusTarih,RezervasyonUlasimTipi,RezervasyonUcreti) Values('" + this.ad + "','" + this.sad + "','" + this.tc + "','" + this.nereden + "','" + this.nereye + "','" + this.gidistarih.Date.ToShortDateString()+ "','" + this.donustarih.ToShortDateString()+ "','"+this.UlasimTipi+"','" + this.ucret + "')");
            MessageBox.Show("otobusok");
        }

        public string UlasimGidisDonusGonder()
        {
            throw new NotImplementedException();
        }

        public string UlasimSirketGonder()
        {
            throw new NotImplementedException();
        }

        public string UlasimTarihiGonder()
        {
            throw new NotImplementedException();
        }
    }
}
