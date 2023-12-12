using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ContatoController : Controller
    {
        
        Contato contato1 = null;
        Contato contato11 = null;
        public IActionResult Index()
        {
            return View(Dados.Dados.contatos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            Dados.Dados.contatos.Add(contato);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remover(int? Id)
        {
            Contato variavel = null;
            foreach (var contato in Dados.Dados.contatos)
            {
                if (contato.Id == Id)
                {
                    variavel = contato;
                }
            }
            return Remover(variavel);
        }
        [HttpPost]
        public IActionResult Remover(Contato variavel)
        {
            Dados.Dados.contatos.Remove(variavel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int? Id)
        {

            foreach (var contato in Dados.Dados.contatos)
            {
                if(contato.Id == Id) { 
                    contato1 = contato;
                }
            }
            return View(contato1);
            
        }

        [HttpPost]
        public IActionResult Editar(Contato contato1)
        {
            foreach(var contato in Dados.Dados.contatos)
            {
                if (contato.Id == contato1.Id)
                {
                    contato.Name = contato1.Name;
                    contato.Email = contato1.Email;
                    contato.Fone= contato1.Fone;

                }
            }    
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detalhes(int? id)
        {
            foreach (var contato in Dados.Dados.contatos)
            {
                if (contato.Id == id)
                {
                    contato11 = contato;
                }
            }
            return View(contato11);
        }



    }
}
