namespace BlogUygulamasi.DesktopUI.Forms.YorumIslemleri
{
    partial class YorumEkle
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.adTxt = new DevExpress.XtraEditors.TextEdit();
            this.soyadTxt = new DevExpress.XtraEditors.TextEdit();
            this.mailTxt = new DevExpress.XtraEditors.TextEdit();
            this.icerikTxt = new System.Windows.Forms.RichTextBox();
            this.yorumEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.blogCbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.blogCbx);
            this.groupControl1.Controls.Add(this.yorumEkleBtn);
            this.groupControl1.Controls.Add(this.icerikTxt);
            this.groupControl1.Controls.Add(this.mailTxt);
            this.groupControl1.Controls.Add(this.soyadTxt);
            this.groupControl1.Controls.Add(this.adTxt);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 215);
            this.groupControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(457, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Yorum İçeriği";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(39, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Soyad :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mail :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(66, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Ad :";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(123, 40);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(182, 20);
            this.adTxt.TabIndex = 6;
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(123, 85);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(182, 20);
            this.soyadTxt.TabIndex = 6;
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(123, 131);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(182, 20);
            this.mailTxt.TabIndex = 6;
            // 
            // icerikTxt
            // 
            this.icerikTxt.Location = new System.Drawing.Point(388, 49);
            this.icerikTxt.Name = "icerikTxt";
            this.icerikTxt.Size = new System.Drawing.Size(251, 152);
            this.icerikTxt.TabIndex = 7;
            this.icerikTxt.Text = "";
            // 
            // yorumEkleBtn
            // 
            this.yorumEkleBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.yorumEkleBtn.Location = new System.Drawing.Point(669, 20);
            this.yorumEkleBtn.Name = "yorumEkleBtn";
            this.yorumEkleBtn.Size = new System.Drawing.Size(129, 193);
            this.yorumEkleBtn.TabIndex = 8;
            this.yorumEkleBtn.Text = "Yorum Ekle";
            this.yorumEkleBtn.Click += new System.EventHandler(this.yorumEkleBtn_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(52, 180);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 19);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Blog :";
            // 
            // blogCbx
            // 
            this.blogCbx.FormattingEnabled = true;
            this.blogCbx.Location = new System.Drawing.Point(123, 180);
            this.blogCbx.Name = "blogCbx";
            this.blogCbx.Size = new System.Drawing.Size(182, 21);
            this.blogCbx.TabIndex = 9;
            // 
            // YorumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 215);
            this.Controls.Add(this.groupControl1);
            this.Name = "YorumEkle";
            this.Text = "YorumEkle";
            this.Load += new System.EventHandler(this.YorumEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soyadTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox blogCbx;
        private DevExpress.XtraEditors.SimpleButton yorumEkleBtn;
        private System.Windows.Forms.RichTextBox icerikTxt;
        private DevExpress.XtraEditors.TextEdit mailTxt;
        private DevExpress.XtraEditors.TextEdit soyadTxt;
        private DevExpress.XtraEditors.TextEdit adTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}