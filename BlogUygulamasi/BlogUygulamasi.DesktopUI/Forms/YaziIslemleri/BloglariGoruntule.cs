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

namespace BlogUygulamasi.DesktopUI.Forms
{
    public partial class BloglariGoruntule : Form
    {
        IYaziService _yaziService;
        public BloglariGoruntule()
        {
            InitializeComponent();
            _yaziService = InstanceFactory.GetInstance<IYaziService>();
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _yaziService.GetAllYazis();
            gridControl1.Refresh();
        }
    }
}
