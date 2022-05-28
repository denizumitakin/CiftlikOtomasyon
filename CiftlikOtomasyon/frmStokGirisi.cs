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
    public partial class frmStokGirisi : Form
    {
        public frmStokGirisi()
        {
            InitializeComponent();
        }
        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.Stok.ToList();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            

            CiftlikEntities vt = new CiftlikEntities();
            Stok yeniStok = new Stok();

            yeniStok.StokTurId = Convert.ToInt32(cb_stokTur.SelectedValue);
            yeniStok.Miktar = Convert.ToDecimal(txt_StokMiktari.Text);
            yeniStok.StokGirisTarihi = dateTimePicker1.Value;
            yeniStok.IslemTarihi = DateTime.Now;

            vt.Stok.Add(yeniStok);
            int sonuc = vt.SaveChanges();

            if (sonuc > 0)
            {
                TumKullanicilariListele();
                AlanlariTemizle();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!!");
            }
            decimal stoktakiMiktar, eklenecekMiktar, eklemeSonucu;
            stoktakiMiktar = Convert.ToDecimal(yeniStok.ToplamMiktar.ToString());
            eklenecekMiktar = Convert.ToInt32(txt_StokMiktari.Text);
            eklemeSonucu = stoktakiMiktar + eklenecekMiktar;
            int guncellenenKullanici = Convert.ToInt32(txt_StokMiktari.Text);
            var guncelle = vt.Stok.Where(p => p.ToplamMiktar != guncellenenKullanici).FirstOrDefault();
            guncelle.ToplamMiktar = eklemeSonucu;
            int sonuc2 = vt.SaveChanges();
            if (sonuc2 > 0)
            {
                AlanlariTemizle();
                TumKullanicilariListele();
                MessageBox.Show("Güncelleme başarılı!!");
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız!!");
            }
            AlanlariTemizle();
            TumKullanicilariListele();
        }

        void AlanlariTemizle()
        {
            txt_StokMiktari.Clear();
            cb_stokTur.SelectedIndex = 0;
        }

        private void frmStokGirisi_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();

            //cbKullaniciRol doldurma
            cb_stokTur.DisplayMember = "StokTurAd";
            cb_stokTur.ValueMember = "StokTurID";
            CiftlikEntities vt = new CiftlikEntities();
            cb_stokTur.DataSource = vt.StokTur.ToList();
        }
    }
}
