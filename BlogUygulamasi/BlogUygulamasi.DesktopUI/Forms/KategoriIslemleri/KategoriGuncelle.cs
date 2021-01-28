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

namespace BlogUygulamasi.DesktopUI.Forms.KategoriIslemleri
{
    public partial class KategoriGuncelle : Form
    {
        IKategoriService _kategoriService;
        int id;
        public KategoriGuncelle()
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
            id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            adTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            icerikTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = _kategoriService.GetKategori(c => c.KategoriId == id);
                kategori.KategoriAd = adTxt.Text.ToString();
                kategori.KategoriAciklama = icerikTxt.Text.ToString();
                _kategoriService.UpdateKategori(kategori);
                MessageBox.Show("Güncelleme başarılı oldu.");
                adTxt.Text = "";
                icerikTxt.Text = "";
                BindData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
