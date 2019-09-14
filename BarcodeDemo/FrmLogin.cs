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
    public partial class FrmLogin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;
        private Guid LoginID;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            if (!CheckLogin()) return;
            
            // Account sản xuất
            if (cboAccountType.SelectedValue.ToString() == "1")
            {
                string strUrl =
                    String.Format("https://check.net.vn/plcservice/get_login.aspx?Username={0}&Password={1}",
                        txtUser.Text, txtPwd.Text);

                Uri url = new Uri(strUrl);
                try
                {
                    LoginID = Guid.Parse(ApiHelper.GetApi(url));
                    if (LoginID != Guid.Empty)
                    {
                        ApiHelper.UserInfo.LoginID = LoginID;
                        ApiHelper.UserInfo.AccountType = cboAccountType.SelectedValue.ToString();
                        var frm = new FrmDashBoardAdmin();
                        this.Hide();
                        frm.ShowDialog();
                        frm.WindowState = FormWindowState.Maximized;
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtUser.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng nhập thất bại, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
            }
            else
            {
                var queryLoginID = db.App_User.Where(
                    i => i.UserName == txtUser.Text.Trim() && i.Password == txtPwd.Text.Trim()).FirstOrDefault();
                if (queryLoginID == null)
                {
                    MessageBox.Show("Đăng nhập thất bại, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                if (queryLoginID.App_User_ID.ToString() != "0")
                {
                    ApiHelper.UserInfo.LoginID = queryLoginID.App_User_ID;
                    ApiHelper.UserInfo.AccountType = cboAccountType.SelectedValue.ToString();
                    ApiHelper.UserInfo.UserName = queryLoginID.UserName;
                    ApiHelper.UserInfo.FullName = queryLoginID.FullName;
                    var frm = new FrmDashBoard();
                    this.Hide();
                    frm.ShowDialog();
                    frm.WindowState = FormWindowState.Maximized;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
            }
           
            

        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            db = new productionmanager_plcEntities();
            label1.Text = "PHẦN MỀM TỰ ĐỘNG HÓA KÍCH HOẠT TEM CHỐNG GIẢ PETROLIMEX \r\n  CÔNG NGHỆ CHECKVN";
            cboAccountType.DataSource = db.App_Role.ToList();
            cboAccountType.DisplayMember = "Name";
            cboAccountType.ValueMember = "App_Role_ID";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckLogin()
        {
            if (String.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPwd.Focus();
                return false;
            }

            return true;
        }

        private void OpenMainDialog()
        {
           
        }

    }
}
