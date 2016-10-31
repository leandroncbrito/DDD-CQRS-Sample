using Cadastro.Application.Adapter;
using Cadastro.CQRS.CommandStack.Events;
using Cadastro.Data.Interfaces.Espetaculos;
using Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.CQRS.CommandStack.Handlers.Espetaculos
{
    public class EspetaculoCadastradoEventHandler : IDomainHandler<EspetaculoCadastradoEvent>
    {
        private List<EspetaculoCadastradoEvent> _notifications;
        private readonly IEspetaculoRepositoryMongoDb repositoryMongoDb;

        public EspetaculoCadastradoEventHandler(IEspetaculoRepositoryMongoDb repositoryMongoDb)
        {
            this.repositoryMongoDb = repositoryMongoDb;
        }

        public void Handle(EspetaculoCadastradoEvent args)
        {
            // TODO: Enviar email
            var model = EspetaculoAdapter.ToViewModel(args.Espetaculo);
            repositoryMongoDb.Adicionar(model);
        }

        public IEnumerable<EspetaculoCadastradoEvent> Notify()
        {
            return GetValues();
        }

        public bool HasNotifications()
        {
            return GetValues().Count > 0;
        }

        public List<EspetaculoCadastradoEvent> GetValues()
        {
            return _notifications;
        }

        public void Dispose()
        {
            _notifications = new List<EspetaculoCadastradoEvent>();
        }
    }
}
