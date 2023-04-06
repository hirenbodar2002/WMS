using System;
using System.Collections.Generic;

namespace WMSinWeb.Entities.DataModels
{
    public partial class LoginTbl
    {
        public string UserName { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public string UserCategory { get; set; } = null!;
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Pincode { get; set; }
    }
}
