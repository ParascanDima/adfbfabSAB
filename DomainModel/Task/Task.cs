using System;
using DomainModel.Time;
using DomainModel.Workers;

namespace DomainModel.Task
{
    internal class Task
    {
        private readonly Worker _worker;
        private readonly TaskTime Time;


        public Task(Worker worker = null, string taskName = null)
        {
            TaskName = taskName;
            Time = new TaskTime();
            _worker = worker;
            //endEvent.TaskIsFinishedEvent += EndTaskMessage;
        }

        internal string TaskName { get; set; }

        //public void EndTaskMessage(object sender, FinishTaskEventArgs e)
        //{
        //    var c = new string('\"', 4);
        //    if (_worker.GetLastName() != e._lastName && _worker.GetFirstName() != e._name)
        //    {
        //        Console.WriteLine($"{_worker.GetFirstName()} {_worker.GetLastName()} get the message: ");
        //        Console.WriteLine($" {c,15} {e._name} {e._lastName} ended the \"{e._task}\" at {e._time} {c,-15}\n");
        //    }
        //}

        //public void Unregister(EndTask ET) => ET.TaskIsFinishedEvent -= EndTaskMessage;


        public void SetEndTaskTime(TimeST? endTime, EndTask ET)
        {
            Time.SetStopTime(endTime);
            ET.SimulateFinishOfTask(_worker.GetFirstName(), _worker.GetLastName(), TaskName, Time.GetStopTime());
        }
    }
}