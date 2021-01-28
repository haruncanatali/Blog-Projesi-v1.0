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
    public partial class GununSozuSil : Form
    {
        IGununSozuService _gununSozuService;
        public GununSozuSil()
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            DialogResult result = MessageBox.Show("Bu günün sözü verisi silinecek.Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                try
                {
                    _gununSozuService.DeleteGununSozu(_gununSozuService.GetGununSozu(c => c.GununSozuId == id));
                    MessageBox.Show("Silme işlemi başarılı oldu.");
                    BindData();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else if(result == DialogResult.No)
            {

            }
        }
    }
}
