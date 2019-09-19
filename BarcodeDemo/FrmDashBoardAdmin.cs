using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using DevExpress.DirectX;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace BarcodeDemo
{
    public partial class FrmDashBoardAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;
        private object SelectedPackage;
        private int CurrentPackageID;
        private bool flagP;
        private int QRCodeID;
        public FrmDashBoardAdmin()
        {
            InitializeComponent();
        }
        private void FrmDashBoard_Load(object sender, EventArgs e)
        {
            //test
            //ApiHelper.UserInfo.AccountType = "1";
            //ApiHelper.UserInfo.LoginID = "1";
            db = new productionmanager_plcEntities();
            flagP = true;
            txtBarFullName.Caption = "Nhân viên: " + ApiHelper.UserInfo.FullName;
            FormRefresh();
        }
        private void btnCreateLot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmLotReg();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmScanBarcode frm = new FrmScanBarcode();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
            FormRefresh();
        }
        private void LoadWaiting()
        {
            if (ApiHelper.UserInfo.AccountType == "1")
            {
                var query = (from t1 in db.QRCodePackages
                    join t2 in db.App_User on t1.AssignEmp equals t2.App_User_ID
                    let EmpUserName = t2.FullName
                    let ProductLabelName = t1.Name
                    where t1.QRCodeProductStatus_ID == 1 && t1.Factory_ID == ApiHelper.UserInfo.Factory_ID
                    select new
                    {
                        t1.QRCodePackage_ID,
                        EmpUserName,
                        t1.Batch_ID,
                        t1.ProductLabel_ID,
                        t1.ProductName,
                        t1.SerialNumberStartExpected,
                        t1.SerialNumberEndExpected,
                        t1.ManufactureDate,
                        t1.ManufactureShift,
                        t1.QRQueue,
                        ProductLabelName,
                        t1.ExpectedDate,
                        t1.SerialNumberTextExpected,
                        t1.PalletNum
                    }).OrderBy(i => i.QRQueue).ToList();

                gridControl2.DataSource = query;
            }
            
        }
        private void LoadActive()
        {
            if (ApiHelper.UserInfo.AccountType == "1")
            {
                var query = (from t1 in db.QRCodePackages
                    join t2 in db.App_User on t1.AssignEmp equals t2.App_User_ID
                    let EmpUserName = t2.FullName
                    let ProductLabelName = t1.Name
                    where t1.QRCodeProductStatus_ID == 2 && t1.Factory_ID == ApiHelper.UserInfo.Factory_ID
                                                         
                             select new
                    {
                        t1.QRCodePackage_ID,
                        EmpUserName,
                        t1.Batch_ID,
                        t1.ProductLabel_ID,
                        t1.ProductName,
                        t1.SerialNumberStartExpected,
                        t1.SerialNumberEndExpected,
                        t1.ManufactureDate,
                        t1.ManufactureShift,
                        t1.QRQueue,
                        ProductLabelName,
                        t1.ExpectedDate,
                        t1.SerialNumberTextExpected,
                        t1.PalletNum
                    }).OrderBy(i => i.QRQueue).ToList();
                gridControl1.DataSource = query;

                var CurrPac = db.QRCodePackages.FirstOrDefault(p => p.QRCodeProductStatus_ID == 2);
                if (CurrPac != null)
                {
                    CurrentPackageID = CurrPac.QRCodePackage_ID;
                }

            }
           
        }
       
        private void LoadFinish()
        {
            if (ApiHelper.UserInfo.AccountType == "1")
            {
                var query = (from t1 in db.QRCodePackages
                    join t2 in db.App_User on t1.AssignEmp equals t2.App_User_ID
                    let EmpUserName = t2.FullName
                    let ProductLabelName = t1.Name
                    where t1.QRCodeProductStatus_ID >= 3 && t1.Factory_ID == ApiHelper.UserInfo.Factory_ID
                             select new
                    {
                        t1.QRCodePackage_ID,
                        EmpUserName,
                        t1.Batch_ID,
                        t1.ProductLabel_ID,
                        t1.ProductName,
                        t1.SerialNumberStartExpected,
                        t1.SerialNumberEndExpected,
                        t1.ManufactureDate,
                        t1.ManufactureShift,
                        t1.QRQueue,
                        ProductLabelName,
                        t1.ExpectedDate,
                        t1.QRCodeProductStatus_ID,
                        t1.SerialNumberTextExpected,
                        t1.PalletNum
                    }).OrderBy(i => i.QRQueue).ToList();

                var sumQuery = (from t1 in db.QRCodes
                    group t1 by (t1.QRCodePackage_ID)
                    into g
                    select new
                    {
                        QRCodePackage_ID = g.Key,
                        TotalTem = g.Count()
                    }).ToList();
                var outQuery = (from t1 in query
                    join t2 in sumQuery on t1.QRCodePackage_ID equals t2.QRCodePackage_ID
                    select new
                    {
                        t1.QRCodePackage_ID,
                        t1.EmpUserName,
                        t1.Batch_ID,
                        t1.ProductLabel_ID,
                        t1.ProductName,
                        t1.SerialNumberStartExpected,
                        t1.SerialNumberEndExpected,
                        t1.ManufactureDate,
                        t1.ManufactureShift,
                        t1.QRQueue,
                        t1.ProductLabelName,
                        t2.TotalTem,
                        t1.ExpectedDate,
                        t1.SerialNumberTextExpected,
                        t1.PalletNum,
                        IsCheck = (t1.QRCodeProductStatus_ID != 3)
                    }).OrderBy(i => i.QRQueue).ToList();
                gridControl3.DataSource = outQuery;
                
            }

        }
        private void LoadCountTem()
        {
            using (var db = new productionmanager_plcEntities())
            {
                int SelPack = Convert.ToInt32(SelectedPackage);
                var Pac = db.QRCodePackages.FirstOrDefault(p =>
                    p.QRCodeProductStatus_ID == 2 && p.QRCodePackage_ID == SelPack);
                var totalTemp =
                    db.QRCodePackages.FirstOrDefault(
                        p => p.QRCodeProductStatus_ID == 2 && p.QRCodePackage_ID == SelPack && p.Factory_ID == ApiHelper.UserInfo.Factory_ID);
                if (Pac != null && totalTemp != null)
                {
                    var PacNum = Pac.QRCodePackage_ID;
                    var totalNum = totalTemp.QRCodeNumber;
                    var number = db.QRCodes.Count(p => p.QRCodePackage_ID == PacNum);
                    //lblTemp.Text = "Số lượng tem đã hoàn thành là: " + number.ToString();//+ " / " + totalNum.ToString();
                }

                var waiting = db.QRCodePackages.Count(p => p.QRCodeProductStatus_ID == 1 && p.Factory_ID == ApiHelper.UserInfo.Factory_ID);
                var finish = db.QRCodePackages.Count(p => p.QRCodeProductStatus_ID == 3 && p.Factory_ID == ApiHelper.UserInfo.Factory_ID);
                lblWaiting.Text = "Danh sách lô mã đang chờ : " + waiting.ToString();
                lblFinish.Text = "Danh sách lô mã đã kích hoạt xong : " + finish.ToString();
            }

        }
        private void FormRefresh()
        {
            if (ApiHelper.UserInfo.AccountType != "1")
            {
                ribbonPageGroup6.Visible = false;
                ribbonPageGroup4.Visible = false;
                ribbonPageGroup1.Visible = false;
            }
            else if (ApiHelper.UserInfo.AccountType == "1")
            {
                ribbonPageGroup4.Visible = false;
                ribbonPageGroup5.Visible = false;
                ribbonPageGroup7.Visible = false;
            }
            using (var db = new productionmanager_plcEntities())
            {
                LoadWaiting();
                LoadActive();
                LoadFinish();
                LoadCountTem();
            }



        }

        private void barButtonAddLot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLotReg frm = new FrmLotReg();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
            FormRefresh();
        }

        private void barButtonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormRefresh();
        }

        private void barButtonLotList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLotList frm = new FrmLotList();
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
            Refresh();
        }

        private void TileView_DoubleClick(object sender, EventArgs e)
        {
            FrmLotReg frm = new FrmLotReg();
            frm._PakageID = Convert.ToInt32(SelectedPackage);
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
            FormRefresh();
        }

        private void MouseUp_PopUp(object sender, MouseEventArgs e)
        {
            TileViewHitInfo hitInfo = tileView1.CalcHitInfo(e.Location);
            if (hitInfo.InItem)
            {
                SelectedPackage = tileView1.GetRowCellValue(hitInfo.RowHandle, "QRCodePackage_ID");
                if (SelectedPackage != null)
                {
                    if (e.Button != MouseButtons.Right) return;
                    popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu1.HidePopup();
                }
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLotReg frm = new FrmLotReg();
            frm._PakageID = Convert.ToInt32(SelectedPackage);
            frm.ShowDialog();
        }

        private void btnViewList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmScanBarcodeList frm = new FrmScanBarcodeList();
            frm.PackageQry = Convert.ToInt32(SelectedPackage);
            frm.ShowDialog();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Confirm = MessageBox.Show("Bạn có chắc muốn xóa lô mã ??",
                                         "Xác nhân xóa!!",
                                         MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa lô mã:" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FormRefresh();
        }
        private void Delete()
        {
            int LotSeq = Convert.ToInt32(SelectedPackage);
            QRCodePackage LotCode = db.QRCodePackages.SingleOrDefault(p => p.QRCodePackage_ID == LotSeq);
            if (LotCode != null) db.QRCodePackages.Remove(LotCode);
            db.SaveChanges();
        }

        private void tileView1_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {

        }
        private void Up()
        {
            using (var db = new productionmanager_plcEntities())
            {
                int Pac = Convert.ToInt32(SelectedPackage);
                QRCodePackage LotCode =
                    db.QRCodePackages.SingleOrDefault(i => i.QRCodePackage_ID == Pac && i.QRCodeProductStatus_ID == 1);
                if (LotCode != null)
                {
                    var QueueCurrent = LotCode.QRQueue;
                    QRCodePackage LotCodeUp = db.QRCodePackages.SingleOrDefault(i =>
                        i.QRQueue == (LotCode.QRQueue - 1) && i.QRCodeProductStatus_ID == 1);
                    if (LotCodeUp != null)
                    {
                        LotCode.QRQueue = LotCodeUp.QRQueue;
                        LotCodeUp.QRQueue = QueueCurrent;
                    }
                }

                db.SaveChanges();
            }

        }
        private void Down()
        {
            using (var db = new productionmanager_plcEntities())
            {
                int Pac = Convert.ToInt32(SelectedPackage);
                QRCodePackage LotCode =
                    db.QRCodePackages.SingleOrDefault(i => i.QRCodePackage_ID == Pac && i.QRCodeProductStatus_ID == 1);
                if (LotCode != null)
                {
                    var QueueCurrent = LotCode.QRQueue;
                    QRCodePackage LotCodeDown = db.QRCodePackages.SingleOrDefault(i =>
                        i.QRQueue == (LotCode.QRQueue + 1) && i.QRCodeProductStatus_ID == 1);
                    if (LotCodeDown != null)
                    {
                        LotCode.QRQueue = LotCodeDown.QRQueue;
                        LotCodeDown.QRQueue = QueueCurrent;
                    }
                }

                db.SaveChanges();
            }
        }

        private void btnUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Up();
            FormRefresh();
        }

        private void btnDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Down();
            FormRefresh();
        }

        private void tileView3_MouseUp(object sender, MouseEventArgs e)
        {

            TileViewHitInfo hitInfo = tileView3.CalcHitInfo(e.Location);
            if (hitInfo.InItem)
            {
                SelectedPackage = tileView3.GetRowCellValue(hitInfo.RowHandle, "QRCodePackage_ID");
                if (SelectedPackage != null)
                {
                    LoadCountTem();
                    if (e.Button != MouseButtons.Right) return;
                    popupMenu2.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu2.HidePopup();
                }
            }
        }

        private void tileView2_MouseUp(object sender, MouseEventArgs e)
        {
            TileViewHitInfo hitInfo = tileView2.CalcHitInfo(e.Location);
            if (hitInfo.InItem)
            {
                SelectedPackage = tileView2.GetRowCellValue(hitInfo.RowHandle, "QRCodePackage_ID");
                if (SelectedPackage != null)
                {
                    if (e.Button != MouseButtons.Right) return;
                    popupMenu4.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
                }
                else
                {
                    popupMenu4.HidePopup();
                }
            }
        }

        private void btnPlayPause_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //btnPlayPause.ImageOptions.Image  = 
            //btnPlayPause.ImageOptions.Image  = 
        }




        private void UpdateStatus()
        {
            //Update status to finish
            var qrPac = db.QRCodePackages.SingleOrDefault(p =>
                p.QRCodeProductStatus_ID == 2 && p.AssignEmp == ApiHelper.UserInfo.LoginID);
            if (qrPac == null) return;
            QRCodePackage qr = db.QRCodePackages.SingleOrDefault(p => p.QRCodePackage_ID == qrPac.QRCodePackage_ID);
            qr.QRCodeProductStatus_ID = 3;
            db.SaveChanges();

        }

        private void btnPlayPause_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnDelCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSycn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ApiHelper.UserInfo.AccountType == "2")
            {
                MessageBox.Show("Tài khoản của bạn không thể thực hiện chức năng này", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int SelPac = Convert.ToInt32(SelectedPackage);
            var lst = db.QRCodePackages.SingleOrDefault(i => i.QRCodePackage_ID == SelPac);
            var lstQRCode = db.QRCodes.Where(i => i.QRCodePackage_ID == SelPac).ToList();
            string pSerialNumberStart = "", pSerialNumberEnd = "", pSerialNumberText = "";
            var json = "";
            Uri strUrl = new Uri("https://check.net.vn/plcservice/qrcodepackage_active.aspx");
            if (lstQRCode != null)
            {
                pSerialNumberStart = lstQRCode.OrderBy(i => i.QRCode_ID).FirstOrDefault()?.SerialNumber;
                pSerialNumberEnd = lstQRCode.OrderByDescending(i => i.QRCode_ID).FirstOrDefault()?.SerialNumber;
                foreach (var p in lstQRCode)
                {
                    pSerialNumberText += p.SerialNumber + ",";
                }
            }
            if (lst != null)
            {
                SentServer sv = new SentServer();
                sv.Device_ID = Guid.NewGuid().ToString();
                sv.QRCodePackageType_ID = lst.QRCodePackageType_ID.ToString();
                sv.Product_ID = lst.Product_ID.ToString();
                sv.Batch_ID = lst.Batch_ID.ToString();
                sv.Factory_ID = lst.Factory_ID.ToString();
                sv.ProductLabel_ID = null;
                sv.Name = lst.ProductName + "_" + lst.QRCodeNumber;
                sv.Description = "Lo ma duoc tao bang phan mem kich hoat tem he thong!";
                sv.QRCodeNumber = lst.QRCodeNumber.ToString();
                sv.SerialNumberStart = pSerialNumberStart;
                sv.SerialNumberEnd = pSerialNumberEnd;
                sv.SerialNumberText = pSerialNumberText.Remove(pSerialNumberText.Length-1,1);
                sv.ManufactureShift = lst.ManufactureShift;
                sv.ManufactureDate = lst.ManufactureDate.ToString();
                sv.UserName = ApiHelper.UserInfo.UserName;
                sv.AgentVersion = "2.0";
                json = JsonConvert.SerializeObject(sv);
            }
            if (!String.IsNullOrEmpty(json))
            {
                try
                {
                    string result = Post(strUrl, json);
                    if (result == "0")
                    {
                        MessageBox.Show("Đồng bộ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateTus();
                    }
                    else
                    {
                        MessageBox.Show("Đồng bộ thất bại : Lỗi :" + result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đồng bộ thất bại : " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            FormRefresh();

        }
        public string Post(Uri url, string value)
        {
            var request = HttpWebRequest.Create(url);
            var byteData = Encoding.ASCII.GetBytes(value);
            request.ContentType = "application/json";
            request.Method = "POST";

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(byteData, 0, byteData.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (WebException e)
            {
                return null;
            }
        }
        private void UpdateTus()
        {
            int SelPac = Convert.ToInt32(SelectedPackage);
            var lst = db.QRCodePackages.SingleOrDefault(i => i.QRCodePackage_ID == SelPac);
            lst.QRCodeProductStatus_ID = 4;
            db.SaveChanges();
        }

        private void tileView2_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {

            //int Pacx = Convert.ToInt32(tileView2.GetRowCellValue(e.RowHandle, "QRCodeProductStatus_ID"));
            //if(Pacx == 4)
            //{
            //    this.tileView2.Appearance.ItemNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));

            //}
            //else
            //{
            //    e.Item.AppearanceItem.Normal.BackColor = Color.Lime;
            //}

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnAccountList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAccList frm = new FrmAccList();
            frm.ShowDialog();
        }

        private void btnFinishLot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                var Confirm = MessageBox.Show("Bạn muốn xác nhận lô mã đã hoàn thành",
                    "Xác nhân!!",
                    MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    UpdateStatus();
                    //Update status to active
                    QRCodePackage qrU = db.QRCodePackages.Where(i => i.QRCodeProductStatus_ID == 1 && i.AssignEmp == ApiHelper.UserInfo.LoginID).OrderBy(i => i.QRQueue).FirstOrDefault();
                    if (qrU != null) qrU.QRCodeProductStatus_ID = 2;
                    db.SaveChanges();
                    //Update PakageID
                    var qr = db.QRCodePackages.SingleOrDefault(p =>
                        p.QRCodeProductStatus_ID == 2 && p.AssignEmp == ApiHelper.UserInfo.LoginID);
                    if (qr != null)
                    {
                        CurrentPackageID = db.QRCodePackages.First(p =>
                                p.QRCodeProductStatus_ID == 2 && p.AssignEmp == ApiHelper.UserInfo.LoginID)
                            .QRCodePackage_ID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xác nhận lô mã hoàn thành:", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FormRefresh();
        }

        private void btnDelCode_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Confirm = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ??",
                    "Xác nhân xóa!!",
                    MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    DeleteQr();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa dữ liệu:" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FormRefresh();
        }

        

        private void DeleteQr()
        {
            QRCode QrCodeID = db.QRCodes.SingleOrDefault(p => p.QRCode_ID == QRCodeID);

            if (QrCodeID != null)
            {
                db.QRCodes.Remove(QrCodeID);

                db.SaveChanges();
            }
        }

        private void gridView4_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //var strQRCode = gridView1.GetRowCellValue(e.RowHandle, "QRCode_ID");
            //if (strQRCode != null) QRCodeID = Int32.Parse(strQRCode.ToString());
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActive_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var db = new productionmanager_plcEntities())
            {
                int LotSeq = Convert.ToInt32(SelectedPackage);
                QRCodePackage LotCode = db.QRCodePackages.SingleOrDefault(p => p.QRCodePackage_ID == LotSeq);
                var count = db.QRCodePackages.Count(p => p.AssignEmp == LotCode.AssignEmp && p.QRCodeProductStatus_ID == 2);
                if (count > 0)
                {
                    MessageBox.Show("Người dùng đã có lô mã đang kích hoạt");
                    return;
                }

                try
                {
                    if (LotCode != null) LotCode.QRCodeProductStatus_ID = 2;
                    db.SaveChanges();
                    MessageBox.Show("Kích hoạt lô mã thành công");
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi kích hoạt Lô mã");
                }
            }
        }
    }
}

