using Cadastro.CQRS.CommandStack.Commands.NovoEspetaculo;
using Cadastro.CQRS.CommandStack.Interfaces;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries.EspetaculoPorId;
using System;
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

        public ActionResult BuscarPorId()
        {
            ViewBag.Message = "Your contact page.";

            var query = new EspetaculoPorIdQuery(new Guid("55CC4540-E880-452F-A231-CAC888C3D185"));
            var result = queryDispatcher.Executar<EspetaculoPorIdQuery, EspetaculoPorIdResult>(query);

            return View("Contact");
        }
    }
}