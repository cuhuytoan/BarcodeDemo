﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class productionmanager_plcEntities : DbContext
    {
        public productionmanager_plcEntities()
            : base("name=productionmanager_plcEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<App_Role> App_Role { get; set; }
        public virtual DbSet<App_UserInRole> App_UserInRole { get; set; }
        public virtual DbSet<QRCodePackage> QRCodePackages { get; set; }
        public virtual DbSet<QRCodeProductStatu> QRCodeProductStatus { get; set; }
        public virtual DbSet<QRCode> QRCodes { get; set; }
        public virtual DbSet<App_User> App_User { get; set; }
    
        public virtual int QRCodePackage_Search(string keyword, Nullable<int> product_ID, Nullable<int> productBrand_ID, Nullable<int> factory_ID, Nullable<int> qRCodeProductStatus_ID, Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, Nullable<System.Guid> createBy, Nullable<System.Guid> manageBy, Nullable<int> pageSize, Nullable<int> currentPage, ObjectParameter itemCount)
        {
            var keywordParameter = keyword != null ?
                new ObjectParameter("Keyword", keyword) :
                new ObjectParameter("Keyword", typeof(string));
    
            var product_IDParameter = product_ID.HasValue ?
                new ObjectParameter("Product_ID", product_ID) :
                new ObjectParameter("Product_ID", typeof(int));
    
            var productBrand_IDParameter = productBrand_ID.HasValue ?
                new ObjectParameter("ProductBrand_ID", productBrand_ID) :
                new ObjectParameter("ProductBrand_ID", typeof(int));
    
            var factory_IDParameter = factory_ID.HasValue ?
                new ObjectParameter("Factory_ID", factory_ID) :
                new ObjectParameter("Factory_ID", typeof(int));
    
            var qRCodeProductStatus_IDParameter = qRCodeProductStatus_ID.HasValue ?
                new ObjectParameter("QRCodeProductStatus_ID", qRCodeProductStatus_ID) :
                new ObjectParameter("QRCodeProductStatus_ID", typeof(int));
    
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var createByParameter = createBy.HasValue ?
                new ObjectParameter("CreateBy", createBy) :
                new ObjectParameter("CreateBy", typeof(System.Guid));
    
            var manageByParameter = manageBy.HasValue ?
                new ObjectParameter("ManageBy", manageBy) :
                new ObjectParameter("ManageBy", typeof(System.Guid));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));
    
            var currentPageParameter = currentPage.HasValue ?
                new ObjectParameter("CurrentPage", currentPage) :
                new ObjectParameter("CurrentPage", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("QRCodePackage_Search", keywordParameter, product_IDParameter, productBrand_IDParameter, factory_IDParameter, qRCodeProductStatus_IDParameter, fromDateParameter, toDateParameter, createByParameter, manageByParameter, pageSizeParameter, currentPageParameter, itemCount);
        }
    }
}
