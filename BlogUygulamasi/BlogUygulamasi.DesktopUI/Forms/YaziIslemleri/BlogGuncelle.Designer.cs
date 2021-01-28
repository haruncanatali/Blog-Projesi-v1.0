namespace BlogUygulamasi.DesktopUI.Forms
{
    partial class BlogGuncelle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlogGuncelle));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kayitGoruntuleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.baglantiTxt = new DevExpress.XtraEditors.TextEdit();
            this.yazarTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.baslikTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.htmlEditControl1 = new Zoople.HTMLEditControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baglantiTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslikTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 241);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.kaydetBtn);
            this.groupControl1.Controls.Add(this.kayitGoruntuleBtn);
            this.groupControl1.Controls.Add(this.baglantiTxt);
            this.groupControl1.Controls.Add(this.yazarTxt);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.baslikTxt);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(577, 241);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(223, 483);
            this.groupControl1.TabIndex = 3;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetBtn.Location = new System.Drawing.Point(5, 416);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(213, 62);
            this.kaydetBtn.TabIndex = 5;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // kayitGoruntuleBtn
            // 
            this.kayitGoruntuleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kayitGoruntuleBtn.Location = new System.Drawing.Point(4, 346);
            this.kayitGoruntuleBtn.Name = "kayitGoruntuleBtn";
            this.kayitGoruntuleBtn.Size = new System.Drawing.Size(213, 64);
            this.kayitGoruntuleBtn.TabIndex = 6;
            this.kayitGoruntuleBtn.Text = "Kayıt Görüntüle";
            this.kayitGoruntuleBtn.Click += new System.EventHandler(this.kayitGoruntuleBtn_Click);
            // 
            // baglantiTxt
            // 
            this.baglantiTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.baglantiTxt.Location = new System.Drawing.Point(111, 172);
            this.baglantiTxt.Name = "baglantiTxt";
            this.baglantiTxt.Size = new System.Drawing.Size(100, 20);
            this.baglantiTxt.TabIndex = 10;
            // 
            // yazarTxt
            // 
            this.yazarTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yazarTxt.Location = new System.Drawing.Point(111, 136);
            this.yazarTxt.Name = "yazarTxt";
            this.yazarTxt.Size = new System.Drawing.Size(100, 20);
            this.yazarTxt.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 15);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Yazı Başlığı :";
            // 
            // baslikTxt
            // 
            this.baslikTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.baslikTxt.Location = new System.Drawing.Point(111, 100);
            this.baslikTxt.Name = "baslikTxt";
            this.baslikTxt.Size = new System.Drawing.Size(100, 20);
            this.baslikTxt.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 15);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Yazı Yazarı :";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 174);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 15);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Resim Bağlantısı :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.htmlEditControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 241);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(577, 483);
            this.groupControl2.TabIndex = 4;
            // 
            // htmlEditControl1
            // 
            this.htmlEditControl1.AcceptsReturn = true;
            this.htmlEditControl1.AllowDragInternal = true;
            this.htmlEditControl1.BaseURL = null;
            this.htmlEditControl1.CleanMSWordHTMLOnPaste = true;
            this.htmlEditControl1.CodeEditor.Enabled = true;
            this.htmlEditControl1.CodeEditor.Locked = false;
            this.htmlEditControl1.CodeEditor.WordWrap = false;
            this.htmlEditControl1.CSSText = null;
            this.htmlEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditControl1.DocumentHTML = null;
            this.htmlEditControl1.EditingDisabled = false;
            this.htmlEditControl1.EnableInlineSpelling = false;
            this.htmlEditControl1.FontsList = null;
            this.htmlEditControl1.HiddenButtons = null;
            this.htmlEditControl1.ImageStorageLocation = null;
            this.htmlEditControl1.InCodeView = false;
            this.htmlEditControl1.LanguageFile = null;
            this.htmlEditControl1.LicenceKey = null;
            this.htmlEditControl1.LicenceKeyInlineSpelling = null;
            this.htmlEditControl1.Location = new System.Drawing.Point(2, 20);
            this.htmlEditControl1.Name = "htmlEditControl1";
            this.htmlEditControl1.Size = new System.Drawing.Size(573, 461);
            this.htmlEditControl1.SpellingAutoCorrectionList = ((System.Collections.Hashtable)(resources.GetObject("htmlEditControl1.SpellingAutoCorrectionList")));
            this.htmlEditControl1.TabIndex = 3;
            this.htmlEditControl1.ToolstripImageScalingSize = new System.Drawing.Size(16, 16);
            this.htmlEditControl1.UseParagraphAsDefault = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "YaziId";
            this.gridColumn1.FieldName = "YaziId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Yazı Başlığı";
            this.gridColumn2.FieldName = "YaziBaslik";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Yazı Resim Bağlantısı";
            this.gridColumn3.FieldName = "YaziResimUrl";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Yazı İçeriği";
            this.gridColumn4.FieldName = "YaziIcerik";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Yazı Yazarı";
            this.gridColumn5.FieldName = "YaziYazar";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // BlogGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "BlogGuncelle";
            this.Text = "BlogGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baglantiTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baslikTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private DevExpress.XtraEditors.SimpleButton kayitGoruntuleBtn;
        private DevExpress.XtraEditors.TextEdit baglantiTxt;
        private DevExpress.XtraEditors.TextEdit yazarTxt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit baslikTxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Zoople.HTMLEditControl htmlEditControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}