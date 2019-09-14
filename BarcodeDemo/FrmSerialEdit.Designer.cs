namespace BarcodeDemo
{
    partial class FrmSerialEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerialEdit));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnInquiry = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNewSerial = new DevExpress.XtraEditors.TextEdit();
            this.txtOldSerial = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveM = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldSerial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
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
            // 
            // btnInquiry
            // 
            this.btnInquiry.Caption = "Truy vấn";
            this.btnInquiry.Hint = "Truy vấn";
            this.btnInquiry.Id = 2;
            this.btnInquiry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInquiry.ImageOptions.Image")));
            this.btnInquiry.Name = "btnInquiry";
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
            this.panelControl1.Controls.Add(this.txtNewSerial);
            this.panelControl1.Controls.Add(this.txtOldSerial);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSaveM);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(492, 164);
            this.panelControl1.TabIndex = 3;
            // 
            // txtNewSerial
            // 
            this.txtNewSerial.Location = new System.Drawing.Point(161, 51);
            this.txtNewSerial.MenuManager = this.ribbonControl1;
            this.txtNewSerial.Name = "txtNewSerial";
            this.txtNewSerial.Size = new System.Drawing.Size(309, 20);
            this.txtNewSerial.TabIndex = 22;
            // 
            // txtOldSerial
            // 
            this.txtOldSerial.Enabled = false;
            this.txtOldSerial.Location = new System.Drawing.Point(161, 21);
            this.txtOldSerial.MenuManager = this.ribbonControl1;
            this.txtOldSerial.Name = "txtOldSerial";
            this.txtOldSerial.Size = new System.Drawing.Size(309, 20);
            this.txtOldSerial.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Serial cũ";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(275, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 44);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveM
            // 
            this.btnSaveM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveM.ImageOptions.Image")));
            this.btnSaveM.Location = new System.Drawing.Point(117, 101);
            this.btnSaveM.Name = "btnSaveM";
            this.btnSaveM.Size = new System.Drawing.Size(114, 44);
            this.btnSaveM.TabIndex = 10;
            this.btnSaveM.Text = "Lưu";
            this.btnSaveM.Click += new System.EventHandler(this.btnSaveM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serial mới";
            // 
            // FrmSerialEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 196);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSerialEdit";
            this.Ribbon = this.ribbonControl1;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật Serial";
            this.Load += new System.EventHandler(this.FrmLotReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldSerial.Properties)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSaveM;
        private DevExpress.XtraEditors.TextEdit txtOldSerial;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtNewSerial;
    }
}