using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogUygulamasi.DesktopUI.Forms.KategoriIslemleri
{
    public partial class KategoriEkle : Form
    {
        IKategoriService _kategoriService;
        public KategoriEkle()
        {
            InitializeComponent();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _kategoriService.AddKategori(new Kategori
                {
                    KategoriAd = adTxt.Text.ToString(),
                    KategoriAciklama = aciklamaTxt.Text.ToString()
                });
                MessageBox.Show("Ekleme işlemi başarılı oldu.");
                adTxt.Text = "";
                aciklamaTxt.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
