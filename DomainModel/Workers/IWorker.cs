using DomainModel.Time;

namespace DomainModel.Workers
{
    internal interface IWorker
    {
        string GetFirstName();
        string GetLastName();
        Information Info();
        string GetPosition();
        void ShowInfo();
        void EndTaskMessage(object sender, FinishTaskEventArgs e);
    }
}