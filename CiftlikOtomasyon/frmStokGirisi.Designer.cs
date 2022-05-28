namespace CiftlikOtomasyon
{
    partial class frmStokGirisi
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
            this.StokId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokTurId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokGirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_stokTur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StokMiktari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokId,
            this.StokTurId,
            this.Miktar,
            this.StokGirisTarihi,
            this.IslemTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // StokId
            // 
            this.StokId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StokId.DataPropertyName = "StokID";
            this.StokId.HeaderText = "Stok No";
            this.StokId.Name = "StokId";
            // 
            // StokTurId
            // 
            this.StokTurId.DataPropertyName = "StokTurId";
            this.StokTurId.HeaderText = "Stok Türü";
            this.StokTurId.Name = "StokTurId";
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Stok Miktarı";
            this.Miktar.Name = "Miktar";
            // 
            // StokGirisTarihi
            // 
            this.StokGirisTarihi.DataPropertyName = "StokGirisTarihi";
            this.StokGirisTarihi.HeaderText = "Stok Giriş Tarihi";
            this.StokGirisTarihi.Name = "StokGirisTarihi";
            // 
            // IslemTarihi
            // 
            this.IslemTarihi.DataPropertyName = "IslemTarihi";
            this.IslemTarihi.HeaderText = "İşlem Tarihi";
            this.IslemTarihi.Name = "IslemTarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stok Türü :";
            // 
            // cb_stokTur
            // 
            this.cb_stokTur.FormattingEnabled = true;
            this.cb_stokTur.Location = new System.Drawing.Point(653, 10);
            this.cb_stokTur.Name = "cb_stokTur";
            this.cb_stokTur.Size = new System.Drawing.Size(121, 21);
            this.cb_stokTur.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Miktarı :";
            // 
            // txt_StokMiktari
            // 
            this.txt_StokMiktari.Location = new System.Drawing.Point(653, 43);
            this.txt_StokMiktari.Name = "txt_StokMiktari";
            this.txt_StokMiktari.Size = new System.Drawing.Size(121, 20);
            this.txt_StokMiktari.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stok Giriş Tarihi :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(653, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(698, 124);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frmStokGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_StokMiktari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_stokTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStokGirisi";
            this.Text = "frmStokGirisi";
            this.Load += new System.EventHandler(this.frmStokGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTurId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokGirisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_stokTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StokMiktari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_kaydet;
    }
}