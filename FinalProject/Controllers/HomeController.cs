using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly LeagueDbContext _context;

        //Constructor 
        public HomeController(LeagueDbContext context)
        {
            _context = context;
        }

        //Action for index view
        public IActionResult Index()
        {
            //Get the list of champions from the database
            var champions = _context.Champs.ToList();

            //Pass champions to index view
            return View(champions);
        }
    }
}
