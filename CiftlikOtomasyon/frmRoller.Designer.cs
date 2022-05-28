namespace CiftlikOtomasyon
{
    partial class frmRoller
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
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.lbl_RolAd = new System.Windows.Forms.Label();
            this.txt_rolAd = new System.Windows.Forms.TextBox();
            this.txt_rolKod = new System.Windows.Forms.TextBox();
            this.lbl_RolKod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rolNo = new System.Windows.Forms.Label();
            this.RolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RolID,
            this.RolAd,
            this.RolKod});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(506, 124);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // lbl_RolAd
            // 
            this.lbl_RolAd.AutoSize = true;
            this.lbl_RolAd.Location = new System.Drawing.Point(431, 44);
            this.lbl_RolAd.Name = "lbl_RolAd";
            this.lbl_RolAd.Size = new System.Drawing.Size(50, 13);
            this.lbl_RolAd.TabIndex = 2;
            this.lbl_RolAd.Text = "Rol Adı : ";
            // 
            // txt_rolAd
            // 
            this.txt_rolAd.Location = new System.Drawing.Point(488, 42);
            this.txt_rolAd.Name = "txt_rolAd";
            this.txt_rolAd.Size = new System.Drawing.Size(120, 20);
            this.txt_rolAd.TabIndex = 3;
            // 
            // txt_rolKod
            // 
            this.txt_rolKod.Location = new System.Drawing.Point(487, 74);
            this.txt_rolKod.Name = "txt_rolKod";
            this.txt_rolKod.Size = new System.Drawing.Size(120, 20);
            this.txt_rolKod.TabIndex = 5;
            // 
            // lbl_RolKod
            // 
            this.lbl_RolKod.AutoSize = true;
            this.lbl_RolKod.Location = new System.Drawing.Point(430, 76);
            this.lbl_RolKod.Name = "lbl_RolKod";
            this.lbl_RolKod.Size = new System.Drawing.Size(60, 13);
            this.lbl_RolKod.TabIndex = 4;
            this.lbl_RolKod.Text = "Rol Kodu : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rol No : ";
            // 
            // lbl_rolNo
            // 
            this.lbl_rolNo.AutoSize = true;
            this.lbl_rolNo.Location = new System.Drawing.Point(484, 12);
            this.lbl_rolNo.Name = "lbl_rolNo";
            this.lbl_rolNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_rolNo.TabIndex = 7;
            // 
            // RolID
            // 
            this.RolID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RolID.DataPropertyName = "RolID";
            this.RolID.HeaderText = "Rol No";
            this.RolID.Name = "RolID";
            // 
            // RolAd
            // 
            this.RolAd.DataPropertyName = "RolAd";
            this.RolAd.HeaderText = "Rol Adı";
            this.RolAd.Name = "RolAd";
            // 
            // RolKod
            // 
            this.RolKod.DataPropertyName = "RolKod";
            this.RolKod.HeaderText = "Rol Kodu";
            this.RolKod.Name = "RolKod";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(506, 153);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // frmRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.lbl_rolNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rolKod);
            this.Controls.Add(this.lbl_RolKod);
            this.Controls.Add(this.txt_rolAd);
            this.Controls.Add(this.lbl_RolAd);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRoller";
            this.Text = "frmRoller";
            this.Load += new System.EventHandler(this.frmRoller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label lbl_RolAd;
        private System.Windows.Forms.TextBox txt_rolAd;
        private System.Windows.Forms.TextBox txt_rolKod;
        private System.Windows.Forms.Label lbl_RolKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_rolNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolKod;
        private System.Windows.Forms.Button btn_sil;
    }
}