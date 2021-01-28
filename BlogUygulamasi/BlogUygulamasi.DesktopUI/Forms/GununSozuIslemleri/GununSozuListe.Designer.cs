namespace BlogUygulamasi.DesktopUI.Forms.GununSozuIslemleri
{
    partial class GununSozuListe
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
            this.GununSozuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GununSozuFotoUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GununSozuIcerik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GununSozuSahip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GununSozuTarih = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GununSozuId,
            this.GununSozuFotoUrl,
            this.GununSozuIcerik,
            this.GununSozuSahip,
            this.GununSozuTarih});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            // 
            // GununSozuId
            // 
            this.GununSozuId.Caption = "gridColumn1";
            this.GununSozuId.FieldName = "GununSozuId";
            this.GununSozuId.Name = "GununSozuId";
            this.GununSozuId.OptionsColumn.AllowEdit = false;
            this.GununSozuId.OptionsColumn.ReadOnly = true;
            // 
            // GununSozuFotoUrl
            // 
            this.GununSozuFotoUrl.Caption = "Fotoğraf Bağlantısı";
            this.GununSozuFotoUrl.FieldName = "GununSozuFotoUrl";
            this.GununSozuFotoUrl.Name = "GununSozuFotoUrl";
            this.GununSozuFotoUrl.OptionsColumn.AllowEdit = false;
            this.GununSozuFotoUrl.OptionsColumn.ReadOnly = true;
            this.GununSozuFotoUrl.Visible = true;
            this.GununSozuFotoUrl.VisibleIndex = 0;
            // 
            // GununSozuIcerik
            // 
            this.GununSozuIcerik.Caption = "İçerik";
            this.GununSozuIcerik.FieldName = "GununSozuIcerik";
            this.GununSozuIcerik.Name = "GununSozuIcerik";
            this.GununSozuIcerik.OptionsColumn.AllowEdit = false;
            this.GununSozuIcerik.OptionsColumn.ReadOnly = true;
            this.GununSozuIcerik.Visible = true;
            this.GununSozuIcerik.VisibleIndex = 1;
            // 
            // GununSozuSahip
            // 
            this.GununSozuSahip.Caption = "Günün Sözünü Söyleyen";
            this.GununSozuSahip.FieldName = "GununSozuSahip";
            this.GununSozuSahip.Name = "GununSozuSahip";
            this.GununSozuSahip.OptionsColumn.AllowEdit = false;
            this.GununSozuSahip.OptionsColumn.ReadOnly = true;
            this.GununSozuSahip.Visible = true;
            this.GununSozuSahip.VisibleIndex = 2;
            // 
            // GununSozuTarih
            // 
            this.GununSozuTarih.Caption = "Tarih";
            this.GununSozuTarih.FieldName = "GununSozuTarih";
            this.GununSozuTarih.Name = "GununSozuTarih";
            this.GununSozuTarih.OptionsColumn.AllowEdit = false;
            this.GununSozuTarih.OptionsColumn.ReadOnly = true;
            this.GununSozuTarih.Visible = true;
            this.GununSozuTarih.VisibleIndex = 3;
            // 
            // GununSozuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "GununSozuListe";
            this.Text = "GununSozuListe";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuId;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuFotoUrl;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuIcerik;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuSahip;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuTarih;
    }
}