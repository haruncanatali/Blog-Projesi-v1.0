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

namespace BlogUygulamasi.DesktopUI.Forms.AdminIslemleri
{
    public partial class AdminListe : Form
    {
        IAdminService _adminService;
        public AdminListe()
        {
            InitializeComponent();
            _adminService = InstanceFactory.GetInstance<IAdminService>();
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _adminService.AllAdmins();
            gridControl1.Refresh();
        }
    }
}
