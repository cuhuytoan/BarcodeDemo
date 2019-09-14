namespace BarcodeDemo
{
    partial class FrmLotReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotReg));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnInquiry = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtPallet = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalTem = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSerial = new DevExpress.XtraEditors.MemoEdit();
            this.dtExpectedDate = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProductNm = new DevExpress.XtraEditors.LookUpEdit();
            this.cboPatchNo = new System.Windows.Forms.ComboBox();
            this.cboProductLabel = new System.Windows.Forms.ComboBox();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShiftNo = new System.Windows.Forms.ComboBox();
            this.txtLot = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewM = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveM = new DevExpress.XtraEditors.SimpleButton();
            this.dtDateManu = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPallet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpectedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpectedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductNm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateManu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateManu.Properties)).BeginInit();
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
            // barAndDockingController1
            // 
            this.barAndDockingController1.AppearancesRibbon.FormCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barAndDockingController1.AppearancesRibbon.FormCaption.Options.UseFont = true;
            this.barAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Default;
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
            this.panelControl1.Controls.Add(this.txtPallet);
            this.panelControl1.Controls.Add(this.label11);
            this.panelControl1.Controls.Add(this.txtTotalTem);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.txtSerial);
            this.panelControl1.Controls.Add(this.dtExpectedDate);
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.cboProductNm);
            this.panelControl1.Controls.Add(this.cboPatchNo);
            this.panelControl1.Controls.Add(this.cboProductLabel);
            this.panelControl1.Controls.Add(this.cboEmp);
            this.panelControl1.Controls.Add(this.label10);
            this.panelControl1.Controls.Add(this.txtShiftNo);
            this.panelControl1.Controls.Add(this.txtLot);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.btnNewM);
            this.panelControl1.Controls.Add(this.btnSaveM);
            this.panelControl1.Controls.Add(this.dtDateManu);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(492, 476);
            this.panelControl1.TabIndex = 3;
            // 
            // txtPallet
            // 
            this.txtPallet.Location = new System.Drawing.Point(161, 323);
            this.txtPallet.MenuManager = this.ribbonControl1;
            this.txtPallet.Name = "txtPallet";
            this.txtPallet.Properties.Mask.EditMask = "N0";
            this.txtPallet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPallet.Size = new System.Drawing.Size(309, 20);
            this.txtPallet.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Số Pallet";
            // 
            // txtTotalTem
            // 
            this.txtTotalTem.Location = new System.Drawing.Point(161, 297);
            this.txtTotalTem.MenuManager = this.ribbonControl1;
            this.txtTotalTem.Name = "txtTotalTem";
            this.txtTotalTem.Properties.Mask.EditMask = "N0";
            this.txtTotalTem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalTem.Size = new System.Drawing.Size(309, 20);
            this.txtTotalTem.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tổng số tem";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(161, 185);
            this.txtSerial.MenuManager = this.ribbonControl1;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(309, 106);
            this.txtSerial.TabIndex = 7;
            this.txtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyDown);
            this.txtSerial.Leave += new System.EventHandler(this.txtSerial_Leave);
            // 
            // dtExpectedDate
            // 
            this.dtExpectedDate.EditValue = null;
            this.dtExpectedDate.Location = new System.Drawing.Point(162, 159);
            this.dtExpectedDate.MenuManager = this.ribbonControl1;
            this.dtExpectedDate.Name = "dtExpectedDate";
            this.dtExpectedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtExpectedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtExpectedDate.Size = new System.Drawing.Size(309, 20);
            this.dtExpectedDate.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ngày kích hoạt";
            // 
            // cboProductNm
            // 
            this.cboProductNm.Location = new System.Drawing.Point(161, 48);
            this.cboProductNm.MenuManager = this.ribbonControl1;
            this.cboProductNm.Name = "cboProductNm";
            this.cboProductNm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProductNm.Properties.NullText = "";
            this.cboProductNm.Size = new System.Drawing.Size(309, 20);
            this.cboProductNm.TabIndex = 2;
            this.cboProductNm.EditValueChanged += new System.EventHandler(this.cboProductNm_EditValueChanged_1);
            // 
            // cboPatchNo
            // 
            this.cboPatchNo.FormattingEnabled = true;
            this.cboPatchNo.Location = new System.Drawing.Point(161, 103);
            this.cboPatchNo.Name = "cboPatchNo";
            this.cboPatchNo.Size = new System.Drawing.Size(309, 21);
            this.cboPatchNo.TabIndex = 4;
            // 
            // cboProductLabel
            // 
            this.cboProductLabel.FormattingEnabled = true;
            this.cboProductLabel.Location = new System.Drawing.Point(162, 351);
            this.cboProductLabel.Name = "cboProductLabel";
            this.cboProductLabel.Size = new System.Drawing.Size(309, 21);
            this.cboProductLabel.TabIndex = 10;
            // 
            // cboEmp
            // 
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(162, 378);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(309, 21);
            this.cboEmp.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Công nhân thực hiện";
            // 
            // txtShiftNo
            // 
            this.txtShiftNo.FormattingEnabled = true;
            this.txtShiftNo.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3",
            "Hành chính"});
            this.txtShiftNo.Location = new System.Drawing.Point(161, 74);
            this.txtShiftNo.Name = "txtShiftNo";
            this.txtShiftNo.Size = new System.Drawing.Size(309, 21);
            this.txtShiftNo.TabIndex = 3;
            // 
            // txtLot
            // 
            this.txtLot.Enabled = false;
            this.txtLot.Location = new System.Drawing.Point(161, 21);
            this.txtLot.MenuManager = this.ribbonControl1;
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(309, 20);
            this.txtLot.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lô mã";
            // 
            // btnNewM
            // 
            this.btnNewM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewM.ImageOptions.Image")));
            this.btnNewM.Location = new System.Drawing.Point(266, 420);
            this.btnNewM.Name = "btnNewM";
            this.btnNewM.Size = new System.Drawing.Size(114, 44);
            this.btnNewM.TabIndex = 11;
            this.btnNewM.Text = "Làm mới";
            this.btnNewM.Click += new System.EventHandler(this.btnNewM_Click);
            // 
            // btnSaveM
            // 
            this.btnSaveM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveM.ImageOptions.Image")));
            this.btnSaveM.Location = new System.Drawing.Point(114, 420);
            this.btnSaveM.Name = "btnSaveM";
            this.btnSaveM.Size = new System.Drawing.Size(114, 44);
            this.btnSaveM.TabIndex = 10;
            this.btnSaveM.Text = "Lưu";
            this.btnSaveM.Click += new System.EventHandler(this.btnSaveM_Click);
            // 
            // dtDateManu
            // 
            this.dtDateManu.EditValue = null;
            this.dtDateManu.Location = new System.Drawing.Point(161, 130);
            this.dtDateManu.MenuManager = this.ribbonControl1;
            this.dtDateManu.Name = "dtDateManu";
            this.dtDateManu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateManu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateManu.Size = new System.Drawing.Size(309, 20);
            this.dtDateManu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bao bì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ca sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sản phẩm";
            // 
            // FrmLotReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 508);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLotReg";
            this.Ribbon = this.ribbonControl1;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký Lô";
            this.Load += new System.EventHandler(this.FrmLotReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPallet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpectedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExpectedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductNm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateManu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateManu.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit dtDateManu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnNewM;
        private DevExpress.XtraEditors.SimpleButton btnSaveM;
        private DevExpress.XtraEditors.TextEdit txtLot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.ComboBox cboProductLabel;
        private System.Windows.Forms.ComboBox cboPatchNo;
        private DevExpress.XtraEditors.LookUpEdit cboProductNm;
        private System.Windows.Forms.ComboBox txtShiftNo;
        private DevExpress.XtraEditors.DateEdit dtExpectedDate;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraEditors.TextEdit txtTotalTem;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.MemoEdit txtSerial;
        private DevExpress.XtraEditors.TextEdit txtPallet;
        private System.Windows.Forms.Label label11;
    }
}