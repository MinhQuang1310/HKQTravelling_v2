using Microsoft.AspNetCore.Mvc;

namespace HKQTravelling.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
