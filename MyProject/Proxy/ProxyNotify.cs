using DomainModel.Time;
using DomainModel.Workers;

namespace MyProject.Proxy
{
    class ProxyNotify: INotify
    {
        private Notify _notify;
        public void SubscribeThe<T>(T obj, EndTask ET) where T : IWorker
        {
            _notify = new Notify();
            _notify.SubscribeThe<T>(obj, ET);
        }
    }
}
