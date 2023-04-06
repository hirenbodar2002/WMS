using System;
using System.Collections.Generic;

namespace WMSinWeb.Entities.DataModels
{
    public partial class ProductTbl
    {
        public int Productld { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Unit { get; set; }
        public double? PurchaseRate { get; set; }
        public double SaleRate { get; set; }
        public string? Companyname { get; set; }
        public double? Stock { get; set; }
        public int? Hsncode { get; set; }
        public double? Tax { get; set; }
        public string? Description { get; set; }
    }
}
