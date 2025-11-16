using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Data;
using Shopping.Client.Models;
using System.EnterpriseServices;
using System.Web.Mvc;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public  ActionResult Index()
        {
            return View(ProductContext.Products);
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}