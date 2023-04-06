using System;
using System.Collections.Generic;

namespace WMSinWeb.Entities.DataModels
{
    public partial class TransactionOutTbl
    {
        public int? TransactionId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}
