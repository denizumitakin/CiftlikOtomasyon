namespace CiftlikOtomasyon
{
    partial class frmHayvanIslemlri
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
            this.HayvanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KüpeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CinsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agirlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kupeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHayvanCins = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_agirlik = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HayvanId,
            this.KüpeNo,
            this.CinsId,
            this.Agirlik,
            this.OlcumTarihi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // HayvanId
            // 
            this.HayvanId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HayvanId.DataPropertyName = "HayvanID";
            this.HayvanId.HeaderText = "Hayvan No";
            this.HayvanId.Name = "HayvanId";
            // 
            // KüpeNo
            // 
            this.KüpeNo.DataPropertyName = "KupeNo";
            this.KüpeNo.HeaderText = "Küpe No";
            this.KüpeNo.Name = "KüpeNo";
            // 
            // CinsId
            // 
            this.CinsId.DataPropertyName = "CinsId";
            this.CinsId.HeaderText = "Cins";
            this.CinsId.Name = "CinsId";
            // 
            // Agirlik
            // 
            this.Agirlik.DataPropertyName = "Agirlik";
            this.Agirlik.HeaderText = "Ağırlık";
            this.Agirlik.Name = "Agirlik";
            // 
            // OlcumTarihi
            // 
            this.OlcumTarihi.DataPropertyName = "OlcumTarihi";
            this.OlcumTarihi.HeaderText = "Ölçüm Tarihi";
            this.OlcumTarihi.Name = "OlcumTarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Küpe No :";
            // 
            // txt_kupeNo
            // 
            this.txt_kupeNo.Location = new System.Drawing.Point(640, 13);
            this.txt_kupeNo.Name = "txt_kupeNo";
            this.txt_kupeNo.Size = new System.Drawing.Size(153, 20);
            this.txt_kupeNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cins : ";
            // 
            // cbHayvanCins
            // 
            this.cbHayvanCins.FormattingEnabled = true;
            this.cbHayvanCins.Location = new System.Drawing.Point(640, 44);
            this.cbHayvanCins.Name = "cbHayvanCins";
            this.cbHayvanCins.Size = new System.Drawing.Size(153, 21);
            this.cbHayvanCins.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ağırlık : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ölçüm Tarihi :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(640, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txt_agirlik
            // 
            this.txt_agirlik.Location = new System.Drawing.Point(640, 72);
            this.txt_agirlik.Name = "txt_agirlik";
            this.txt_agirlik.Size = new System.Drawing.Size(153, 20);
            this.txt_agirlik.TabIndex = 6;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(718, 143);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frmHayvanIslemlri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_agirlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHayvanCins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kupeNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHayvanIslemlri";
            this.Text = "frmHayvanIslemlri";
            this.Load += new System.EventHandler(this.frmHayvanIslemlri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kupeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHayvanCins;
        private System.Windows.Forms.DataGridViewTextBoxColumn HayvanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KüpeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agirlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcumTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_agirlik;
        private System.Windows.Forms.Button btn_kaydet;
    }
}