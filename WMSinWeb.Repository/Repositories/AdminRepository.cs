using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSinWeb.Entities.DataModels;
using WMSinWeb.Entities.ViewDataModel;
using WMSinWeb.Repository.Interface;

namespace WMSinWeb.Repository.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly WarehouseManagementContext _warehouseManagementContext;
        public AdminRepository(WarehouseManagementContext warehouseManagementContext)
        {
            _warehouseManagementContext = warehouseManagementContext;
        }

        public void Addcustomer(AddcustomerModel addcustomerModel)
        {
            var Registration = new CustomerTbl()
            {
                CustomerName = addcustomerModel.FirstName + " " + addcustomerModel.LastName,
                Addres = addcustomerModel.Addres,
                State = addcustomerModel.State,
                City = addcustomerModel.City,
                MobileNo = addcustomerModel.MobileNo.ToString(),
                EmailId = addcustomerModel.EmailId,
                Pssword = addcustomerModel.Password,
                Companyname = addcustomerModel.Companyname,





            };
            _warehouseManagementContext.CustomerTbls.Add(Registration);
            _warehouseManagementContext.SaveChanges();
        }

        public List<CustomerTbl> GetCustomerTbls()
        {
            var customer = _warehouseManagementContext.CustomerTbls.ToList();
            return customer;
        }
    }
}
