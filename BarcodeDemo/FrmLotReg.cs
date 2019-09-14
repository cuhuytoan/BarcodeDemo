using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BarcodeDemo
{
    public partial class FrmLotReg : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;
        private int ProductID;
        private string EmpID;
        public int _PakageID { get; set; }
        public FrmLotReg()
        {
            InitializeComponent();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void FrmLotReg_Load(object sender, EventArgs e)
        {
            db = new productionmanager_plcEntities();
            LoadCombo();
            if (_PakageID > 0)
            {
                
                Inquiry(_PakageID);
            }
        }
        
        private void Save()
        {
            //Select Max Number Order 
            db= new productionmanager_plcEntities();
            int? MaxQueue = db.QRCodePackages.Max(i => i.QRQueue) == null ? 0 : db.QRCodePackages.Max(i => i.QRQueue);
            var AssignE = Guid.Parse(cboEmp.SelectedValue.ToString());
            var countStatusID = db.QRCodePackages.Count(i => i.QRCodeProductStatus_ID == 2 && i.AssignEmp == AssignE);
            int values = 1;
            //Check chưa tồn tại lô mã kích hoạt thì kích hoạt luôn
            //if (countStatusID == 0)
            //{
            //    values = 2;
            //}

            db.QRCodePackages.Add(new QRCodePackage()
            {
                Product_ID = ProductID,
                ManufactureShift = txtShiftNo.Text,
                Batch_ID = String.IsNullOrEmpty(cboPatchNo.Text) ? 0 : Convert.ToInt32(cboPatchNo.Text),
                ManufactureDate = Convert.ToDateTime(dtDateManu.Text),
                //Item = txtClassTem.Text, ITem class
                ProductLabel_ID =  cboProductLabel.SelectedValue != null ? Convert.ToInt32(cboProductLabel.SelectedValue.ToString()) : (int?) null,
                Name = cboProductLabel.Text,
                QRCodeProductStatus_ID = values,
                ProductBrand_ID = 95, // Default value
                ProductName = cboProductNm.Text,
                //SerialNumberStartExpected = txtSerialFr.Text,
                //SerialNumberEndExpected = txtSerialTo.Text,
                //ExpectedDate = Convert.ToDateTime(dtExpectedDate.Text),
                QRCodeNumber = String.IsNullOrEmpty(txtTotalTem.Text)?0: Convert.ToInt32(txtTotalTem.Text),
                SerialNumberTextExpected = txtSerial.Text,
                PalletNum = String.IsNullOrEmpty(txtTotalTem.Text) ? 0: Convert.ToInt32(txtPallet.Text),
                QRQueue = MaxQueue + 1,
                AssignEmp = Guid.Parse(cboEmp.SelectedValue.ToString()),
                ExpectedDate = Convert.ToDateTime(dtExpectedDate.Text),
                Active = true,
                CreateBy = ApiHelper.UserInfo.LoginID, // ID user login
                CreateDate = DateTime.Now,
                LastEditBy = ApiHelper.UserInfo.LoginID,
                LastEditDate = DateTime.Now
                
            });
            db.SaveChanges();
        }
        private void New()
        {
            txtLot.Text = "";
            cboProductNm.Text = "";
            cboProductLabel.Text = "";
            //txtSerialFr.Text = "";
            cboPatchNo.Text = "";
            txtShiftNo.Text = "";
            //txtSerialTo.Text = "";
            cboEmp.Text = "";
            _PakageID = 0;
           
        }
        private void Delete()
        {
            int LotSeq = _PakageID;
            QRCodePackage LotCode = db.QRCodePackages.SingleOrDefault(p => p.QRCodePackage_ID == LotSeq);
            db.QRCodePackages.Remove(LotCode);
            db.SaveChanges();
        }
        private void Update()
        {

            int LotSeq = Convert.ToInt32(txtLot.Text);
            QRCodePackage LotCode = db.QRCodePackages.SingleOrDefault(i => i.QRCodePackage_ID == LotSeq);
            if (LotCode != null)
            {
                LotCode.Product_ID = ProductID;
                LotCode.ManufactureShift = txtShiftNo.Text;
                LotCode.Batch_ID = String.IsNullOrEmpty(cboPatchNo.Text)
                    ? (int?) null
                    : Convert.ToInt32(cboPatchNo.Text);
                LotCode.ManufactureDate = Convert.ToDateTime(dtDateManu.Text);
                //LotCode.SerialNumberStartExpected = txtSerialFr.Text;
                //LotCode.SerialNumberEndExpected = txtSerialTo.Text;
                LotCode.ProductName = cboProductNm.Text;
                LotCode.ProductLabel_ID = cboProductLabel.SelectedValue != null ? Convert.ToInt32(cboProductLabel.SelectedValue.ToString()) : (int?)null;
                LotCode.Name = cboProductLabel.Name;
                LotCode.LastEditBy = ApiHelper.UserInfo.LoginID;
                LotCode.LastEditDate = DateTime.Now;
                LotCode.ExpectedDate = Convert.ToDateTime(dtExpectedDate.Text);
                //LotCode.ExpectedDate = Convert.ToDateTime(dtExpectedDate.Text);
                LotCode.AssignEmp = Guid.Parse(EmpID);
                db.SaveChanges();
            }


        }
        private void Inquiry(int Pakage_ID)
        {
            var query = (from t1 in db.QRCodePackages
                        join t2 in db.App_User on t1.AssignEmp equals t2.App_User_ID
                        let AssignEmpNm = t2.FullName
                        where t1.QRCodePackage_ID == Pakage_ID
                        select new
                        {
                            t1.QRCodePackage_ID,
                            t1.Product_ID,
                            t1.ProductBrand_ID,
                            t1.ProductName,
                            t1.ManufactureShift,
                            t1.Batch_ID,
                            t1.ManufactureDate,
                            t1.ProductLabel_ID,
                            t1.SerialNumberStartExpected,
                            t1.SerialNumberTextExpected,
                            t1.PalletNum,
                            t1.QRCodeNumber,
                            t1.ExpectedDate,
                            AssignEmpNm

                        }).FirstOrDefault();
            if (query != null)
            {
                if (query.ProductLabel_ID != null)
                {
                    var ProductLb = ApiHelper.getComboProductLabel((int)query.Product_ID)
                        .Where(p => p.ProductLabel_ID == query.ProductLabel_ID.ToString())
                        .Select(i => new { i.ProductLabel_ID, i.Name }).ToList();
                    cboProductLabel.DataSource = ProductLb;
                    cboProductLabel.ValueMember = "ProductLabel_ID";
                    cboProductLabel.DisplayMember = "Name";
                }

                //gridControl1.DataSource = query.OrderByDescending(i => i.QRCodePackage_ID);
                txtLot.DataBindings.Add(new Binding("Text", query, "QRCodePackage_ID"));
                cboProductNm.DataBindings.Add(new Binding("Text", query, "ProductName"));
                txtShiftNo.DataBindings.Add(new Binding("Text", query, "ManufactureShift"));
                cboPatchNo.DataBindings.Add(new Binding("Text", query, "Batch_ID"));
                dtDateManu.DataBindings.Add(new Binding("Text", query, "ManufactureDate"));
                //txtSerialFr.DataBindings.Add(new Binding("Text", query, "SerialNumberStartExpected"));
                txtTotalTem.DataBindings.Add(new Binding("Text", query, "QRCodeNumber"));
                txtPallet.DataBindings.Add(new Binding("Text", query, "PalletNum"));
                txtSerial.DataBindings.Add(new Binding("Text", query, "SerialNumberTextExpected"));
                dtExpectedDate.DataBindings.Add(new Binding("Text", query, "ExpectedDate"));
                cboEmp.DataBindings.Add(new Binding("Text", query, "AssignEmpNm"));
            }
        }

        
        
        private void LoadCombo()
        {
            // Load combo product

            cboProductNm.Properties.DataSource = getComboProduct().Select(i => new { i.Product_ID, i.ProductName }); 
            cboProductNm.Properties.ValueMember = "Product_ID";
            cboProductNm.Properties.DisplayMember = "ProductName";
            

            //Load Emp
            cboEmp.DataSource = db.App_User.Select(i => new { i.App_User_ID, i.FullName }).ToList();
            cboEmp.ValueMember = "App_User_ID";
            cboEmp.DisplayMember = "FullName";


        }

        private void btnSaveM_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            int SerFr, SerTo;
            if (!checkBeforeSave()) return;
            //try
            //{
            //     SerFr = Convert.ToInt32(txtSerialFr.Text.Trim().Remove(0, 1));
            //     SerTo = Convert.ToInt32(txtSerialTo.Text.Trim().Remove(0, 1));
            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi trong quá trình nhập serial", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}

            //if (!CheckExistSerialClient(SerFr,SerTo))
            //{
            //    System.Media.SoundPlayer player = new System.Media.SoundPlayer("Sound/FalseS.wav");
            //    player.Play();
            //    MessageBox.Show("Lỗi : đã tồn tại khoảng serial bị trùng, Vui lòng kiểm tra lại", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            string result = "";
            result = ApiHelper.CheckExistSerial(txtSerial.Text);
            List<QRCodeDuplicateOutput> lst  = new List<QRCodeDuplicateOutput>();
            if (result != null)
            {
                try
                {
                    //lst = ApiHelper.ParseJsonObject<QRCodeDuplicateOutput>(result);

                    if (!result.Contains("\"ResultCode\":\"0\""))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer("Sound/FalseS.wav");
                        player.Play();
                        MessageBox.Show(lst[0].Message, "Thông báo");
                        return;
                    }

                    //if (lst.Any())
                    //{
                    //    if (lst[0].ResultCode.Trim() != "0")
                    //    {
                    //        System.Media.SoundPlayer player = new System.Media.SoundPlayer("Sound/FalseS.wav");
                    //        player.Play();
                    //        MessageBox.Show(lst[0].Message, "Thông báo");
                    //        return;
                    //    }
                    //}
                }
                catch (Exception ex)
                {

                }
            }

            try
            {
                if (_PakageID > 0)
                {
                    Update();
                }
                else
                {
                    Save();
                    _PakageID = db.QRCodePackages.OrderByDescending(i => i.QRCodePackage_ID).FirstOrDefault().QRCodePackage_ID;
                    txtLot.Text = _PakageID.ToString();
                }                
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu:" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            splashScreenManager1.CloseWaitForm();
        }

        private void btnNewM_Click(object sender, EventArgs e)
        {
            New();
        }
       
        private bool checkBeforeSave()
        {
            if (String.IsNullOrEmpty(cboProductNm.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu tên sản phẩm", "Thông báo",MessageBoxButtons.OK);                
                cboProductNm.Focus();
                return  false;
            }
            if (String.IsNullOrEmpty(dtDateManu.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu ngày sản xuất", "Thông báo", MessageBoxButtons.OK);
                dtDateManu.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSerial.Text) )
            {
                MessageBox.Show("Vui lòng nhập dữ liệu serial", "Thông báo", MessageBoxButtons.OK);
                txtSerial.Focus();
                return  false;
            }
            if (String.IsNullOrEmpty(txtTotalTem.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu số lượng tem", "Thông báo", MessageBoxButtons.OK);
                txtTotalTem.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtPallet.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu số pallet", "Thông báo", MessageBoxButtons.OK);
                txtPallet.Focus();
                return false;
            }
            return true;
        }

        private List<ProductInfoOutput> getComboProduct()
        {
            List<ProductInfoOutput> lst = new List<ProductInfoOutput>();
            Uri url = new Uri("https://check.net.vn/plcservice/get_product.aspx?ProductBrand_ID=95");
            string jsonValues = ApiHelper.GetApi(url);
            if (jsonValues != null)
            {
               lst =  ApiHelper.ParseJsonObject<ProductInfoOutput>(jsonValues);
            }
            return lst;
        }

        private void cboEmp_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = sender as DevExpress.XtraEditors.LookUpEdit;
            EmpID = editor.GetColumnValue("AssignEmp").ToString();
        }

        

        private void cboProductNm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
      
        }

        private void cboProductNm_EditValueChanged_1(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = sender as DevExpress.XtraEditors.LookUpEdit;
            ProductID = Convert.ToInt32(editor.GetColumnValue("Product_ID"));
            if (ProductID != 0)
            {
                cboProductLabel.DataSource =
                    ApiHelper.getComboProductLabel(ProductID).Select(i => new {i.ProductLabel_ID, i.Name}).ToList();
                cboProductLabel.ValueMember = "ProductLabel_ID";
                cboProductLabel.DisplayMember = "Name";


                //Get Batch ID cboPatchNo
                cboPatchNo.DataSource = getComboBatch(ProductID).Select(i => new {i.Batch_ID, i.Name}).ToList();
                cboPatchNo.ValueMember = "Batch_ID";
                cboPatchNo.DisplayMember = "Name";
            }

            
        }

        

        private List<BatchInfoOutput> getComboBatch(int ProdID)
        {
            List<BatchInfoOutput> lst = new List<BatchInfoOutput>();
            Uri url = new Uri("https://check.net.vn/plcservice/get_batch.aspx?Product_ID=" + ProdID.ToString());
            string jsonValues = ApiHelper.GetApi(url);
            if (jsonValues != null)
            {
                lst = ApiHelper.ParseJsonObject<BatchInfoOutput>(jsonValues);
            }
            return lst;
        }

        private bool CheckExistSerialClient(int SerialFr,int SerialTo)
        {
            using (var db = new productionmanager_plcEntities())
            {
                var query = (from p in db.QRCodePackages
                    select new
                    {
                        p.SerialNumberStartExpected,
                        p.SerialNumberEndExpected
                    }).ToList();
                var qrFr = (from p in query.AsEnumerable()
                    where
                        (SerialFr >= Convert.ToInt32(p.SerialNumberStartExpected.Remove(0, 1))  &&
                         SerialFr <= Convert.ToInt32(p.SerialNumberEndExpected.Remove(0, 1)))
                    select new
                    {
                        p.SerialNumberStartExpected,
                        p.SerialNumberEndExpected
                    }).ToList();
                if (qrFr.Count > 0)
               {
                   return false;
               }
                var qrTo = (from p in query.AsEnumerable()
                    where
                        (SerialTo >= Convert.ToInt32(p.SerialNumberStartExpected.Remove(0, 1)) &&
                         SerialTo <= Convert.ToInt32(p.SerialNumberEndExpected.Remove(0, 1)))
                            select new
                    {
                        p.SerialNumberStartExpected,
                        p.SerialNumberEndExpected
                    }).ToList();
                if (qrTo.Count > 0)
               {
                   return false;
               }

               return true;
            }
        }

        private void txtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void txtSerial_Leave(object sender, EventArgs e)
        {
            txtTotalTem.Text = ApiHelper.GetListstrSerial(txtSerial.Text).Split(',').Count().ToString();
        }
    }
}
