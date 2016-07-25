using DomainModel.Time;
using DomainModel.Workers;

namespace MyProject.Proxy
{
    internal class Notify : INotify
    {
        public void SubscribeThe<T>(T obj, EndTask ET) where T : IWorker
        {
            ET.TaskIsFinishedEvent += obj.EndTaskMessage;
        }

        public void Notification(object sender, FinishTaskEventArgs ET)
        {

        }
    }


}