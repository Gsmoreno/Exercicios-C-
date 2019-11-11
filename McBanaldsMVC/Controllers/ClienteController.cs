using Microsoft.AspNetCore.Mvc;

namespace McBanaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            ViewData["NomeView"] = "Home";
            return View();
        }
    }
}