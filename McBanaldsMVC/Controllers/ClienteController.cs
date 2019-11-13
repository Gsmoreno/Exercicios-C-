using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;

namespace McBanaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("================================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("================================");

                return View("Sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
                
            }
        }
    }
}