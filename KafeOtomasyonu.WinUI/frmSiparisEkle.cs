using KafeOtomasyonu.BLL;
using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KafeOtomasyonu.WinUI
{
    public partial class frmSiparisEkle : Form
    {
        public frmSiparisEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ESiparisler s = new ESiparisler();
            s.ProductName = cmbUrun.Text;
            s.Quantity = Convert.ToInt32(numMiktar.Value);
            string cevap = BLLSiparisler.Ekle(Form1.masaAdi, s);
            MessageBox.Show(cevap);
            frmMasaDetay fmd = Application.OpenForms["frmMasaDetay"] as frmMasaDetay;
            fmd.Doldur();
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1.Doldur();
        }

        private void frmSiparisEkle_Load(object sender, EventArgs e)
        {
            cmbUrun.Enabled = false;
            cmbKategori.DataSource = BLLKategori.Listele();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "ID";            
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbKategori_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbKategori.SelectedValue);
            cmbUrun.Enabled = true;
            cmbUrun.DataSource = BLLUrun.Listele(id);
            cmbUrun.DisplayMember = "ProductName";
            cmbUrun.ValueMember = "ID";
        }
    }
}
