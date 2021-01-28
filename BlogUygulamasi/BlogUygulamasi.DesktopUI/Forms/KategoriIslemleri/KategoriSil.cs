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
    public partial class KategoriSil : Form
    {
        IKategoriService _kategoriService;
        public KategoriSil()
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());

            DialogResult result = MessageBox.Show("Bu kategori alt kümeleriyle(yazılar,yorumlar) beraber silinecek.Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                try
                {
                    _kategoriService.DeleteKategori(_kategoriService.GetKategori(c => c.KategoriId == id));
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
                id = -1;
            }

        }
    }
}
