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
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAd.Text) ||
                string.IsNullOrEmpty(txtKullaniciSifre.Text))
            {
                MessageBox.Show("Uyarı!!", "Lütfen alanları boş bırakmayınız",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                //kullanıcıadı ve kullanıcışifre boş değil. Login olmaya çalış
                string pKullaniciAd = txtKullaniciAd.Text;
                string pKullaniciSifre = txtKullaniciSifre.Text;
                CiftlikEntities vt = new CiftlikEntities();
                Kullanici girisYapanKullanici = vt.Kullanici.FirstOrDefault(
                    p => p.KullaniciAd == pKullaniciAd && p.Sifre == pKullaniciSifre);

                if (girisYapanKullanici == null)
                {
                    MessageBox.Show("Uyarı!!", "Kullanıcı bulunamadı!!",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    frmAnaEkran anaEkran = new frmAnaEkran(girisYapanKullanici);
                    anaEkran.Show();
                    this.Hide();
                }

            }
        }
    }
}
