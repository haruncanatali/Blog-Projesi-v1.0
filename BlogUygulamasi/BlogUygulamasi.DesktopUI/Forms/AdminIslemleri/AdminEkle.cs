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

namespace BlogUygulamasi.DesktopUI.Forms.AdminIslemleri
{
    public partial class AdminEkle : Form
    {
        IAdminService _adminService;
        public AdminEkle()
        {
            InitializeComponent();
            _adminService = InstanceFactory.GetInstance<IAdminService>();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _adminService.AddAdmin(new Admin
                {
                    AdminUsername = adTxt.Text.ToString(),
                    AdminPassword = sifreTxt.Text.ToString()
                });
                MessageBox.Show("Admin Başarı ile sisteme eklendi.");
                adTxt.Text = "";
                sifreTxt.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
