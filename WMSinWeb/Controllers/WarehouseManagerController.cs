using Microsoft.AspNetCore.Mvc;

namespace WMSinWeb.Controllers
{
    public class WarehouseManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TotalStock()
        {
            return View();
        }

        public IActionResult PurchaseItems()
        {
            return View();
        }
        public IActionResult AddItems()
        {
            return View();
        }
        public IActionResult SellItems()
        {
            return View();
        }

        public IActionResult Suppliers()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

    }
}
