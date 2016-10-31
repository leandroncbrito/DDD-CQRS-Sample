using System;
using System.Collections.Generic;

namespace Core.Domain.Interfaces
{
    public interface IContainer
    {
        T GetInstance<T>();
        object GetInstance(Type serviceType);
        IEnumerable<T> GetAllInstances<T>();
        IEnumerable<object> GetAllInstances(Type serviceType);
    }
}