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
    public partial class RezervasyonSil : Form
    {
        DataBase DB = new DataBase();
        public RezervasyonSil()
        {
            InitializeComponent();
        }

        private void RezervasyonSil_Load(object sender, EventArgs e)
        {
            DGVLoad(); 
        }
        private void DGVLoad()
        {
            DGV_Konaklama.DataSource = DB.Table("select * from KonaklamaRezerve");
            DGV_Ulasim.DataSource = DB.Table("select * from UlasimRezerve");
        }

        private void RezerveSil_B_Click(object sender, EventArgs e)
        {
            if (KonaklamaSil.Checked)
            {
                DB.KomutExecuteScalar("delete from KonaklamaRezerve where RezervasyonID=" + Convert.ToInt32(RezervasyonID_TB.Text) + "");
                DialogResult secenek = MessageBox.Show("Ulasım Rezerveyide silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    DB.KomutExecuteScalar("delete from UlasimRezerve where RezervasyonID=" + Convert.ToInt32(RezervasyonID_TB.Text) + "");
                    MessageBox.Show("Ulasım Rezervede Silinmiştir.");
                }
            }

            if (UlasimSil.Checked)
            {
                DB.KomutExecuteScalar("delete from UlasimRezerve where RezervasyonID=" + Convert.ToInt32(RezervasyonID_TB.Text) + "");
                DialogResult secenek = MessageBox.Show("Ulasım Rezerveyide silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    DB.KomutExecuteScalar("delete from KonaklamaRezerve where RezervasyonID=" + Convert.ToInt32(RezervasyonID_TB.Text) + "");
                    MessageBox.Show("Konaklama Rezervede Silinmiştir.");
                }
            }
            DGVLoad();

        }
    }
}
