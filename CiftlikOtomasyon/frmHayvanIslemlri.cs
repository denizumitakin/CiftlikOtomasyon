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
    public partial class frmHayvanIslemlri : Form
    {
        public frmHayvanIslemlri()
        {
            InitializeComponent();
        }

        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.Hayvan.ToList();
        }



        private void frmHayvanIslemlri_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();

            //cbKullaniciRol doldurma
            cbHayvanCins.DisplayMember = "CinsAd";
            cbHayvanCins.ValueMember = "CinsID";
            CiftlikEntities vt = new CiftlikEntities();
            cbHayvanCins.DataSource = vt.Cins.ToList();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            Hayvan yeniHayvan = new Hayvan();

            yeniHayvan.KupeNo = txt_kupeNo.Text;
            yeniHayvan.Agirlik = Convert.ToDecimal(txt_agirlik.Text);
            yeniHayvan.CinsId = Convert.ToInt32(cbHayvanCins.SelectedValue);
            yeniHayvan.OlcumTarihi = dateTimePicker1.Value;

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
        void AlanlariTemizle()
        {
            txt_agirlik.Clear();
            txt_kupeNo.Clear();
            cbHayvanCins.SelectedIndex = 0;
        }
    }
}
