using Cadastro.Data.Interfaces;
using Core.Domain.Events;
using Core.Domain.Interfaces;
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
        protected readonly IDomainHandler<DomainNotification> Notifications;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this.Notifications = DomainEvent.Container.GetInstance<IDomainHandler<DomainNotification>>();
        }

        public bool Commit()
        {
            if (Notifications.HasNotifications())
                return false;

            _unitOfWork.Commit();
            return true;
        }

        public void RollBack()
        {
            _unitOfWork.Dispose();
        }

    }
}
