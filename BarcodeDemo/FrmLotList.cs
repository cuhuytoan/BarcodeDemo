using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DirectX;

namespace BarcodeDemo
{
    public partial class FrmLotList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;
      
        private object SelectedPackage;
        public FrmLotList()
        {
            InitializeComponent();
        }
        
        private void FrmLotList_Load(object sender, EventArgs e)
        {
            db = new productionmanager_plcEntities();           
            Inquiry();           
        }
                 
        private void Inquiry()
        {
            List<QRCodeLst> lst = new List<QRCodeLst>();
            foreach (var p in db.QRCodes
                .GroupBy(i => i.QRCodePackage_ID))
            {
                QRCodeLst it = new QRCodeLst();
                foreach (var item in p)
                {
                    it.QRCodePackage_ID = item.QRCodePackage_ID;
                    it.LstQrCode = it.LstQrCode + "," + item.SerialNumber;
                }
                lst.Add(it);
            }
            using (var db = new productionmanager_plcEntities())
            {
                var query = (from t1 in db.QRCodePackages
                    join t3 in db.QRCodeProductStatus on t1.QRCodeProductStatus_ID equals t3.QRCodeProductStatus_ID
                    join t2 in db.App_User on t1.AssignEmp equals t2.App_User_ID
                    //join t4 in lst on t1.QRCodePackage_ID equals t4.QRCodePackage_ID
                    let StatusName = t3.Name
                    let AssignEmpNm = t2.FullName
                    let NameLot = t1.ProductName + "_" + t1.SerialNumberStartExpected + "_" + t1.SerialNumberEndExpected
                    let BName = t1.Name
                    select new
                    {
                        t1.QRCodePackage_ID,
                        t1.Product_ID,
                        t1.ProductLabel_ID,
                        t1.ProductName,
                        t1.ManufactureShift,
                        t1.Batch_ID,
                        t1.ManufactureDate,
                        t1.SerialNumberStart,
                        t1.SerialNumberEnd,
                        StatusName,
                        NameLot,
                        AssignEmpNm,
                        t1.ExpectedDate,
                        BName
                        

                    }).AsEnumerable();

                var lst1 = lst.Select(x => new {x.QRCodePackage_ID, x.LstQrCode}).AsEnumerable();
                var qry2 = from t1 in query
                    join t11 in lst.AsEnumerable() on t1.QRCodePackage_ID equals t11.QRCodePackage_ID
                    select new
                    {
                        t1.QRCodePackage_ID,
                        t1.Product_ID,
                        t1.ProductLabel_ID,
                        t1.ProductName,
                        t1.ManufactureShift,
                        t1.Batch_ID,
                        t1.ManufactureDate,
                        t1.SerialNumberStart,
                        t1.SerialNumberEnd,
                        t1.StatusName,
                        t1.NameLot,
                        t1.AssignEmpNm,
                        t1.ExpectedDate,
                        t1.BName,
                        t11.LstQrCode
                    };
                gridControl1.DataSource = qry2.ToList();

            }

            
            //gridControl1.DataSource = lst;

        }

        private void btnInquiry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Inquiry();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa dữ liệu:" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Inquiry();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //DataBinding();
        }
      

        private void barButtonRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Inquiry();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var RowH = gridView1.FocusedRowHandle;            
            if (RowH >= 0)
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            else
                popupMenu1.HidePopup();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                SelectedPackage = gridView1.GetRowCellValue(info.RowHandle, "QRCodePackage_ID");
                FrmLotReg frm = new FrmLotReg();
                frm._PakageID = Convert.ToInt32(SelectedPackage);
                frm.ShowDialog();
                Inquiry();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int QRPac = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QRCodePackage_ID").ToString());
            FrmLotReg frm = new FrmLotReg();
            frm._PakageID = QRPac;
            frm.ShowDialog();
        }

        private void barButtonAddLot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLotReg frm = new FrmLotReg();
            frm.ShowDialog();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnViewList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int QRPac = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QRCodePackage_ID").ToString());
            FrmScanBarcodeList frm = new FrmScanBarcodeList();
            frm.PackageQry = QRPac;
            frm.ShowDialog();
        }

        private void Delete()
        {
            int LotSeq = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QRCodePackage_ID").ToString());

            QRCodePackage LotCode = db.QRCodePackages.SingleOrDefault(p => p.QRCodePackage_ID == LotSeq);
            db.QRCodePackages.Remove(LotCode);
            db.SaveChanges();
                    
        }

        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string patch = "DanhSachLo.xlsx";
            gridControl1.ExportToXlsx(patch);
            Process.Start(patch);
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            string cellValue = gridView1.GetRowCellValue(e.RowHandle, "StatusName").ToString();
            
            if (cellValue != null && cellValue.ToString() == "Đã đồng bộ")
            {
                e.Appearance.BackColor = Color.DarkCyan;
            }
            else
            {
                e.Appearance.BackColor = Color.Red;
            }
            

        }
    }
}
