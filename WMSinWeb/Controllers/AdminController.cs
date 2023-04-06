using Microsoft.AspNetCore.Mvc;
using WMSinWeb.Entities.DataModels;
using WMSinWeb.Entities.ViewDataModel;
using WMSinWeb.Repository.Interface;

namespace WMSinWeb.Controllers
{
    public class AdminController : Controller
    {
        public readonly WarehouseManagementContext _warehouseManagementContext;

        public readonly IAdminRepository _adminRepository;

        public AdminController(WarehouseManagementContext warehouseManagementContext, IAdminRepository adminRepository)
        {
            
            _warehouseManagementContext = warehouseManagementContext;
            _adminRepository = adminRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult Supplier()
        {
            return View();
        }
        public IActionResult Customer()
        {
            var customer = _adminRepository.GetCustomerTbls();

            Admin model = new Admin();
            model.CustomerTbls = customer;
            return View(model);
        }

        [HttpPost]
        public IActionResult Addcustomer(AddcustomerModel addcustomerModel)
        {
            _adminRepository.Addcustomer(addcustomerModel);
            return RedirectToAction("Customer","Admin");
        }
    }
}
