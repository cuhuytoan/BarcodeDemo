//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarcodeDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class QRCode
    {
        public int QRCode_ID { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<int> QRCodePackage_ID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.Guid> CreateBy { get; set; }
        public string PhyCode { get; set; }
        public Nullable<bool> IsOutRange { get; set; }
    }
}
