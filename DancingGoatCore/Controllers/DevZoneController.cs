using Microsoft.AspNetCore.Mvc;

namespace DancingGoat.Controllers
{
    public class DevZoneController : Controller
    {
        [HttpGet("/devzone")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/devzone/form")]
        public IActionResult Form() { 
            return View();  
        }

    }
}
