using System;
using Microsoft.AspNetCore.Mvc;

namespace NetCore2.Controllers
{
    //Alterando a rota padrão do controller
    [Route("painel/admin")]
    public class AdminController : Controller
    {
        
        //Se mudar a rota padrão do controller, deve mapear cada metodo com verbo HTTP
        //De deixar vazio ele usa o nome do metodo. Pode ter mais de um mapeamento para o mesmo metodo.
        //[HttpGet("")]
        //metodo com parametro
        [HttpGet("principal/{nome}")]
        public IActionResult Index(string nome){
            return Content("Olá "+ nome);
        }

        //Tipando o parametro
        [HttpGet("numero/{num:int}")]
        public IActionResult Numero(int num){
            return Content("O nro é: "+ num);
        }

        [HttpGet("opcional/{nome?}")]
        public IActionResult Opcional(string nome){
            return Content("Olá "+ nome);
        }

        [HttpGet("son")]
        public IActionResult SchoolOfNet(){
            return Content("Novo teste");
        }

        [HttpGet("Query")]
        public IActionResult Query(){
            var nome = Request.Query["nome"];
            return Content("Nome via Query: "+ nome);
        }
    }
}