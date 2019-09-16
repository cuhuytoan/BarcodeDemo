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
    public partial class FrmPhuyNum : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string PhuyNum { get; set; }
        public FrmPhuyNum()
        {
            InitializeComponent();
        }


        private void FrmLotReg_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnSaveM_Click(object sender, EventArgs e)
        {
            PhuyNum = txtPhuyNum.Text.Trim();
            this.Close();
        }
        
    }
}
