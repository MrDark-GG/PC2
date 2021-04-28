using Microsoft.AspNetCore.Mvc;

namespace PC2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult login(){
            return View();
        }
    }
}