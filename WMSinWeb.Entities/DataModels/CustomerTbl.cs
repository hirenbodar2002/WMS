using System;
using System.Collections.Generic;

namespace WMSinWeb.Entities.DataModels
{
    public partial class CustomerTbl
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public string? MobileNo { get; set; }
        public string? ContactNo { get; set; }
        public string? Companyname { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Addres { get; set; }
        public string Pssword { get; set; } = null!;
    }
}
