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
    public partial class FrmScanBarcode : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;
        private int QRCodeID;
        private int PakageID;
        public FrmScanBarcode()
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

        private void FrmScanBarcode_Load(object sender, EventArgs e)
        {
            db = new productionmanager_plcEntities();
            LoadActive();
            Inquiry();            
            ScanFocus();
        }
        private void LoadActive()
        {            
            gridControl2.DataSource = db.QRCodePackages.Where(p => p.QRCodeProductStatus_ID == 2).ToList();
        }
        private bool CheckExistsBarcode()
        {
            bool fl = true;
            List<QRCode> lst = db.QRCodes.Where(p => p.QRCodePackage_ID == PakageID).ToList();
            if(lst != null && lst.Count > 0)
            {
                foreach(var p in lst)
                {
                    if(p.SerialNumber == txtScan.Text)
                    {
                        fl = false;
                        return fl;
                    }
                }
            }
            return fl;
        }
        private void AutoSave()
        {
            //Check count Number.
            var QRNumber = db.QRCodePackages.Where(p => p.QRCodePackage_ID == PakageID).SingleOrDefault().QRCodeNumber;
            if (gridView1.RowCount < QRNumber)
            {
                try
                {
                    db.QRCodes.Add(new QRCode()
                    {
                        SerialNumber = txtScan.Text,
                        QRCodePackage_ID = PakageID,
                        CreateDate = DateTime.Now,
                        CreateBy = Guid.NewGuid()
                    });
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong quá trình lưu:" + ex.ToString(), "Thông báo");
                }
            }
            else
            {
                UpdateStatus();
                //Update status to active
                QRCodePackage qrU = db.QRCodePackages.Where(i => i.QRCodeProductStatus_ID == 1).OrderBy(i => i.QRQueue).FirstOrDefault();
                qrU.QRCodeProductStatus_ID = 2;
                db.SaveChanges();
                //Update PakageID
                PakageID = db.QRCodePackages.Where(p => p.QRCodeProductStatus_ID == 2).First().QRCodePackage_ID;
                LoadActive();
            }

            Inquiry();
        }
        private void Inquiry()
        {
            PakageID = db.QRCodePackages.Where(p => p.QRCodeProductStatus_ID == 2).First().QRCodePackage_ID;            
            gridControl1.DataSource = db.QRCodes.Where(p => p.QRCodePackage_ID == PakageID).ToList();
            LoadCountTem();
            ScanFocus();
        }
        private void UpdateStatus()
        {
            //Update status to finish
            QRCodePackage qr = db.QRCodePackages.Where(p => p.QRCodePackage_ID == PakageID).SingleOrDefault();
            qr.QRCodeProductStatus_ID = 3;
            db.SaveChanges();
            
        }
        private void Delete()
        {            
            QRCode QrCodeID = db.QRCodes.Where(p => p.QRCode_ID == QRCodeID).SingleOrDefault();
            db.QRCodes.Remove(QrCodeID);
            db.SaveChanges();
        }
       
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //QRCodeID = Guid.Parse(gridView1.GetRowCellValue(e.RowHandle, "QRCode_ID").ToString());
            QRCodeID = Int32.Parse(gridView1.GetRowCellValue(e.RowHandle, "QRCode_ID").ToString());
        }
        private void ScanFocus()
        {
            txtScan.Text = "";
            txtScan.Focus();
        }

        private void txtScan_Enter(object sender, EventArgs e)
        {
            AutoSave();
            ScanFocus();
        }

        private void txtScan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!CheckExistsBarcode())
                {
                    var Confirm = MessageBox.Show("Barcode đã tồn tại bạn có muốn lưu thêm?",
                                             "Xác nhân!!",
                                             MessageBoxButtons.YesNo);
                    if (Confirm == DialogResult.Yes)
                    {
                        AutoSave();
                        ScanFocus();
                    }
                }
                else
                {
                    AutoSave();
                    ScanFocus();
                }
              
                
               
            }
        }

        private void btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Inquiry();
        }
        private void LoadCountTem()
        {
            var Pac = db.QRCodePackages.Where(p => p.QRCodeProductStatus_ID == 2).SingleOrDefault().QRCodePackage_ID; ;
            var totalTemp = db.QRCodePackages.Where(p => p.QRCodeProductStatus_ID == 2).SingleOrDefault().QRCodeNumber;
            var number = db.QRCodes.Where(p => p.QRCodePackage_ID == Pac).Count();
            lblTitle.Text = "Lô mã đang thực hiện kích hoạt\r\nSố tem đã quét / Tổng số tem: " + number.ToString() + " / " + totalTemp.ToString();
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
        

        
    }
}
