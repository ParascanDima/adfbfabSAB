using System.Collections.Generic;
using DomainModel.Workers;

namespace VurtualDataBase.Interface
{
    internal interface IWorkerData
    {
        List<T> GetDataBase<T>() where T : IWorker;
    }
}