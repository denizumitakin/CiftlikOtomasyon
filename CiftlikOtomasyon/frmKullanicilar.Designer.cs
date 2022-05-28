
namespace CiftlikOtomasyon
{
    partial class frmKullanicilar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKullaniciRol = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbl_kullaniciNo = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KullaniciID,
            this.RolAd,
            this.KullaniciAd,
            this.Aktif});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KullaniciID
            // 
            this.KullaniciID.DataPropertyName = "KullaniciID";
            this.KullaniciID.HeaderText = "Kullanıcı No";
            this.KullaniciID.Name = "KullaniciID";
            // 
            // RolAd
            // 
            this.RolAd.DataPropertyName = "RolAd";
            this.RolAd.HeaderText = "Kullanıcı Rolü";
            this.RolAd.Name = "RolAd";
            // 
            // KullaniciAd
            // 
            this.KullaniciAd.DataPropertyName = "KullaniciAd";
            this.KullaniciAd.HeaderText = "Kullanıcı Adı";
            this.KullaniciAd.Name = "KullaniciAd";
            // 
            // Aktif
            // 
            this.Aktif.DataPropertyName = "Aktif";
            this.Aktif.HeaderText = "Aktif";
            this.Aktif.Name = "Aktif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Ad:";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(536, 48);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(192, 20);
            this.txtKullaniciAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Rol:";
            // 
            // cbKullaniciRol
            // 
            this.cbKullaniciRol.FormattingEnabled = true;
            this.cbKullaniciRol.Location = new System.Drawing.Point(536, 82);
            this.cbKullaniciRol.Name = "cbKullaniciRol";
            this.cbKullaniciRol.Size = new System.Drawing.Size(192, 21);
            this.cbKullaniciRol.TabIndex = 4;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Location = new System.Drawing.Point(467, 132);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(89, 17);
            this.chkAktif.TabIndex = 5;
            this.chkAktif.Text = "Kullanıcı Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(536, 171);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbl_kullaniciNo
            // 
            this.lbl_kullaniciNo.AutoSize = true;
            this.lbl_kullaniciNo.Location = new System.Drawing.Point(467, 13);
            this.lbl_kullaniciNo.Name = "lbl_kullaniciNo";
            this.lbl_kullaniciNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_kullaniciNo.TabIndex = 8;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(536, 200);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.lbl_kullaniciNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.cbKullaniciRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKullanicilar";
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKullaniciRol;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktif;
        private System.Windows.Forms.Label lbl_kullaniciNo;
        private System.Windows.Forms.Button btn_Sil;
    }
}