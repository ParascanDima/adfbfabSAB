using System;

namespace DomainModel.Time
{
    class FinishTaskEventArgs : EventArgs
    {
        public readonly string _name, _lastName, _task;
        public TimeST? _time;

        public FinishTaskEventArgs(string name, string lastName, string task, TimeST? time)
        {
            _name = name;
            _lastName = lastName;
            _task = task;
            _time = time;
        }
    }
}
