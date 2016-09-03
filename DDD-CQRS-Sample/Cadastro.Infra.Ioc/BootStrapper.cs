using Cadastro.CQRS.CommandStack.Commands.NovoEspetaculo;
using Cadastro.CQRS.CommandStack.Dispatcher;
using Cadastro.CQRS.CommandStack.Interfaces;
using Cadastro.CQRS.QueryStack.Dispatcher;
using Cadastro.CQRS.QueryStack.Interfaces;
using Cadastro.CQRS.QueryStack.Queries.EspetaculoPorId;
using Cadastro.Data.Context;
using Cadastro.Data.Interfaces;
using Cadastro.Data.Repository;
using Cadastro.Data.UoW;
using Domain.Espetaculos;
using SimpleInjector;

namespace Cadastro.Infra.Ioc
{
    public class BootStrapper
    {

        public static Container _container { get; set; }

        public static void Register(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe;
            // Lifestyle.Scoped => Uma instancia unica para o request;

            _container = container;

            //// APP
            //container.Register<IAlunoAppService, AlunoAppService>(Lifestyle.Scoped);

            //// Domain
            //container.Register<IAlunoService, AlunoService>(Lifestyle.Scoped);

            //// Infra Dados Repos
            container.Register<IRepository<Espetaculo>, Repository<Espetaculo>>(Lifestyle.Scoped);

            //// Infra Dados
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CadastroContext>(Lifestyle.Scoped);

            //// Handlers
            //container.Register<IHandler<DomainNotification>, DomainNotificationHandler>(Lifestyle.Scoped);
            //container.Register<IHandler<AlunoCadastradoEvent>, AlunoCadastradoHandler>(Lifestyle.Scoped);
            var assembliesCommand = new[] { typeof(NovoEspetaculoCommandHandler).Assembly };
            var assembliesQuery = new[] { typeof(EspetaculoPorIdQueryHandler).Assembly };
            //var assembliesEvent = new[] { typeof(SendNotificationHandler).Assembly };

            container.Register(typeof(ICommandHandler<>), assembliesCommand, Lifestyle.Scoped);
            container.Register(typeof(IQueryHandler<,>), assembliesQuery, Lifestyle.Scoped);
            //container.RegisterCollection(typeof(IDomainHandler<>), assembliesEvent);

            container.Register(typeof(ICommandDispatcher), typeof(CommandDispatcher));
            container.Register(typeof(IQueryDispatcher), typeof(QueryDispatcher));
            //container.Register(typeof(IEventDispatcher), typeof(SimpleInjectorEventContainer));

            //// Infra Core
            //container.Register<IEnvioEmail, EnvioEmail>(Lifestyle.Singleton);

            //// Identity
            //container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            //container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()), Lifestyle.Scoped);
            //container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(), Lifestyle.Scoped);
            //container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            //container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            //container.Register<ApplicationSignInManager>(Lifestyle.Scoped);
        }
    }
}
