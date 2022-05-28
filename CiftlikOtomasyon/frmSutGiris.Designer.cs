namespace CiftlikOtomasyon
{
    partial class frmSutGiris
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.dt_sagimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_hayvanTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sagimMiktari = new System.Windows.Forms.TextBox();
            this.cb_zaman = new System.Windows.Forms.ComboBox();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HayvanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SutUretimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(697, 123);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 15;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // dt_sagimTarihi
            // 
            this.dt_sagimTarihi.Location = new System.Drawing.Point(652, 36);
            this.dt_sagimTarihi.Name = "dt_sagimTarihi";
            this.dt_sagimTarihi.Size = new System.Drawing.Size(121, 20);
            this.dt_sagimTarihi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Süt Sağım Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sağım Zamanı :";
            // 
            // cb_hayvanTur
            // 
            this.cb_hayvanTur.FormattingEnabled = true;
            this.cb_hayvanTur.Location = new System.Drawing.Point(652, 9);
            this.cb_hayvanTur.Name = "cb_hayvanTur";
            this.cb_hayvanTur.Size = new System.Drawing.Size(121, 21);
            this.cb_hayvanTur.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hayvan Cinsi :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SutUretimID,
            this.HayvanId,
            this.Tarih,
            this.Zaman,
            this.Miktar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 334);
            this.dataGridView1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sağım Miktarı :";
            // 
            // txt_sagimMiktari
            // 
            this.txt_sagimMiktari.Location = new System.Drawing.Point(652, 89);
            this.txt_sagimMiktari.Name = "txt_sagimMiktari";
            this.txt_sagimMiktari.Size = new System.Drawing.Size(121, 20);
            this.txt_sagimMiktari.TabIndex = 19;
            // 
            // cb_zaman
            // 
            this.cb_zaman.FormattingEnabled = true;
            this.cb_zaman.Location = new System.Drawing.Point(652, 62);
            this.cb_zaman.Name = "cb_zaman";
            this.cb_zaman.Size = new System.Drawing.Size(121, 21);
            this.cb_zaman.TabIndex = 20;
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Süt Miktarı";
            this.Miktar.Name = "Miktar";
            // 
            // Zaman
            // 
            this.Zaman.DataPropertyName = "ZamanId";
            this.Zaman.HeaderText = "Sağım Zamanı";
            this.Zaman.Name = "Zaman";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Sağım Tarihi";
            this.Tarih.Name = "Tarih";
            // 
            // HayvanId
            // 
            this.HayvanId.DataPropertyName = "HayvanId";
            this.HayvanId.HeaderText = "Hayvan Cinsi";
            this.HayvanId.Name = "HayvanId";
            // 
            // SutUretimID
            // 
            this.SutUretimID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SutUretimID.DataPropertyName = "SutUretimID";
            this.SutUretimID.HeaderText = "Süt Üretim No";
            this.SutUretimID.Name = "SutUretimID";
            // 
            // frmSutGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_zaman);
            this.Controls.Add(this.txt_sagimMiktari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dt_sagimTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_hayvanTur);
            this.Controls.Add(this.label1);
            this.Name = "frmSutGiris";
            this.Text = "frmSutGiris";
            this.Load += new System.EventHandler(this.frmSutGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DateTimePicker dt_sagimTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_hayvanTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sagimMiktari;
        private System.Windows.Forms.ComboBox cb_zaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn SutUretimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HayvanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
    }
}