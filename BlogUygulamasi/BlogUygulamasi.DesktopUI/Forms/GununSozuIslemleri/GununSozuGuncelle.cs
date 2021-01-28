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

namespace BlogUygulamasi.DesktopUI.Forms.GununSozuIslemleri
{
    public partial class GununSozuGuncelle : Form
    {
        IGununSozuService _gununSozuService;
        int id;
        public GununSozuGuncelle()
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
            id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());
            fotoUrlTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            icerikTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            sahipTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();
            tarihDateEdx.DateTime = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]));
        }

        private void gununSozuGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GununSozu gununSozu = _gununSozuService.GetGununSozu(c => c.GununSozuId == id);

                gununSozu.GununSozuFotoUrl = fotoUrlTxt.Text.ToString();
                gununSozu.GununSozuIcerik = icerikTxt.Text.ToString();
                gununSozu.GununSozuSahip = sahipTxt.Text.ToString();
                gununSozu.GununSozuTarih = tarihDateEdx.DateTime;

                _gununSozuService.UpdateGununSozu(gununSozu);
                MessageBox.Show("Güncelleme başarılı oldu.");
                BindData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
