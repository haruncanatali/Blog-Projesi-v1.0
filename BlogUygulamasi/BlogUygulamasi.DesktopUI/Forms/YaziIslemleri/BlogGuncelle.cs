using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
using BlogUygulamasi.Entities.Concrete;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class BlogGuncelle : Form
    {
        IYaziService _yaziService;
        public BlogGuncelle()
        {
            InitializeComponent();
            _yaziService = InstanceFactory.GetInstance<IYaziService>();
        }

        private void BindData()
        {
            gridControl1.DataSource = _yaziService.GetAllYazis();
            gridControl1.Refresh();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            baslikTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]).ToString();
            yazarTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]).ToString();
            baglantiTxt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2]).ToString();
            htmlEditControl1.DocumentHTML = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3]).ToString();

        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString());

                Yazi yazi = _yaziService.GetYazi(c => c.YaziId == id);

                yazi.YaziBaslik = baslikTxt.Text.ToString();
                yazi.YaziResimUrl = baglantiTxt.Text.ToString();
                yazi.YaziIcerik = htmlEditControl1.DocumentHTML.ToString();
                yazi.YaziYazar = yazarTxt.Text.ToString();

                _yaziService.UpdateYazi(yazi);

                MessageBox.Show("Güncelleme Başarılı Oldu.");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void kayitGoruntuleBtn_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
