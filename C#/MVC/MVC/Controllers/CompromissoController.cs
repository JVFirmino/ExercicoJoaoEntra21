using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Dados;
using MVC.Models;

namespace MVC.Controllers
{
    public class CompromissoController : Controller
    {

        Compromisso comp = null;

        public IActionResult Index()
        {
            return View(Dados.Dados.compromissos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> Contatos = new List<SelectListItem>();
            List<SelectListItem> Locals = new List<SelectListItem>();

            Contatos = Dados.Dados.contatos.Select(c => new SelectListItem()
            { Text = c.Email, Value = c.Name.ToString() }).ToList();

            Locals = Dados.Dados.locals.Select(c => new SelectListItem()
            { Text = c.Name, Value = c.Name.ToString() }).ToList();

            ViewBag.Contatos = Contatos;
            ViewBag.Locals = Locals;
            return View();

        }
        [HttpPost]
        public IActionResult Create(Compromisso compromisso)
        {
            Dados.Dados.compromissos.Add(compromisso);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Remover(int? id)
        {
            foreach (var item in Dados.Dados.compromissos)
            {
                if (item.Id == id)
                {
                    comp = item;
                }
            }
            return Remover(comp);
        }
        [HttpPost]
        public IActionResult Remover(Compromisso compromisso)
        {
            Dados.Dados.compromissos.Remove(comp);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            List<SelectListItem> Contatos = new List<SelectListItem>();
            List<SelectListItem> Locals = new List<SelectListItem>();

            Contatos = Dados.Dados.contatos.Select(c => new SelectListItem()
            { Text = c.Email, Value = c.Name.ToString() }).ToList();

            Locals = Dados.Dados.locals.Select(c => new SelectListItem()
            { Text = c.Name, Value = c.Name.ToString() }).ToList();

            ViewBag.Contatos = Contatos;
            ViewBag.Locals = Locals;

            foreach (var item in Dados.Dados.compromissos)
            {
                if(item.Id == id)
                {
                    comp = item;
                }
            }
            return View(comp);
        }

        public IActionResult Editar(Compromisso comp)
        {

            foreach (var item in Dados.Dados.compromissos)
            {
                if (item.Id == comp.Id)
                {
                    item.Data = comp.Data;
                    item.Local = comp.Local;
                    item.Contato = comp.Contato;
                    item.Situacao = comp.Situacao;
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalhes(int? id)
        {

            foreach (var item in Dados.Dados.compromissos)
            {
                if (item.Id == id)
                {
                    comp = item;
                }
            }

            return View(comp);
        }
    }
}
