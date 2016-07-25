using System.ComponentModel;

namespace DomainModel.Time
{
    internal class TaskTime
    {
        private readonly TimeST _spentTaskTime ;


        public TaskTime()
        {
            _spentTaskTime = default(TimeST);
            StartTime = new TimeST();
            StopTime = null;
        }

        public TaskTime(TimeST start)
        {
            StartTime = start;
            StopTime = null;
            //spentTaskTime = Calculate.Calc(startTime, stopTime);
        }

        private TimeST StartTime { get; set; }
        private TimeST? StopTime { get; set; }

        public void SetStopTime(TimeST? t) => StopTime = t;

        public TimeST? GetStopTime() => StopTime;

        public TimeST GetSpentTaskTime() => _spentTaskTime;
    }
}