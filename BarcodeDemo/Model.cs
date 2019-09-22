using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeDemo
{
    public class Model
    {

    }

    public class SentServer
    {
        public string Device_ID { get; set; }
        public string QRCodePackageType_ID { get; set; }
        public string Product_ID { get; set; }
        public string Batch_ID { get; set; }
        public string Factory_ID { get; set; }
        public string ProductLabel_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string QRCodeNumber { get; set; }
        public string SerialNumberStart { get; set; }
        public string SerialNumberEnd { get; set; }
        public string SerialNumberText { get; set; }
        public string ManufactureShift { get; set; }
        public string ManufactureDate { get; set; }
        public string UserName { get; set; }
        public string AgentVersion { get; set; }
    }

    public class ComboCode
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }

    public class ProductInfoOutput
    {
        public string QRCodeContent { get; set; }
        public string QRCodeType_ID { get; set; }
        public string ResultCode { get; set; }
        public string Product_ID { get; set; }
        public string ProductName { get; set; }
        public string ProductURL { get; set; }
        public string ProductImageURL { get; set; }
        public string ProductPrice { get; set; }
        public string ProductBrand_ID { get; set; }
        public string ProductBrandName { get; set; }
        public string ProductCategory_ID { get; set; }
        public string ProductCategoryName { get; set; }
    }

    public class ProductLabelInfoOutput
    {
        public string ProductLabel_ID { get; set; }
        public string Name { get; set; }
        public string Product_ID { get; set; }
        public string ProductName { get; set; }
    }

    public class BatchInfoOutput
    {
        public string Batch_ID { get; set; }
        public string Name { get; set; }
        public string Product_ID { get; set; }
        public string ProductName { get; set; }
    }

    public class QRCodeDuplicateOutput
    {
        public string TotalCode { get; set; }
        public string TotalCodeDuplicate { get; set; }
        public string SerialNumberDuplicateText { get; set; }
        public string Message { get; set; }
        public string ResultCode { get; set; }
    }

    public class QRCodeLst
    {
        public int? QRCodePackage_ID { get; set; }
        public string LstQrCode { get; set; }
    }

    public class UserLogin
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Factory_ID { get; set; }
    }

    public class PrintData
    {
        public string FactoryName { get; set; }
        public string QRCode { get; set; }
        public string ProductName { get; set; }
        public string Baobi { get; set; }
        public string PalletNum { get; set; }
        public string CreateDate { get; set; }
        public string PackageName { get; set; }
    }
}
