using Microsoft.AspNetCore.Mvc;
using MVC.Dados;
using MVC.Models;

namespace MVC.Controllers
{
    public class LocalController : Controller
    {

        Local locall = null;
        public IActionResult Index()
        {
            return View(Dados.Dados.locals);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Local local)
        {
            Dados.Dados.locals.Add(local);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remover(int? id)
        {
            Local idd = null;
            foreach (var item in Dados.Dados.locals)
            {
                if (item.Id == id)
                {
                    idd = item;
                }
            }
            return Remover(idd);
        }
        [HttpPost]
        public IActionResult Remover(Local idd)
        {
            Dados.Dados.locals.Remove(idd);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            foreach (Local item in Dados.Dados.locals)
            {
                if(item.Id == id)
                {
                    locall = item;
                }
            }

            return View(locall);
        }

        [HttpPost]
        public IActionResult Editar(Local locall)
        {
           
            foreach(Local item in Dados.Dados.locals)
            {
                if (locall.Id == item.Id )
                {
              
                    item.Name = locall.Name;
                    item.Rua = locall.Rua;
                    item.Numero = locall.Numero;
                    item.Bairro = locall.Bairro;
                    item.Cidade = locall.Cidade;
                    item.Cep = locall.Cep ;
                    item.Uf =locall.Uf ;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalhes(int? id)
        {
            foreach (Local item in Dados.Dados.locals)
            {
                if(item.Id == id)
                {
                    locall = item;
                }
            }
            return View(locall);
        }
    }
}
