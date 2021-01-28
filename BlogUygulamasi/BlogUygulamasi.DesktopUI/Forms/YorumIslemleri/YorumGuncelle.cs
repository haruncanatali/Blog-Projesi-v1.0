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

namespace BlogUygulamasi.DesktopUI.Forms.YorumIslemleri
{
    public partial class YorumGuncelle : Form
    {
        IYorumService _yorumService;
        public YorumGuncelle()
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

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            Yorum yorum = _yorumService.GetYorum(c => c.YorumId == id);

            yorum.YorumAd = adTxt.Text.ToString();
            yorum.YorumSoyad = soyadTxt.Text.ToString();
            yorum.YorumMail = mailTxt.Text.ToString();
            yorum.YorumIcerik = icerikTxt.Text.ToString();

            try
            {
                _yorumService.UpdateYorum(yorum);
                BindData();
                MessageBox.Show("Yorum başarıyla güncellendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            adTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            soyadTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            mailTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            icerikTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
        }
    }
}
