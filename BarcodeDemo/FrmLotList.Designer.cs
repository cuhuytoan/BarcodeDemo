namespace BarcodeDemo
{
    partial class FrmLotList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLotList));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnInquiry = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAddLot = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.QRCodePackage_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Product_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductBrand_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Batch_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ManufactureShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ManufactureDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SerialNumberStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SerialNumberEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpectedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AssignEmpNm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LstQrCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewList = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
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
            this.btnDelete,
            this.barButtonAddLot,
            this.barButtonRefresh,
            this.btnExportExcel,
            this.btnReport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 146);
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
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barButtonAddLot
            // 
            this.barButtonAddLot.Caption = "Thêm mới lô mã";
            this.barButtonAddLot.Hint = "Thêm mới lô mã";
            this.barButtonAddLot.Id = 5;
            this.barButtonAddLot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonAddLot.ImageOptions.Image")));
            this.barButtonAddLot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonAddLot.ImageOptions.LargeImage")));
            this.barButtonAddLot.Name = "barButtonAddLot";
            this.barButtonAddLot.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonAddLot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAddLot_ItemClick);
            // 
            // barButtonRefresh
            // 
            this.barButtonRefresh.Caption = "Làm mới";
            this.barButtonRefresh.Id = 6;
            this.barButtonRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonRefresh.ImageOptions.Image")));
            this.barButtonRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonRefresh.ImageOptions.LargeImage")));
            this.barButtonRefresh.Name = "barButtonRefresh";
            this.barButtonRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRefresh_ItemClick);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Caption = "Xuất file excel";
            this.btnExportExcel.Id = 7;
            this.btnExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.ImageOptions.Image")));
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportExcel_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Báo cáo";
            this.btnReport.Id = 8;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.Name = "btnReport";
            this.btnReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Công cụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonAddLot);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonRefresh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnExportExcel);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 146);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 300);
            this.panelControl2.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(796, 296);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseUp);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.QRCodePackage_ID,
            this.Product_ID,
            this.ProductBrand_ID,
            this.Batch_ID,
            this.NameLot,
            this.ProductName,
            this.ManufactureShift,
            this.ManufactureDate,
            this.BName,
            this.SerialNumberStart,
            this.SerialNumberEnd,
            this.ExpectedDate,
            this.StatusName,
            this.AssignEmpNm,
            this.LstQrCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // QRCodePackage_ID
            // 
            this.QRCodePackage_ID.Caption = "Số thứ tự lô mã";
            this.QRCodePackage_ID.FieldName = "QRCodePackage_ID";
            this.QRCodePackage_ID.Name = "QRCodePackage_ID";
            this.QRCodePackage_ID.Visible = true;
            this.QRCodePackage_ID.VisibleIndex = 0;
            // 
            // Product_ID
            // 
            this.Product_ID.Caption = "Product_ID";
            this.Product_ID.FieldName = "Product_ID";
            this.Product_ID.Name = "Product_ID";
            // 
            // ProductBrand_ID
            // 
            this.ProductBrand_ID.Caption = "ProductBrand_ID";
            this.ProductBrand_ID.FieldName = "ProductBrand_ID";
            this.ProductBrand_ID.Name = "ProductBrand_ID";
            // 
            // Batch_ID
            // 
            this.Batch_ID.Caption = "Số Patch";
            this.Batch_ID.FieldName = "Batch_ID";
            this.Batch_ID.Name = "Batch_ID";
            // 
            // NameLot
            // 
            this.NameLot.Caption = "Tên lô mã";
            this.NameLot.FieldName = "NameLot";
            this.NameLot.Name = "NameLot";
            this.NameLot.Visible = true;
            this.NameLot.VisibleIndex = 1;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Tên sản phẩm";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 2;
            // 
            // ManufactureShift
            // 
            this.ManufactureShift.Caption = "Ca sản xuất";
            this.ManufactureShift.FieldName = "ManufactureShift";
            this.ManufactureShift.Name = "ManufactureShift";
            this.ManufactureShift.Visible = true;
            this.ManufactureShift.VisibleIndex = 3;
            // 
            // ManufactureDate
            // 
            this.ManufactureDate.Caption = "Ngày sản xuất";
            this.ManufactureDate.FieldName = "ManufactureDate";
            this.ManufactureDate.Name = "ManufactureDate";
            this.ManufactureDate.Visible = true;
            this.ManufactureDate.VisibleIndex = 4;
            // 
            // BName
            // 
            this.BName.Caption = "Bao bì";
            this.BName.FieldName = "BName";
            this.BName.Name = "BName";
            this.BName.Visible = true;
            this.BName.VisibleIndex = 10;
            // 
            // SerialNumberStart
            // 
            this.SerialNumberStart.Caption = "Từ Serial";
            this.SerialNumberStart.FieldName = "SerialNumberStart";
            this.SerialNumberStart.Name = "SerialNumberStart";
            this.SerialNumberStart.Visible = true;
            this.SerialNumberStart.VisibleIndex = 5;
            // 
            // SerialNumberEnd
            // 
            this.SerialNumberEnd.Caption = "Đến Serial";
            this.SerialNumberEnd.FieldName = "SerialNumberEnd";
            this.SerialNumberEnd.Name = "SerialNumberEnd";
            this.SerialNumberEnd.Visible = true;
            this.SerialNumberEnd.VisibleIndex = 6;
            // 
            // ExpectedDate
            // 
            this.ExpectedDate.Caption = "Ngày kích hoạt";
            this.ExpectedDate.FieldName = "ExpectedDate";
            this.ExpectedDate.Name = "ExpectedDate";
            this.ExpectedDate.Visible = true;
            this.ExpectedDate.VisibleIndex = 9;
            // 
            // StatusName
            // 
            this.StatusName.Caption = "Trạng thái";
            this.StatusName.FieldName = "StatusName";
            this.StatusName.Name = "StatusName";
            this.StatusName.Visible = true;
            this.StatusName.VisibleIndex = 7;
            // 
            // AssignEmpNm
            // 
            this.AssignEmpNm.Caption = "Tên nhân viên";
            this.AssignEmpNm.FieldName = "AssignEmpNm";
            this.AssignEmpNm.Name = "AssignEmpNm";
            this.AssignEmpNm.Visible = true;
            this.AssignEmpNm.VisibleIndex = 8;
            // 
            // LstQrCode
            // 
            this.LstQrCode.Caption = "Danh sách Serial";
            this.LstQrCode.FieldName = "LstQrCode";
            this.LstQrCode.Name = "LstQrCode";
            this.LstQrCode.Visible = true;
            this.LstQrCode.VisibleIndex = 11;
            // 
            // barManager1
            // 
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnEdit,
            this.btnViewList,
            this.btnDel});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 446);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 446);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 446);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Chỉnh sửa lô mã";
            this.btnEdit.Id = 0;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnViewList
            // 
            this.btnViewList.Caption = "Xem Danh sách";
            this.btnViewList.Id = 1;
            this.btnViewList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewList.ImageOptions.Image")));
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewList_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa mã";
            this.btnDel.Id = 2;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnViewList),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDel)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // FrmLotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLotList";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý lô mã";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLotList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
     
        private DevExpress.XtraGrid.Columns.GridColumn QRCodePackage_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Product_ID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductBrand_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Batch_ID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn ManufactureShift;
        private DevExpress.XtraGrid.Columns.GridColumn ManufactureDate;
        private DevExpress.XtraGrid.Columns.GridColumn SerialNumberStart;
        private DevExpress.XtraGrid.Columns.GridColumn SerialNumberEnd;
        private DevExpress.XtraBars.BarButtonItem barButtonAddLot;
        private DevExpress.XtraBars.BarButtonItem barButtonRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnViewList;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraGrid.Columns.GridColumn NameLot;
        private DevExpress.XtraGrid.Columns.GridColumn StatusName;
        private DevExpress.XtraGrid.Columns.GridColumn ExpectedDate;
        private DevExpress.XtraGrid.Columns.GridColumn AssignEmpNm;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarButtonItem btnReport;
        private DevExpress.XtraGrid.Columns.GridColumn BName;
        private DevExpress.XtraGrid.Columns.GridColumn LstQrCode;
    }
}