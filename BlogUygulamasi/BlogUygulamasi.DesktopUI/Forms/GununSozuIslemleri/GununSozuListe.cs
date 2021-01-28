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

namespace BlogUygulamasi.DesktopUI.Forms.GununSozuIslemleri
{
    public partial class GununSozuListe : Form
    {
        IGununSozuService _gununSozuService;
        public GununSozuListe()
        {
            InitializeComponent();
            _gununSozuService = InstanceFactory.GetInstance<IGununSozuService>();
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _gununSozuService.GetAllGununSozus();
            gridControl1.Refresh();
        }
    }
}
