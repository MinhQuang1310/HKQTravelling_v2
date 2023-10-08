using HKQTravelling.Data;
using HKQTravelling.Models;
using Microsoft.AspNetCore.Mvc;

namespace HKQTravelling.Controllers
{
    public class TourController : Controller
    {
        //khai báo hàm app 
        private readonly ApplicationDBContext _db;

        public TourController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Tour> objTourList = _db.Tours.ToList();
            return View(objTourList);
        }
    }
}
