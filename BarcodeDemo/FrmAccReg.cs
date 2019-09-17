using System;
using System.Linq;
using System.Windows.Forms;
namespace BarcodeDemo
{
    public partial class FrmAccReg : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;
        public Guid AccID { get; set; }
        public FrmAccReg()
        {
            InitializeComponent();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void FrmAccReg_Load(object sender, EventArgs e)
        {
            db = new productionmanager_plcEntities();
            
            if (AccID != Guid.Empty)
            {
                Inquiry(AccID);
            }
        }
        
        private void Save()
        {

            db.App_User.Add(new App_User()
            {
                App_User_ID = Guid.NewGuid(),
                UserName = txtUser.Text,
                Password =txtPwd.Text,
                FullName = txtFullName.Text,
                CreateDate = DateTime.Now,
                LastLoginDate = DateTime.Now,
                Factory_ID = ApiHelper.UserInfo.Factory_ID,
                ManageBy = ApiHelper.UserInfo.LoginID,
                ProductBrand_ID = 95
            });
            db.SaveChanges();
        }
        private void New()
        {
            txtFullName.Text = "";
            txtUser.Text = "";
            txtPwd.Text = "";
            txtRePwd.Text = "";
        }
        private void Delete()
        {
            App_User AccUpDate = db.App_User.SingleOrDefault(i => i.App_User_ID == AccID);
            db.App_User.Remove(AccUpDate);
            db.SaveChanges();
        }
        private void Update()
        {            
            
                App_User AccUpDate = db.App_User.SingleOrDefault(i=>i.App_User_ID == AccID);

                if (AccUpDate != null)
                {
                    AccUpDate.FullName = txtFullName.Text;
                    AccUpDate.Password = txtPwd.Text;
                    db.SaveChanges();
                }

               
        }
        private void Inquiry(Guid AccID)
        {
            var query = db.App_User.SingleOrDefault(i => i.App_User_ID == AccID);
            if (query != null)
            {
                txtFullName.Text = query.FullName;
                txtUser.Text = query.UserName;
                txtPwd.Text = query.Password;
                txtRePwd.Text = query.Password;
            }
        }

        private void btnInquiry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Inquiry();
        }
        
       

        private void btnSaveM_Click(object sender, EventArgs e)
        {
            if (!checkBeforeSave()) return;
            try
            {
                if (AccID != Guid.Empty)
                {
                    Update();
                }
                else
                {
                    Save();
                }                
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu:" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }

        private void btnNewM_Click(object sender, EventArgs e)
        {
            New();
        }
     

        private bool checkBeforeSave()
        {
            if (String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo",MessageBoxButtons.OK);
                txtFullName.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK);
                txtUser.Focus();
                return  false;
            }
            if (String.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txtPwd.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtRePwd.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txtRePwd.Focus();
                return false;
            }
            if (txtPwd.Text != txtRePwd.Text)
            {
                MessageBox.Show("Khác xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txtRePwd.Focus();
                return false;
            }
            return true;
        }

    }
}
