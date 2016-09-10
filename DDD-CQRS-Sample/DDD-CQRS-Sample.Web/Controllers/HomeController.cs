using Cadastro.Application.ViewModels;
using Cadastro.CQRS.CommandStack.Commands.NovoEspetaculo;
using Cadastro.CQRS.CommandStack.Interfaces;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries.EspetaculoPorId;
using Cadastro.CQRS.QueryStack.Queries.Espetaculos;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DDD_CQRS_Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        private IQueryDispatcher queryDispatcher;
        private ICommandDispatcher commandDispatcher;

        public HomeController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
        {
            this.queryDispatcher = queryDispatcher;
            this.commandDispatcher = commandDispatcher;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adicionar()
        {
            ViewBag.Message = "Your application description page.";
            
            var command = new NovoEspetaculoCommand("espetaculo", "sinopse", Guid.NewGuid(), Guid.NewGuid());
            commandDispatcher.Executar(command);

            return View("About");
        }

        public ActionResult BuscarTodos()
        {
            ViewBag.Message = "Your contact page.";

            var result = queryDispatcher.Executar<IEnumerable<EspetaculoViewModel>>();

            return View("Contact", result);
        }
    }
}