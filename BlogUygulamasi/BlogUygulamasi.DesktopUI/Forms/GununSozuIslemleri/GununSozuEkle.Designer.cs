namespace BlogUygulamasi.DesktopUI.Forms.GununSozuIslemleri
{
    partial class GununSozuEkle
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.fotoUrlTxt = new DevExpress.XtraEditors.TextEdit();
            this.icerikTxt = new System.Windows.Forms.RichTextBox();
            this.sahipTxt = new DevExpress.XtraEditors.TextEdit();
            this.gununSozuEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.tarihDateEdx = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUrlTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tarihDateEdx);
            this.groupControl1.Controls.Add(this.gununSozuEkleBtn);
            this.groupControl1.Controls.Add(this.icerikTxt);
            this.groupControl1.Controls.Add(this.sahipTxt);
            this.groupControl1.Controls.Add(this.fotoUrlTxt);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 216);
            this.groupControl1.TabIndex = 0;
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
            // fotoUrlTxt
            // 
            this.fotoUrlTxt.Location = new System.Drawing.Point(214, 38);
            this.fotoUrlTxt.Name = "fotoUrlTxt";
            this.fotoUrlTxt.Size = new System.Drawing.Size(166, 20);
            this.fotoUrlTxt.TabIndex = 1;
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
            // gununSozuEkleBtn
            // 
            this.gununSozuEkleBtn.Location = new System.Drawing.Point(440, 122);
            this.gununSozuEkleBtn.Name = "gununSozuEkleBtn";
            this.gununSozuEkleBtn.Size = new System.Drawing.Size(355, 64);
            this.gununSozuEkleBtn.TabIndex = 3;
            this.gununSozuEkleBtn.Text = "Günün Sözünü Ekle";
            this.gununSozuEkleBtn.Click += new System.EventHandler(this.gununSozuEkleBtn_Click);
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
            // GununSozuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.groupControl1);
            this.Name = "GununSozuEkle";
            this.Text = "GununSozuEkle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUrlTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahipTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdx.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit tarihDateEdx;
        private DevExpress.XtraEditors.SimpleButton gununSozuEkleBtn;
        private System.Windows.Forms.RichTextBox icerikTxt;
        private DevExpress.XtraEditors.TextEdit sahipTxt;
        private DevExpress.XtraEditors.TextEdit fotoUrlTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}