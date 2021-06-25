using Aula1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1.Controllers {
    public class ClienteController : Controller {

        // GET: Cliente
        public ActionResult Teste() {

            var cliente = new Cliente() {

                Nome = "ASP",
                SobreNome = "NET",
                DataCadastro = DateTime.Now,
                Id = 1
            };

            //ViewBag.Cliente = cliente;

            ViewData["Cliente"] = cliente;

            return View("Index", cliente);
        }

            
        public ActionResult Lista() {

            var listaClientes = new List<Cliente>() {

                new Cliente() {Nome="João", SobreNome="Pedro", DataCadastro = DateTime.Now, Id=1 },
                new Cliente() { Nome = "Beltrano", SobreNome = "Fulano", DataCadastro = DateTime.Now, Id = 2 }
        };

            return View(listaClientes);
        }
        public ActionResult Pesquisa(int? id, string nome) {

            var listaClientes = new List<Cliente>() {

                new Cliente() {Nome="João", SobreNome="Pedro", DataCadastro = DateTime.Now, Id=1 },
                new Cliente() { Nome = "Beltrano", SobreNome = "Fulano", DataCadastro = DateTime.Now, Id = 2 },
                new Cliente() { Nome = "Beto", SobreNome = "Fulano", DataCadastro = DateTime.Now, Id = 3 },
                new Cliente() { Nome = "Ale", SobreNome = "Jorge", DataCadastro = DateTime.Now, Id = 4 },
                new Cliente() { Nome = "Beto", SobreNome = "Lopes", DataCadastro = DateTime.Now, Id = 5 }
        };

            var cliente = listaClientes.Where(c=> c.Nome == nome).ToList();

            if (!cliente.Any())
            {
                TempData["erro"] = "Nenhum cliente selecionado";
                return RedirectToAction("ErroPesquisa");
            }

            return View("Lista", cliente);
        }
 
        public ActionResult ErroPesquisa()
        {
            return View("Error");
        }
    }
}