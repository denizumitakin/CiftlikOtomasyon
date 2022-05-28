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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        public frmAnaEkran(Kullanici pKullanici)
        {
            InitializeComponent();

            menuYonetici.Visible = false;
            menuStokSorumlusu.Visible = false;
            menuSutSagimSorumlusu.Visible = false;

            switch (pKullanici.Rol.RolKod)
            {
                case "Yonetici":
                    menuYonetici.Visible = true;
                    break;
                case "StokSorumlusu":
                    menuStokSorumlusu.Visible = true;
                    break;
                case "SutSagimSorumlusu":
                    menuSutSagimSorumlusu.Visible = true;
                    break;
            }

        }

        private void frmAnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tümKullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullanicilar kullanicilar = new frmKullanicilar();
            kullanicilar.MdiParent = this;
            kullanicilar.Show();
        }

        private void kullanıcıRolleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoller roller = new frmRoller();
            roller.MdiParent = this;
            roller.Show();
        }

        private void cinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHayvanIslemlri HayvanIslemleri = new frmHayvanIslemlri();
            HayvanIslemleri.MdiParent = this;
            HayvanIslemleri.Show();
        }

        private void stokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStokGirisi stokGiris = new frmStokGirisi();
            stokGiris.MdiParent = this;
            stokGiris.Show();
        }

        private void sütİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSutGiris sutGiris = new frmSutGiris();
            sutGiris.MdiParent = this;
            sutGiris.Show();
        }
    }
}
