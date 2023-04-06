using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSinWeb.Entities.DataModels;
using WMSinWeb.Entities.ViewDataModel;

namespace WMSinWeb.Repository.Interface
{
    public interface IAdminRepository
    {
        public void Addcustomer(AddcustomerModel addcustomerModel);

        public List<CustomerTbl> GetCustomerTbls();
    }
}
