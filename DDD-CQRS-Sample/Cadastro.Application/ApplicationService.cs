using Cadastro.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        //protected readonly IHandler<DomainNotification> Notifications;
        //protected AlunoCadastradoHandler AlunoCadastradoHandler;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            //this.Notifications = DomainEvent.Container.GetInstance<IHandler<DomainNotification>>();
            //this.AlunoCadastradoHandler = DomainEvent.Container.GetInstance<AlunoCadastradoHandler>();
        }

        public bool Commit()
        {
            //if (Notifications.HasNotifications())
                //return false;

            _unitOfWork.Commit();
            return true;
        }
    }
}
