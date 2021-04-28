using Microsoft.AspNetCore.Mvc;

namespace PC2.Controllers
{
    public class RegistroControllers : Controller
    {
        public IActionResult registrate(){
            return View();
        }
    }
}