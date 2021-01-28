namespace BlogUygulamasi.DesktopUI.Forms
{
    partial class BlogOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlogOlustur));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.icerikTemizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.kaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cikisBtn = new DevExpress.XtraEditors.SimpleButton();
            this.anaResimUrl = new System.Windows.Forms.RichTextBox();
            this.yazarTxt = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.baslikTxt = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.htmlTextEditorTxt = new Zoople.HTMLEditControl();
            this.kategoriCbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.kategoriCbx);
            this.groupControl1.Controls.Add(this.icerikTemizleBtn);
            this.groupControl1.Controls.Add(this.kaydetBtn);
            this.groupControl1.Controls.Add(this.cikisBtn);
            this.groupControl1.Controls.Add(this.anaResimUrl);
            this.groupControl1.Controls.Add(this.yazarTxt);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.baslikTxt);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 356);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(905, 159);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "İşlemler";
            // 
            // icerikTemizleBtn
            // 
            this.icerikTemizleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.icerikTemizleBtn.Location = new System.Drawing.Point(540, 32);
            this.icerikTemizleBtn.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.icerikTemizleBtn.Name = "icerikTemizleBtn";
            this.icerikTemizleBtn.Size = new System.Drawing.Size(114, 115);
            this.icerikTemizleBtn.TabIndex = 4;
            this.icerikTemizleBtn.Text = "Blog İçeriğini Temizle";
            this.icerikTemizleBtn.Click += new System.EventHandler(this.AtributesClick);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydetBtn.Location = new System.Drawing.Point(659, 32);
            this.kaydetBtn.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(114, 115);
            this.kaydetBtn.TabIndex = 4;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Click += new System.EventHandler(this.AtributesClick);
            // 
            // cikisBtn
            // 
            this.cikisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisBtn.Location = new System.Drawing.Point(779, 32);
            this.cikisBtn.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(114, 115);
            this.cikisBtn.TabIndex = 4;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.Click += new System.EventHandler(this.AtributesClick);
            // 
            // anaResimUrl
            // 
            this.anaResimUrl.Location = new System.Drawing.Point(211, 53);
            this.anaResimUrl.Name = "anaResimUrl";
            this.anaResimUrl.Size = new System.Drawing.Size(173, 94);
            this.anaResimUrl.TabIndex = 3;
            this.anaResimUrl.Text = "";
            // 
            // yazarTxt
            // 
            this.yazarTxt.Location = new System.Drawing.Point(105, 116);
            this.yazarTxt.Name = "yazarTxt";
            this.yazarTxt.Size = new System.Drawing.Size(100, 21);
            this.yazarTxt.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Yazar :";
            // 
            // baslikTxt
            // 
            this.baslikTxt.Location = new System.Drawing.Point(105, 32);
            this.baslikTxt.Name = "baslikTxt";
            this.baslikTxt.Size = new System.Drawing.Size(100, 21);
            this.baslikTxt.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Başlık :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(211, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(173, 19);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Yazı Başlık Resim Url";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kategori :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.htmlTextEditorTxt);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(905, 356);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Blog İçerik";
            // 
            // htmlTextEditorTxt
            // 
            this.htmlTextEditorTxt.AcceptsReturn = true;
            this.htmlTextEditorTxt.AllowDragInternal = true;
            this.htmlTextEditorTxt.BaseURL = null;
            this.htmlTextEditorTxt.CleanMSWordHTMLOnPaste = true;
            this.htmlTextEditorTxt.CodeEditor.Enabled = true;
            this.htmlTextEditorTxt.CodeEditor.Locked = false;
            this.htmlTextEditorTxt.CodeEditor.WordWrap = false;
            this.htmlTextEditorTxt.CSSText = null;
            this.htmlTextEditorTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlTextEditorTxt.DocumentHTML = null;
            this.htmlTextEditorTxt.EditingDisabled = false;
            this.htmlTextEditorTxt.EnableInlineSpelling = false;
            this.htmlTextEditorTxt.FontsList = null;
            this.htmlTextEditorTxt.HiddenButtons = null;
            this.htmlTextEditorTxt.ImageStorageLocation = null;
            this.htmlTextEditorTxt.InCodeView = false;
            this.htmlTextEditorTxt.LanguageFile = null;
            this.htmlTextEditorTxt.LicenceKey = null;
            this.htmlTextEditorTxt.LicenceKeyInlineSpelling = null;
            this.htmlTextEditorTxt.Location = new System.Drawing.Point(2, 20);
            this.htmlTextEditorTxt.Name = "htmlTextEditorTxt";
            this.htmlTextEditorTxt.Size = new System.Drawing.Size(901, 334);
            this.htmlTextEditorTxt.SpellingAutoCorrectionList = ((System.Collections.Hashtable)(resources.GetObject("htmlTextEditorTxt.SpellingAutoCorrectionList")));
            this.htmlTextEditorTxt.TabIndex = 0;
            this.htmlTextEditorTxt.ToolstripImageScalingSize = new System.Drawing.Size(16, 16);
            this.htmlTextEditorTxt.UseParagraphAsDefault = true;
            // 
            // kategoriCbx
            // 
            this.kategoriCbx.FormattingEnabled = true;
            this.kategoriCbx.Location = new System.Drawing.Point(105, 75);
            this.kategoriCbx.Name = "kategoriCbx";
            this.kategoriCbx.Size = new System.Drawing.Size(100, 21);
            this.kategoriCbx.TabIndex = 5;
            // 
            // BlogOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 515);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "BlogOlustur";
            this.Text = "Blog Oluşturma Penceresi";
            this.Load += new System.EventHandler(this.BlogOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox baslikTxt;
        private System.Windows.Forms.TextBox yazarTxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton icerikTemizleBtn;
        private DevExpress.XtraEditors.SimpleButton kaydetBtn;
        private DevExpress.XtraEditors.SimpleButton cikisBtn;
        private System.Windows.Forms.RichTextBox anaResimUrl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Zoople.HTMLEditControl htmlTextEditorTxt;
        private System.Windows.Forms.ComboBox kategoriCbx;
    }
}