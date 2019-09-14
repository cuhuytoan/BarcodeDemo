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
    public partial class FrmSerialEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        productionmanager_plcEntities db;

        public int QrCodeID { get; set; }
        public string SerialOld { get; set; }
        public int QRCodePackage_ID { get; set; }
        public FrmSerialEdit()
        {
            InitializeComponent();
        }


        private void FrmLotReg_Load(object sender, EventArgs e)
        {
            txtOldSerial.Text = SerialOld;
        }

        private void Save()
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveM_Click(object sender, EventArgs e)
        {
            Update();
            
        }

        private void Update()
        {
            if (!CheckExistsBarcode())
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Sound/FalseS.wav");
                player.Play();
                var Confirm = MessageBox.Show("Barcode đã tồn tại bạn có muốn lưu thêm?",
                    "Xác nhân!!",
                    MessageBoxButtons.YesNo);
                if (Confirm == DialogResult.Yes)
                {
                    using (var db = new productionmanager_plcEntities())
                    {
                        QRCode query = db.QRCodes.SingleOrDefault(p => p.QRCode_ID == QrCodeID);

                        if (query != null)
                        {
                            query.SerialNumber = txtNewSerial.Text;
                            db.SaveChanges();
                            MessageBox.Show("Hoàn thành cập nhập Serial",
                                "Xác nhân!!");
                        }

                    }
                }
            }
        }
        private bool CheckExistsBarcode()
        {
            bool fl = true;
            List<QRCode> lst = db.QRCodes.Where(p => p.QRCodePackage_ID == QRCodePackage_ID).ToList();
            if (lst != null && lst.Count > 0)
            {
                foreach (var p in lst)
                {
                    if (p.SerialNumber == txtNewSerial.Text)
                    {
                        fl = false;
                        return fl;
                    }
                }
            }
            return fl;
        }
    }
}
