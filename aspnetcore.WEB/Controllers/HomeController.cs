using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void Submit(string myInput)
        {
            Index();
        }
    }
}
