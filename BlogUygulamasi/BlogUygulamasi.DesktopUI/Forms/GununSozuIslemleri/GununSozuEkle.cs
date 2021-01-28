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

namespace BlogUygulamasi.DesktopUI.Forms.GununSozuIslemleri
{
    public partial class GununSozuEkle : Form
    {
        IGununSozuService _gununSozuService;
        public GununSozuEkle()
        {
            InitializeComponent();
            _gununSozuService = InstanceFactory.GetInstance<IGununSozuService>();
        }

        private void gununSozuEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _gununSozuService.AddGununSozu(new GununSozu
                {
                    GununSozuFotoUrl = fotoUrlTxt.Text.ToString(),
                    GununSozuIcerik = icerikTxt.Text.ToString(),
                    GununSozuSahip = sahipTxt.Text.ToString(),
                    GununSozuTarih = tarihDateEdx.DateTime
                });
                fotoUrlTxt.Text = "";
                icerikTxt.Text = "";
                sahipTxt.Text = "";
                MessageBox.Show("Ekleme işlemi başarılı oldu.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
