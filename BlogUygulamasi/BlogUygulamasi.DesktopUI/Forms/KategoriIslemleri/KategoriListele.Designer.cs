namespace BlogUygulamasi.DesktopUI.Forms.KategoriIslemleri
{
    partial class KategoriListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KategoriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KategoriAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KategoriAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KategoriId,
            this.KategoriAd,
            this.KategoriAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            // 
            // KategoriId
            // 
            this.KategoriId.Caption = "gridColumn1";
            this.KategoriId.FieldName = "KategoriId";
            this.KategoriId.Name = "KategoriId";
            // 
            // KategoriAd
            // 
            this.KategoriAd.Caption = "Kategori Adı";
            this.KategoriAd.FieldName = "KategoriAd";
            this.KategoriAd.Name = "KategoriAd";
            this.KategoriAd.Visible = true;
            this.KategoriAd.VisibleIndex = 0;
            // 
            // KategoriAciklama
            // 
            this.KategoriAciklama.Caption = "Kategori Açıklaması";
            this.KategoriAciklama.FieldName = "KategoriAciklama";
            this.KategoriAciklama.Name = "KategoriAciklama";
            this.KategoriAciklama.Visible = true;
            this.KategoriAciklama.VisibleIndex = 1;
            // 
            // KategoriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "KategoriListele";
            this.Text = "KategoriListele";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KategoriId;
        private DevExpress.XtraGrid.Columns.GridColumn KategoriAd;
        private DevExpress.XtraGrid.Columns.GridColumn KategoriAciklama;
    }
}