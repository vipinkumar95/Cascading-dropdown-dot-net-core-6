using Cascading_dropdown.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cascading_dropdown.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public JsonResult Country()
        {
            var data = db.Countries.ToList();
            return new JsonResult(data);
        }

        public JsonResult State(int id)
        {
            var st = db.States.Where(x => x.CountryId == id).ToList();
            return new JsonResult(st);
        }


        public JsonResult City(int id)
        {
            var ct = db.Cities.Where(x => x.stateId == id).ToList();
            return new JsonResult(ct);
        }

        public IActionResult Cascaddropdown()
        {   
            return View();
        }

        
        
    }
}
