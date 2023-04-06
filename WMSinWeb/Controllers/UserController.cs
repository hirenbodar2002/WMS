using Microsoft.AspNetCore.Mvc;
using WMSinWeb.Entities.DataModels;
using WMSinWeb.Entities.ViewDataModel;
using WMSinWeb.Repository.Interface;

namespace WMSinWeb.Controllers
{
    public class UserController : Controller
    {
        public readonly WarehouseManagementContext _warehouseManagementContext;
        public readonly IUserRepository _userRepository;

        public UserController(WarehouseManagementContext warehouseManagementContext, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _warehouseManagementContext = warehouseManagementContext;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginTbl login)
        {
            var count = _userRepository.Login(login);
            var userid = _warehouseManagementContext.LoginTbls.Where(a => a.UserName == login.UserName && a.Pass == login.Pass && a.UserCategory == login.UserCategory).FirstOrDefault();
            if (count == 1)
            {
                HttpContext.Session.SetString("userId", (userid.UserName).ToString());
                return RedirectToAction("Index", "Admin");

            }
            else if (count == 2)
            {
                HttpContext.Session.SetString("userId", (userid.UserName).ToString());
                return RedirectToAction("Index", "WarehouseManager");
            }

            else
            {
                return RedirectToAction("Login", "User");

            }

        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationModel registrationModel)
        {


            _userRepository.Registration(registrationModel);
            return RedirectToAction("Login", "User");


        }
    }
}
