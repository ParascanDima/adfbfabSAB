using System;
using DomainModel.Time;
using DomainModel.Workers;
using VirtualDataBase.Factory;

namespace VirtualDataBase.Demo.Factory
{
    internal class MemberFactory
    {
        public static IWorker CreateMember<T>(Action<T> options, EndTask ET = null) where T : IOptions, new()
        {
            var tempOptions = new T();

            options?.Invoke(tempOptions);

            return tempOptions.Apply(ET);
        }
    }
}