using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiftlikOtomasyon
{
    public partial class frmSutGiris : Form
    {
        public frmSutGiris()
        {
            InitializeComponent();
        }
        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.Stok.ToList();
        }

        void AlanlariTemizle()
        {
            txt_sagimMiktari.Clear();
            cb_zaman.SelectedIndex = 0;
            cb_hayvanTur.SelectedIndex = 0;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            SutUretim sutSagim = new SutUretim();

            sutSagim.HayvanId = Convert.ToInt32(cb_hayvanTur.SelectedValue);
            sutSagim.Tarih = Convert.ToDecimal(txt_agirlik.Text);
            yeniHayvan.CinsId = Convert.ToInt32(cbHayvanCins.SelectedValue);
            sutSagim.Tarih = dateTimePicker1.Value;

            vt.Hayvan.Add(yeniHayvan);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                AlanlariTemizle();
                TumKullanicilariListele();
                MessageBox.Show("Kayıt başarılı!!");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız!!");
            }
        }
    

        private void frmSutGiris_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();


            CiftlikEntities vt = new CiftlikEntities();
            //cbHayvan doldurma
            cb_hayvanTur.DisplayMember = "KupeNo";
            cb_hayvanTur.ValueMember = "HayvnID";
            cb_hayvanTur.DataSource = vt.Hayvan.ToList();

            //cbzaman doldurma
            cb_zaman.DisplayMember = "ZamanAd";
            cb_zaman.ValueMember = "ZamanID";
            cb_zaman.DataSource = vt.Zaman.ToList();


        }
    }
}
