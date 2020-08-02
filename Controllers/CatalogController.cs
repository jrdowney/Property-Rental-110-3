using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;


namespace PropertyRental.Controllers {

    public class CatalogController : Controller {
    
        public IActionResult Test(){
            return View();
        }

        public IActionResult Index(){
            return View();
        }

        public IActionResult Admin(){
            return View();
        }

        // catalog/registerproperty
        [HttpPost]
        public IActionResult RegisterProperty([FromBody] Property p){
            System.Console.WriteLine("user is saving somthing");

            return Json(p);
        }
    }
}
