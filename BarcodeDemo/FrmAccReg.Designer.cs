namespace BarcodeDemo
{
    partial class FrmAccReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccReg));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnInquiry = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtRePwd = new DevExpress.XtraEditors.TextEdit();
            this.btnNewM = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveM = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Controller = this.barAndDockingController1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnNew,
            this.btnInquiry,
            this.btnSave,
            this.btnDelete});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(492, 32);
            // 
            // btnNew
            // 
            this.btnNew.Caption = "Làm mới";
            this.btnNew.Id = 1;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnInquiry
            // 
            this.btnInquiry.Caption = "Truy vấn";
            this.btnInquiry.Hint = "Truy vấn";
            this.btnInquiry.Id = 2;
            this.btnInquiry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInquiry.ImageOptions.Image")));
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInquiry_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtFullName);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtUser);
            this.panelControl1.Controls.Add(this.txtRePwd);
            this.panelControl1.Controls.Add(this.btnNewM);
            this.panelControl1.Controls.Add(this.btnSaveM);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtPwd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(492, 211);
            this.panelControl1.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(161, 19);
            this.txtFullName.MenuManager = this.ribbonControl1;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(309, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Họ và tên";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(161, 45);
            this.txtUser.MenuManager = this.ribbonControl1;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(309, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(161, 97);
            this.txtRePwd.MenuManager = this.ribbonControl1;
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.Properties.PasswordChar = '*';
            this.txtRePwd.Size = new System.Drawing.Size(309, 20);
            this.txtRePwd.TabIndex = 4;
            // 
            // btnNewM
            // 
            this.btnNewM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewM.ImageOptions.Image")));
            this.btnNewM.Location = new System.Drawing.Point(275, 137);
            this.btnNewM.Name = "btnNewM";
            this.btnNewM.Size = new System.Drawing.Size(114, 44);
            this.btnNewM.TabIndex = 19;
            this.btnNewM.Text = "Làm mới";
            this.btnNewM.Click += new System.EventHandler(this.btnNewM_Click);
            // 
            // btnSaveM
            // 
            this.btnSaveM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveM.ImageOptions.Image")));
            this.btnSaveM.Location = new System.Drawing.Point(121, 137);
            this.btnSaveM.Name = "btnSaveM";
            this.btnSaveM.Size = new System.Drawing.Size(114, 44);
            this.btnSaveM.TabIndex = 18;
            this.btnSaveM.Text = "Lưu";
            this.btnSaveM.Click += new System.EventHandler(this.btnSaveM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(161, 71);
            this.txtPwd.MenuManager = this.ribbonControl1;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Properties.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(309, 20);
            this.txtPwd.TabIndex = 3;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.AppearancesRibbon.FormCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAndDockingController1.AppearancesRibbon.FormCaption.Options.UseFont = true;
            this.barAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Default;
            // 
            // FrmAccReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 243);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccReg";
            this.Ribbon = this.ribbonControl1;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.Load += new System.EventHandler(this.FrmAccReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnInquiry;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private DevExpress.XtraEditors.SimpleButton btnNewM;
        private DevExpress.XtraEditors.SimpleButton btnSaveM;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtRePwd;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
    }
}