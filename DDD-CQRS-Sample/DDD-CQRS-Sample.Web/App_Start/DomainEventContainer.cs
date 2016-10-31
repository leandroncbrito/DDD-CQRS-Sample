using Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDD_CQRS_Sample.Web.App_Start
{
    public class DomainEventContainer : IContainer
    {
        private readonly IDependencyResolver _resolver;

        public DomainEventContainer(IDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        public object GetInstance(Type serviceType)
        {
            return _resolver.GetService(serviceType);
        }

        public T GetInstance<T>()
        {
            return (T)_resolver.GetService(typeof(T));
        }

        public IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return _resolver.GetServices(serviceType);
        }

        public IEnumerable<T> GetAllInstances<T>()
        {
            return (IEnumerable<T>)_resolver.GetServices(typeof(T));
        }
    }
}