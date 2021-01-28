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
    public partial class YorumSil : Form
    {
        IYorumService _yorumService;
        public YorumSil()
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns[0]).ToString());
            DialogResult result = MessageBox.Show("Bu yorum silinecek.Eminmisiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                try
                {
                    _yorumService.DeleteYorum(_yorumService.GetYorum(c => c.YorumId == id));
                    MessageBox.Show("Yorum Silindi.");
                    BindData();
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
