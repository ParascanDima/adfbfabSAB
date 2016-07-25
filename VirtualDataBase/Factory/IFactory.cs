using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Workers;
using VirtualDataBase.Demo.Factory;

namespace VirtualDataBase.Factory
{
    interface IFactory
    {
        IWorker CreateMember(Action<IOptions> options);
    }
}
