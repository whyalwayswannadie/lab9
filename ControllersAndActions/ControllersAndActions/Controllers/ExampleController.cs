using System.Web.Mvc;
using System;
namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {

        public ViewResult Index()
        {
            ViewBag.Message = "Привет";
            ViewBag.Date = DateTime.Now;
            return View();
        }
    }
}
