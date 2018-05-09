namespace KafeOtomasyonu.WinUI
{
    partial class frmMasaDetay
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
            this.lvSiparisler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBosalt = new System.Windows.Forms.Button();
            this.chkAktar = new System.Windows.Forms.CheckBox();
            this.cmbMasalar = new System.Windows.Forms.ComboBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnExceleAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSiparisler
            // 
            this.lvSiparisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSiparisler.Location = new System.Drawing.Point(12, 60);
            this.lvSiparisler.Name = "lvSiparisler";
            this.lvSiparisler.Size = new System.Drawing.Size(193, 325);
            this.lvSiparisler.TabIndex = 0;
            this.lvSiparisler.UseCompatibleStateImageBehavior = false;
            this.lvSiparisler.View = System.Windows.Forms.View.Details;
            this.lvSiparisler.DoubleClick += new System.EventHandler(this.lvSiparisler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Miktar";
            this.columnHeader2.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(123, 403);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(23, 25);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "0";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(267, 60);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(83, 23);
            this.btnSiparisEkle.TabIndex = 3;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(267, 109);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sipariş Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBosalt
            // 
            this.btnBosalt.Location = new System.Drawing.Point(267, 160);
            this.btnBosalt.Name = "btnBosalt";
            this.btnBosalt.Size = new System.Drawing.Size(83, 23);
            this.btnBosalt.TabIndex = 5;
            this.btnBosalt.Text = "Masayı Boşalt";
            this.btnBosalt.UseVisualStyleBackColor = true;
            this.btnBosalt.Click += new System.EventHandler(this.btnBosalt_Click);
            // 
            // chkAktar
            // 
            this.chkAktar.AutoSize = true;
            this.chkAktar.Location = new System.Drawing.Point(267, 285);
            this.chkAktar.Name = "chkAktar";
            this.chkAktar.Size = new System.Drawing.Size(51, 17);
            this.chkAktar.TabIndex = 6;
            this.chkAktar.Text = "Aktar";
            this.chkAktar.UseVisualStyleBackColor = true;
            this.chkAktar.CheckedChanged += new System.EventHandler(this.chkAktar_CheckedChanged);
            // 
            // cmbMasalar
            // 
            this.cmbMasalar.FormattingEnabled = true;
            this.cmbMasalar.Location = new System.Drawing.Point(267, 320);
            this.cmbMasalar.Name = "cmbMasalar";
            this.cmbMasalar.Size = new System.Drawing.Size(83, 21);
            this.cmbMasalar.TabIndex = 7;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(267, 362);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(83, 23);
            this.btnAktar.TabIndex = 8;
            this.btnAktar.Text = "Masayı Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Location = new System.Drawing.Point(267, 213);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(83, 23);
            this.btnExceleAktar.TabIndex = 9;
            this.btnExceleAktar.Text = "Excele Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // frmMasaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 465);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.cmbMasalar);
            this.Controls.Add(this.chkAktar);
            this.Controls.Add(this.btnBosalt);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSiparisler);
            this.Name = "frmMasaDetay";
            this.Text = "frmMasaDetay";
            this.Load += new System.EventHandler(this.frmMasaDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSiparisler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBosalt;
        private System.Windows.Forms.CheckBox chkAktar;
        private System.Windows.Forms.ComboBox cmbMasalar;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnExceleAktar;
    }
}