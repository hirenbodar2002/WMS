using System;
using System.Collections.Generic;

namespace WMSinWeb.Entities.DataModels
{
    public partial class TransactionTbl
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public double SubTotal { get; set; }
        public double TaxAmount { get; set; }
        public double NetAmount { get; set; }
        public double PaidAmount { get; set; }
        public double Balance { get; set; }
        public string? Type { get; set; }
    }
}
