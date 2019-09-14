using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace BarcodeDemo
{
    public partial class FrmAccList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;

        public FrmAccList()
        {
            InitializeComponent();
        }

        private void FrmAccList_Load(object sender, EventArgs e)
        {
            db = new productionmanager_plcEntities();
            Inquiry();
        }

        private void Inquiry()
        {
            db= new productionmanager_plcEntities();
            gridControl1.DataSource = db.App_User.ToList().OrderBy(i =>i.FullName);
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
            catch (Exception ex)
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
                Guid AccID = Guid.Parse(gridView1.GetRowCellValue(info.RowHandle, "App_User_ID").ToString());
                FrmAccReg frm = new FrmAccReg();
                frm.AccID = AccID;
                frm.ShowDialog();
                Inquiry();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guid AccID = Guid.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "App_User_ID").ToString());
            FrmAccReg frm = new FrmAccReg();
            frm.AccID = AccID;
            frm.ShowDialog();
        }

        private void barButtonAddLot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAccReg frm = new FrmAccReg();
            frm.ShowDialog();
            Inquiry();
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
        }

        private void Delete()
        {
            Guid AccID = Guid.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "App_User_ID").ToString());

            App_User Acc = db.App_User.SingleOrDefault(p => p.App_User_ID == AccID);
            if (Acc != null)
            {
                db.App_User.Remove(Acc);
                db.SaveChanges();
            }

        }


    }
}
