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
    public partial class BlogSil : Form
    {
        IYaziService _yaziService;
        public BlogSil()
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns[0]).ToString());
            DialogResult result = MessageBox.Show("Seçili Olan Satırı Silinecek.Eminmisiniz?", "Bilgilendirne", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    _yaziService.DeleteYazi(_yaziService.GetYazi(c => c.YaziId == id));
                    BindData();
                    MessageBox.Show("Silme İşlemi Başarılı Oldu.");
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
