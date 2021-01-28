namespace BlogUygulamasi.DesktopUI.Forms.GununSozuIslemleri
{
    partial class GununSozuGuncelle
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tarihDateEdx = new DevExpress.XtraEditors.DateEdit();
            this.gununSozuGuncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.icerikTxt = new System.Windows.Forms.RichTextBox();
            this.sahipTxt = new DevExpress.XtraEditors.TextEdit();
            this.fotoUrlTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUrlTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 232);
            this.gridControl1.TabIndex = 0;
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
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tarihDateEdx);
            this.groupControl1.Controls.Add(this.gununSozuGuncelleBtn);
            this.groupControl1.Controls.Add(this.icerikTxt);
            this.groupControl1.Controls.Add(this.sahipTxt);
            this.groupControl1.Controls.Add(this.fotoUrlTxt);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 232);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 206);
            this.groupControl1.TabIndex = 1;
            // 
            // tarihDateEdx
            // 
            this.tarihDateEdx.EditValue = null;
            this.tarihDateEdx.Location = new System.Drawing.Point(629, 76);
            this.tarihDateEdx.Name = "tarihDateEdx";
            this.tarihDateEdx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarihDateEdx.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarihDateEdx.Size = new System.Drawing.Size(166, 20);
            this.tarihDateEdx.TabIndex = 4;
            // 
            // gununSozuGuncelleBtn
            // 
            this.gununSozuGuncelleBtn.Location = new System.Drawing.Point(440, 122);
            this.gununSozuGuncelleBtn.Name = "gununSozuGuncelleBtn";
            this.gununSozuGuncelleBtn.Size = new System.Drawing.Size(355, 64);
            this.gununSozuGuncelleBtn.TabIndex = 3;
            this.gununSozuGuncelleBtn.Text = "Günün Sözünü Güncelle";
            this.gununSozuGuncelleBtn.Click += new System.EventHandler(this.gununSozuGuncelleBtn_Click);
            // 
            // icerikTxt
            // 
            this.icerikTxt.Location = new System.Drawing.Point(214, 79);
            this.icerikTxt.Name = "icerikTxt";
            this.icerikTxt.Size = new System.Drawing.Size(166, 107);
            this.icerikTxt.TabIndex = 2;
            this.icerikTxt.Text = "";
            // 
            // sahipTxt
            // 
            this.sahipTxt.Location = new System.Drawing.Point(629, 38);
            this.sahipTxt.Name = "sahipTxt";
            this.sahipTxt.Size = new System.Drawing.Size(166, 20);
            this.sahipTxt.TabIndex = 1;
            // 
            // fotoUrlTxt
            // 
            this.fotoUrlTxt.Location = new System.Drawing.Point(214, 38);
            this.fotoUrlTxt.Name = "fotoUrlTxt";
            this.fotoUrlTxt.Size = new System.Drawing.Size(166, 20);
            this.fotoUrlTxt.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(560, 74);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 23);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tarih :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(430, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(192, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Günün Sözü Sahibi :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(140, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "İçerik :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(195, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fotoğraf Bağlantısı :";
            // 
            // GununSozuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "GununSozuGuncelle";
            this.Text = "GununSozuGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUrlTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit tarihDateEdx;
        private DevExpress.XtraEditors.SimpleButton gununSozuGuncelleBtn;
        private System.Windows.Forms.RichTextBox icerikTxt;
        private DevExpress.XtraEditors.TextEdit sahipTxt;
        private DevExpress.XtraEditors.TextEdit fotoUrlTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuId;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuFotoUrl;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuIcerik;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuSahip;
        private DevExpress.XtraGrid.Columns.GridColumn GununSozuTarih;
    }
}