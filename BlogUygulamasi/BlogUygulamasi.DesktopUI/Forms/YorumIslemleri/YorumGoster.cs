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

namespace BlogUygulamasi.DesktopUI.Forms.YorumIslemleri
{
    public partial class YorumGoster : Form
    {
        IYorumService _yorumService;
        public YorumGoster()
        {
            InitializeComponent();
            _yorumService = InstanceFactory.GetInstance<IYorumService>();
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _yorumService.GetAllYorums();
            gridControl1.Refresh();
        }
    }
}
