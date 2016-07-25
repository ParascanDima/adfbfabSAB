using DomainModel.Time;
using DomainModel.Workers;

namespace MyProject.Proxy
{
    internal interface INotify
    {
        void SubscribeThe<T>(T obj, EndTask ET) where T : IWorker;
    }
}