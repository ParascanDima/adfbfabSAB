using System;

namespace DomainModel.Time
{
    class EndTask
    {
        public event EventHandler<FinishTaskEventArgs> TaskIsFinishedEvent;

        protected virtual void EventCheck(FinishTaskEventArgs e) => TaskIsFinishedEvent?.Invoke(this, e);

        public void SimulateFinishOfTask(string name, string lastName, string task, TimeST? time)
        {
            var e = new FinishTaskEventArgs(name, lastName, task, time);

            EventCheck(e);

        }

    }
}
