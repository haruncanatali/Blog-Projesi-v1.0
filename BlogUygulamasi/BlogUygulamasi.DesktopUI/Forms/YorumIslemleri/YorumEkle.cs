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

namespace BlogUygulamasi.DesktopUI.Forms.YorumIslemleri
{
    public partial class YorumEkle : Form
    {
        IYaziService _yaziService;
        IYorumService _yorumService;
        public YorumEkle()
        {
            InitializeComponent();
            _yaziService = InstanceFactory.GetInstance<IYaziService>();
            _yorumService = InstanceFactory.GetInstance<IYorumService>();
        }

        private void YorumEkle_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> cbxItems = new Dictionary<int, string>();
            List<Yazi> liste = new List<Yazi>();
            liste = _yaziService.GetAllYazis();
            foreach (var item in liste)
            {
                cbxItems.Add(item.YaziId, item.YaziBaslik);
            }

            blogCbx.DataSource = new BindingSource(cbxItems, null);
            blogCbx.ValueMember = "Key";
            blogCbx.DisplayMember = "Value";
        }

        private void yorumEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _yorumService.AddYorum(new Yorum
                {

                    YorumAd = adTxt.Text.ToString(),
                    YorumSoyad = soyadTxt.Text.ToString(),
                    YorumMail = mailTxt.Text.ToString(),
                    YorumIcerik = icerikTxt.Text.ToString(),
                    YorumTarih = DateTime.Now,
                    YaziId = ((KeyValuePair<int, string>)blogCbx.SelectedItem).Key

                });
                MessageBox.Show("Yorum Başarı İle Eklendi.");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
