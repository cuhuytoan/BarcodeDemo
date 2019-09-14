using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeDemo
{
    public partial class FrmScanBarcodeList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;
        private int QRCodeID;
        private int PakageID;
        public int PackageQry;
        private string CurrentSerial;
        public FrmScanBarcodeList()
        {
            InitializeComponent();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Delete();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa:" + ex , "Thông báo");
            }
        }

        private void FrmScanBarcodeList_Load(object sender, EventArgs e)
        {
            db = new productionmanager_plcEntities();
            LoadActive();
            Inquiry();            
            ScanFocus();
        }
        private void LoadActive()
        {
            //gridControl2.DataSource = db.QRCodePackages.Where(p => p.QRCodePackage_ID == PackageQry).ToList();
            using (var db = new productionmanager_plcEntities())
            {
                var query = (from t1 in db.QRCodePackages
                    join t2 in db.App_User on t1.AssignEmp equals t2.App_User_ID
                    let EmpUserName = t2.FullName
                    let ProductLabelName = t1.Name
                    where t1.QRCodePackage_ID == PackageQry
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
                        t1.ExpectedDate
                    }).ToList();

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
                        t1.ExpectedDate
                    }).ToList();
                gridControl2.DataSource = outQuery;
            }
            
        }        
        private void Inquiry()
        {
            using (var db = new productionmanager_plcEntities())
            {
                gridControl1.DataSource = db.QRCodes.Where(p => p.QRCodePackage_ID == PackageQry).ToList();
            }

        }
            
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //QRCodeID = Guid.Parse(gridView1.GetRowCellValue(e.RowHandle, "QRCode_ID").ToString());
            QRCodeID = Int32.Parse(gridView1.GetRowCellValue(e.RowHandle, "QRCode_ID").ToString());
            CurrentSerial = gridView1.GetRowCellValue(e.RowHandle, "SerialNumber").ToString();
        }
        private void ScanFocus()
        {
            
        }

        private void txtScan_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtScan_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Inquiry();
        }
        private void LoadCountTem()
        {
            
            //var totalTemp = db.QRCodePackages.Where(p => p.QRCodePackage_ID == PackageQry).SingleOrDefault().QRCodeNumber;
            //var number = db.QRCodes.Where(p => p.QRCodePackage_ID == PackageQry).Count();
            //lblTitle.Text = "Lô mã đang thực hiện kích hoạt\r\nSố tem đã quét / Tổng số tem: " + number.ToString() + " / " + totalTemp.ToString();
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var RowH = gridView1.FocusedRowHandle;
            //var focusRowView = (DataRowView)gridView1.GetFocusedRow();
            //if (focusRowView == null || focusRowView.IsNew) return;
            if (RowH >= 0)
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            else
                popupMenu1.HidePopup();
        }

        private void btnPDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Confirm = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ??",
                                         "Xác nhân xóa!!",
                                         MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa dữ liệu:" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Inquiry();
        }
        private void Delete()
        {
            QRCode QrCodeID = db.QRCodes.Where(p => p.QRCode_ID == QRCodeID).SingleOrDefault();
            db.QRCodes.Remove(QrCodeID);
            db.SaveChanges();
        }

        private void btnEditSerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmSerialEdit();
            frm.QrCodeID = QRCodeID;
            frm.SerialOld = CurrentSerial;
            frm.ShowDialog();
            Inquiry();
        }
    }
}
