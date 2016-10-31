using Cadastro.Application.ViewModels;
using Cadastro.CQRS.CommandStack.Commands.Espetaculos;
using Cadastro.CQRS.CommandStack.Interfaces;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries.Espetaculo;
using System;
using System.Collections.Generic;
using System.Linq;
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

            //var command = new NovoEspetaculoCommand("espetaculo", string.Empty, Guid.NewGuid(), Guid.NewGuid());
            var command = new NovoEspetaculoCommand("Meu Espetáculo", "Novo espetáculo", Guid.NewGuid(), Guid.NewGuid());
            commandDispatcher.Executar(command);

            return View("About");
        }

        public ActionResult Buscar()
        {
            ViewBag.Message = "Your contact page.";

            var result = queryDispatcher.Executar<IEnumerable<EspetaculoViewModel>>();

            var espetaculo = queryDispatcher.Executar<EspetaculoPorIdQuery, EspetaculoViewModel>(new EspetaculoPorIdQuery(result.FirstOrDefault().EspetaculoId));

            return View("Contact", result);
        }
    }
}