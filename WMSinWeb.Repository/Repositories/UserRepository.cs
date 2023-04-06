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
    public class UserRepository : IUserRepository
    {
        private readonly WarehouseManagementContext _warehouseManagementContext;
        public UserRepository(WarehouseManagementContext warehouseManagementContext)
        {
            _warehouseManagementContext = warehouseManagementContext;
        }
        public int Login(LoginTbl login)
        {
            var starus = _warehouseManagementContext.LoginTbls.Where(m => m.UserName == login.UserName).FirstOrDefault();
            if (starus.UserCategory == "A")
            {
                return 1;
            }
            else if (starus.UserCategory == "W")
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public void Registration(RegistrationModel registrationModel)
        {
            var Registration = new CustomerTbl()
            {
                CustomerName = registrationModel.FirstName + registrationModel.LastName,
                Addres = registrationModel.Addres,
                State = registrationModel.State,
                City = registrationModel.City,
                MobileNo = registrationModel.MobileNo.ToString(),
                EmailId = registrationModel.EmailId,
                Pssword = registrationModel.Password,
                Companyname = registrationModel.Companyname,
                



            };
            _warehouseManagementContext.CustomerTbls.Add(Registration);
            _warehouseManagementContext.SaveChanges();
        }
    }
}
