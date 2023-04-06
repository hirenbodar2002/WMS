using System;
using System.Collections.Generic;

namespace WMSinWeb.Entities.DataModels
{
    public partial class SupplierTbl
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? EmailId { get; set; }
        public string? MobileNo { get; set; }
        public string? ContactNo { get; set; }
        public string? Companyname { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}
