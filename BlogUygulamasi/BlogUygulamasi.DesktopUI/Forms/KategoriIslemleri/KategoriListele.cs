using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
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
    public partial class KategoriListele : Form
    {
        IKategoriService _kategoriService;
        public KategoriListele()
        {
            InitializeComponent();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _kategoriService.GetAllKategoris();
            gridControl1.Refresh();
        }
    }
}
