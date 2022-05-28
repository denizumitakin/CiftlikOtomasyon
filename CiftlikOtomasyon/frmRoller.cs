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
    public partial class frmRoller : Form
    {
        public frmRoller()
        {
            InitializeComponent();
        }
        void TumKullanicilariListele()
        {
            dataGridView1.AutoGenerateColumns = false;
            CiftlikEntities vt = new CiftlikEntities();
            dataGridView1.DataSource = vt.Rol.ToList();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (lbl_rolNo.Text == "")
            {
                CiftlikEntities vt = new CiftlikEntities();
                Rol yeniRol = new Rol();

                yeniRol.RolAd = txt_rolAd.Text;
                yeniRol.RolKod = txt_rolKod.Text;
                

                vt.Rol.Add(yeniRol);
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
            string rolID = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
            int guncellenenKullanici = Convert.ToInt32(lbl_rolNo.Text);
            var guncelle = vt.Rol.Where(p => p.RolID == guncellenenKullanici).FirstOrDefault();
            guncelle.RolAd = txt_rolAd.Text;
            guncelle.RolKod = txt_rolKod.Text;
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
            txt_rolAd.Clear();
            txt_rolKod.Clear();
            lbl_rolNo.Text = "";
        }

        private void frmRoller_Load(object sender, EventArgs e)
        {
            TumKullanicilariListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;

            string rolNo = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
            string rolAd = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
            string rolKod = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();

            lbl_rolNo.Text = rolNo;
            txt_rolAd.Text = rolAd;
            txt_rolKod.Text = rolKod;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            CiftlikEntities vt = new CiftlikEntities();
            int silinecekKullanici = Convert.ToInt32(lbl_rolNo.Text);
            vt.Rol.Remove(vt.Rol.Find(silinecekKullanici));

            vt.SaveChanges();
            AlanlariTemizle();
            TumKullanicilariListele();
        }
    }
}
