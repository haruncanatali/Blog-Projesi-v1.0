namespace BlogUygulamasi.DesktopUI.Forms.AdminIslemleri
{
    partial class AdminListe
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
            this.AdminId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdminUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdminPassword = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.AdminId,
            this.AdminUserName,
            this.AdminPassword});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            // 
            // AdminId
            // 
            this.AdminId.Caption = "gridColumn1";
            this.AdminId.FieldName = "AdminId";
            this.AdminId.Name = "AdminId";
            this.AdminId.OptionsColumn.AllowEdit = false;
            this.AdminId.OptionsColumn.ReadOnly = true;
            // 
            // AdminUserName
            // 
            this.AdminUserName.Caption = "Admin Kullanıcı Adı";
            this.AdminUserName.FieldName = "AdminUsername";
            this.AdminUserName.Name = "AdminUserName";
            this.AdminUserName.OptionsColumn.AllowEdit = false;
            this.AdminUserName.OptionsColumn.ReadOnly = true;
            this.AdminUserName.Visible = true;
            this.AdminUserName.VisibleIndex = 0;
            // 
            // AdminPassword
            // 
            this.AdminPassword.Caption = "Admin Şifresi";
            this.AdminPassword.FieldName = "AdminPassword";
            this.AdminPassword.Name = "AdminPassword";
            this.AdminPassword.OptionsColumn.AllowEdit = false;
            this.AdminPassword.OptionsColumn.ReadOnly = true;
            this.AdminPassword.Visible = true;
            this.AdminPassword.VisibleIndex = 1;
            // 
            // AdminListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "AdminListe";
            this.Text = "AdminListe";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AdminId;
        private DevExpress.XtraGrid.Columns.GridColumn AdminUserName;
        private DevExpress.XtraGrid.Columns.GridColumn AdminPassword;
    }
}