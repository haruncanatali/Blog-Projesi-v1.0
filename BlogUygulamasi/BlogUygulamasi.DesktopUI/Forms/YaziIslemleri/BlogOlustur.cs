using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
using BlogUygulamasi.Entities.Concrete;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogUygulamasi.DesktopUI.Forms
{
    public partial class BlogOlustur : Form
    {

        IYaziService _yaziService;
        IKategoriService _kategoriService;

        public BlogOlustur()
        {
            InitializeComponent();

            _yaziService = InstanceFactory.GetInstance<IYaziService>();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
        }

        private void BlogOlustur_Load(object sender, EventArgs e)
        {
            CbxItemsAddAndLoad();
        }
        private void CbxItemsAddAndLoad()
        {
            List<Kategori> kategoriler = _kategoriService.GetAllKategoris();
            Dictionary<int, string> cbxItems = new Dictionary<int, string>();
            foreach (Kategori item in kategoriler)
            {
                cbxItems.Add(item.KategoriId, item.KategoriAd);
            }

            kategoriCbx.DataSource = new BindingSource(cbxItems, null);
            kategoriCbx.DisplayMember = "Value";
            kategoriCbx.ValueMember = "Key";

        }

        private void AtributesClick(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            switch (btn.Name)
            {
                case "icerikTemizleBtn":
                    IcerikTemizle();
                    break;
                case "kaydetBtn":
                    Kaydet();
                    break;
                case "cikisBtn":
                    this.Close();
                    break;
            }
        }

        private void Kaydet()
        {
            try
            {
                _yaziService.AddYazi(new Yazi
                {
                    KategoriId = ((KeyValuePair<int, string>)kategoriCbx.SelectedItem).Key,
                    YaziBaslik = baslikTxt.Text.ToString(),
                    YaziResimUrl = anaResimUrl.Text.ToString(),
                    YaziIcerik = htmlTextEditorTxt.DocumentHTML.ToString(),
                    YaziYazar = yazarTxt.Text.ToString(),
                    YaziTarih = DateTime.Now
                });

                MessageBox.Show("Blog Başarı İle Eklendi!");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Doğrulama Hatası");
            }
        }

        private void IcerikTemizle()
        {
            htmlTextEditorTxt.ResetText();
            baslikTxt.Text = "";
            yazarTxt.Text = "";
            anaResimUrl.Text = "";
        }
    }
}
