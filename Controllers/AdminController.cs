using System;
using Microsoft.AspNetCore.Mvc;

namespace NetCore2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(){
            return Content("Olá Mundo");
        }

        public IActionResult SchoolOfNet(){
            return Content("Novo teste");
        }
    }
}