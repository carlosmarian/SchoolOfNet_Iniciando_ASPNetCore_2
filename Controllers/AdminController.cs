using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace NetCore2.Controllers
{
    //Alterando a rota padrão do controller
    [Route("painel/admin")]
    public class AdminController : Controller
    {

        [HttpGet("form")]    
        public IActionResult form(){
            return View();
        }
        [HttpPost("dados")]    
        public IActionResult dados(){
            StringValues nome;
            StringValues email;

            //Obter os valores do form
            Request.Form.TryGetValue("nome", out nome) ;
            Request.Form.TryGetValue("email", out email);

            return Content("Form Enviado: "+ nome+" "+email);
        }

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

        [HttpGet("view")]
        public IActionResult visualizar(){

            //Uma forma de passar parametro para a view
            ViewData["helloWorld"] = true;

            ViewData["nome"] = "Carlos";    
            return View();
        }

        [HttpGet("semnada")]
        public IActionResult semnada(){
            //Apresentar um view com nome dif do metodo.
            return View("nada");
        }
    }
}