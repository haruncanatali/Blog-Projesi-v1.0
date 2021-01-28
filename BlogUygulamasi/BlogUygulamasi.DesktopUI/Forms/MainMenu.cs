using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
using BlogUygulamasi.DesktopUI.Forms;
using BlogUygulamasi.DesktopUI.Forms.AdminIslemleri;
using BlogUygulamasi.DesktopUI.Forms.GununSozuIslemleri;
using BlogUygulamasi.DesktopUI.Forms.KategoriIslemleri;
using BlogUygulamasi.DesktopUI.Forms.YorumIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogUygulamasi.DesktopUI
{
    public partial class MainMenu : Form
    {

        BlogOlustur _blogOlusturFrm;
        BlogGuncelle _blogGuncelleFrm;
        BlogSil _blogSilFrm;
        BloglariGoruntule _blogGoruntuleFrm;

        YorumSil _yorumSilFrm;
        YorumGuncelle _yorumGuncelleFrm;
        YorumEkle _yorumEkleFrm;
        YorumGoster _yorumGosterFrm;

        AdminEkle _adminEkleFrm;
        AdminSil _adminSilFrm;
        AdminListe _adminListeFrm;

        GununSozuEkle _gununSozuEkleFrm;
        GununSozuGuncelle _gununSozuGuncelleFrm;
        GununSozuSil _gununSozuSilFrm;
        GununSozuListe _gununSozuListeFrm;

        KategoriEkle _kategoriEkleFrm;
        KategoriGuncelle _kategoriGuncelleFrm;
        KategoriSil _kategoriSilFrm;
        KategoriListele _kategoriListeleFrm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void yaziEkleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _blogOlusturFrm = new BlogOlustur();
                _blogOlusturFrm.MdiParent = this;
                _blogOlusturFrm.Show();

        }

        private void sistemdenCikBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.Visible = false;
            girisPanel.Visible = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _blogGuncelleFrm = new BlogGuncelle();
                _blogGuncelleFrm.MdiParent = this;
                _blogGuncelleFrm.Show();

        }

        private void yaziSilBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _blogSilFrm = new BlogSil();
            _blogSilFrm.MdiParent = this;
            _blogSilFrm.Show();
        }

        private void yazilariGoruntuleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _blogGoruntuleFrm = new BloglariGoruntule();
            _blogGoruntuleFrm.MdiParent = this;
            _blogGoruntuleFrm.Show();
        }

        private void yorumSilBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _yorumSilFrm = new YorumSil();
            _yorumSilFrm.MdiParent = this;
            _yorumSilFrm.Show();
        }

        private void yorumGuncelleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _yorumGuncelleFrm = new YorumGuncelle();
            _yorumGuncelleFrm.MdiParent = this;
            _yorumGuncelleFrm.Show();
        }

        private void sistemdenCikisYapBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.Visible = false;
            girisPanel.Visible = true;
        }

        private void yorumEkleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _yorumEkleFrm = new YorumEkle();
            _yorumEkleFrm.MdiParent = this;
            _yorumEkleFrm.Show();
        }

        private void yorumGoruntuleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _yorumGosterFrm = new YorumGoster();
            _yorumGosterFrm.MdiParent = this;
            _yorumGosterFrm.Show();
        }

        private void adminEkleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _adminEkleFrm = new AdminEkle();
            _adminEkleFrm.MdiParent = this;
            _adminEkleFrm.Show();
        }

        private void adminSilBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _adminSilFrm = new AdminSil();
            _adminSilFrm.MdiParent = this;
            _adminSilFrm.Show();
        }

        private void adminGoruntuleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _adminListeFrm = new AdminListe();
            _adminListeFrm.MdiParent = this;
            _adminListeFrm.Show();
        }

        private void gununSozuEkleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _gununSozuEkleFrm = new GununSozuEkle();
            _gununSozuEkleFrm.MdiParent = this;
            _gununSozuEkleFrm.Show();
        }

        private void gununSozuGuncelleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _gununSozuGuncelleFrm = new GununSozuGuncelle();
            _gununSozuGuncelleFrm.MdiParent = this;
            _gununSozuGuncelleFrm.Show();
        }

        private void gununSozuSilBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _gununSozuSilFrm = new GununSozuSil();
            _gununSozuSilFrm.MdiParent = this;
            _gununSozuSilFrm.Show();
        }

        private void gununSozleriGoruntuleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _gununSozuListeFrm = new GununSozuListe();
            _gununSozuListeFrm.MdiParent = this;
            _gununSozuListeFrm.Show();
        }

        private void kategoriEkleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _kategoriEkleFrm = new KategoriEkle();
            _kategoriEkleFrm.MdiParent = this;
            _kategoriEkleFrm.Show();
        }

        private void kategoriGuncelleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _kategoriGuncelleFrm = new KategoriGuncelle();
            _kategoriGuncelleFrm.MdiParent = this;
            _kategoriGuncelleFrm.Show();
        }

        private void kategoriSilBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _kategoriSilFrm = new KategoriSil();
            _kategoriSilFrm.MdiParent = this;
            _kategoriSilFrm.Show();
        }

        private void kategoriGoruntuleBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _kategoriListeleFrm = new KategoriListele();
            _kategoriListeleFrm.MdiParent = this;
            _kategoriListeleFrm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.Visible = false;
            girisPanel.Visible = true;
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.Visible = false;
            girisPanel.Visible = true;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.Visible = false;
            girisPanel.Visible = true;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IAdminService _adminService;
                _adminService = InstanceFactory.GetInstance<IAdminService>();

                if(_adminService.GetAdmin(c=>c.AdminUsername == adTxt.Text.ToString() && c.AdminPassword == sifreTxt.Text.ToString())!=null)
                {
                    adminIsmiBar.Caption = adTxt.Text;
                    adTxt.Text = "";
                    sifreTxt.Text = "";
                    girisPanel.Visible = false;
                    ribbonControl1.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifresi hatalı!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
