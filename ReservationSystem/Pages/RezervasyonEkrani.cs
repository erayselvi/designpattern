using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystem
{
    public partial class RezervasyonEkrani : Form
    {
        public RezervasyonEkrani()
        {
            InitializeComponent();
        }

        private void OtobusCadir_RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Olustur_B_Click(object sender, EventArgs e)
        {
            if (OtobusOtel_RB.Checked)
            {
                RezervasyonClient RC = new RezervasyonClient(new Otobus_Otel_Fabrikasi(Ad_TB.Text, Soyad_TB.Text, TC_TB.Text, Nereden_CB.Text, Nereye_CB.Text, GidisTarih.Value, DonusTarih.Value, Firma_CB.Text));
            }
            else if(OtobusCadir_RB.Checked)
            {
                RezervasyonClient RC = new RezervasyonClient(new Otobus_Cadir_Fabrikasi(Ad_TB.Text, Soyad_TB.Text, TC_TB.Text, Nereden_CB.Text, Nereye_CB.Text, GidisTarih.Value, DonusTarih.Value, Firma_CB.Text));

            }
            else if(UcakOtel_RB.Checked)
            {
                RezervasyonClient RC = new RezervasyonClient(new Ucak_Otel_Fabrikasi(Ad_TB.Text, Soyad_TB.Text, TC_TB.Text, Nereden_CB.Text, Nereye_CB.Text, GidisTarih.Value, DonusTarih.Value, Firma_CB.Text));

            }
            else if(UcakCadir_RB.Checked)
            {
                RezervasyonClient RC = new RezervasyonClient(new Ucak_Cadir_Fabrikasi(Ad_TB.Text, Soyad_TB.Text, TC_TB.Text, Nereden_CB.Text, Nereye_CB.Text, GidisTarih.Value, DonusTarih.Value, Firma_CB.Text));

            }
            HtmlRapor_B.Enabled = true;
            XmlRapor_B.Enabled = true;
            JsonRapor_B.Enabled = true;

        }

        private void HtmlRapor_B_Click(object sender, EventArgs e)
        {
            RaporBuilder RB = new HtmlRaporBuilder(new RaporBilgileri(Ad_TB.Text, Soyad_TB.Text, Nereden_CB.Text, Nereye_CB.Text, GidisTarih.Value.ToShortDateString(), DonusTarih.Value.ToShortDateString(), "Otel", "200", "Otobüs", "50", Firma_CB.Text));
            string RaporString = RB.BuildCikti();
            System.IO.File.WriteAllText(@"C:\rapor\HtmlRapor.html", RaporString);
            MessageBox.Show("'C:\rapor' dizine rapor kaydedilmiştir.");
        }

        private void XmlRapor_B_Click(object sender, EventArgs e)
        {
            RaporBuilder RB = new XmlRaporBuilder(new RaporBilgileri(Ad_TB.Text, Soyad_TB.Text, Nereden_CB.Text, Nereye_CB.Text, GidisTarih.Value.ToShortDateString(), DonusTarih.Value.ToShortDateString(), "Otel", "200", "Otobüs", "50", Firma_CB.Text));
            string RaporString = RB.BuildCikti();
            System.IO.File.WriteAllText(@"C:\rapor\XmlRapor.xml", RaporString);
            MessageBox.Show("'C:\rapor' dizine rapor kaydedilmiştir.");
        }

        private void JsonRapor_B_Click(object sender, EventArgs e)
        {
            RaporBuilder RB = new JsonRaporBuilder(new RaporBilgileri(Ad_TB.Text, Soyad_TB.Text, Nereden_CB.Text, Nereye_CB.Text, GidisTarih.Value.ToShortDateString(), DonusTarih.Value.ToShortDateString(), "Otel", "200", "Otobüs", "50", Firma_CB.Text));
            string RaporString = RB.BuildCikti();
            System.IO.File.WriteAllText(@"C:\rapor\JsonRapor.json", RaporString);
            MessageBox.Show("'C:\rapor' dizine rapor kaydedilmiştir.");
        }

        private void RezerveSil_Click(object sender, EventArgs e)
        {
            RezervasyonSil RS = new RezervasyonSil();
            this.Hide();
            RS.Show();
        }
    }
}
