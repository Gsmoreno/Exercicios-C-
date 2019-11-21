using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;
using McBanaldsMVC.Repositories;

namespace McBanaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]

        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("================================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("================================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)
                {
                    
                }
                else
                {
                    return View("Erro");
                }

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