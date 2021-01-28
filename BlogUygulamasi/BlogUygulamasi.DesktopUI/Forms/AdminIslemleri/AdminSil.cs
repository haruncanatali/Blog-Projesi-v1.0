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
    public partial class AdminSil : Form
    {
        IAdminService _adminService;
        public AdminSil()
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());

            DialogResult result = MessageBox.Show("Bu admin silinecek.Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                try
                {
                    _adminService.DeleteAdmin(_adminService.GetAdmin(c => c.AdminId == id));
                    BindData();
                    MessageBox.Show("Silme işlemi başarılı oldu.");
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            }
            else if(result == DialogResult.No)
            {
                id = -1;
            }
        }
    }
}
