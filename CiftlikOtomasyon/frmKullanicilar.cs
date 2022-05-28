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
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }


        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.vKullanici.ToList();
        }
        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
            lbl_kullaniciNo.Text = null;

            //cbKullaniciRol doldurma
            cbKullaniciRol.DisplayMember = "RolAd";
            cbKullaniciRol.ValueMember = "RolID";
            CiftlikEntities vt = new CiftlikEntities();
            cbKullaniciRol.DataSource = vt.Rol.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lbl_kullaniciNo.Text == "")
            {
                CiftlikEntities vt = new CiftlikEntities();
                Kullanici yeniKullanici = new Kullanici();

                yeniKullanici.KullaniciAd = txtKullaniciAd.Text;
                yeniKullanici.KullanciRolId = Convert.ToInt32(cbKullaniciRol.SelectedValue);
                yeniKullanici.Sifre = yeniKullanici.KullaniciAd.Substring(0, 10);
                yeniKullanici.Aktif = chkAktif.Checked;

                vt.Kullanici.Add(yeniKullanici);
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
            else
            {
                Guncelle();
            }
        }

        void Guncelle() 
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;

            CiftlikEntities vt = new CiftlikEntities();
            string kullaniciId = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
            int guncellenenKullanici = Convert.ToInt32(kullaniciId);
            var guncelle = vt.Kullanici.Where(p => p.KullaniciID == guncellenenKullanici).FirstOrDefault();
            guncelle.KullaniciAd = txtKullaniciAd.Text;
            guncelle.KullanciRolId = Convert.ToInt32(cbKullaniciRol.SelectedValue);
            guncelle.Aktif = chkAktif.Checked;
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
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
            txtKullaniciAd.Clear();
            cbKullaniciRol.SelectedIndex = 0;
            chkAktif.Checked = true;
            lbl_kullaniciNo.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;

            string kullanicino = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
            string kullaniciRol = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
            string kullaniciAd = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
            string kullaniciAktif = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();

            lbl_kullaniciNo.Text = kullanicino;
            txtKullaniciAd.Text = kullaniciAd;
            cbKullaniciRol.Text = kullaniciRol;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int silinecekKullanici = Convert.ToInt32(lbl_kullaniciNo.Text);
            vt.Kullanici.Remove(vt.Kullanici.Find(silinecekKullanici));

            vt.SaveChanges();
            AlanlariTemizle();
            TumKullanicilariListele();
        }
    }
}
