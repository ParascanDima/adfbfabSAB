using System;
using DomainModel.Workers;

namespace DomainModel.Time
{
    internal class WorkTime
    {
        private readonly TimeST _spentTimeMinutes;
        private readonly Worker _worker;

        public WorkTime(WorkTime obj)
        {
            _worker = obj._worker;
            StartTime = obj.StartTime;
            StopTime = obj.StopTime;
        }

        public WorkTime(Worker worker, TimeST clockIn, TimeST clockOut)
        {
            _worker = worker;
            _spentTimeMinutes = Calculate.Calc(clockIn, clockOut);
        }

        private TimeST? StartTime { get; }
        private TimeST? StopTime { get; }

        public void ShowInfo()
        {
            _worker.ShowInfo();

            Console.WriteLine($"Spent time on work: {_spentTimeMinutes}");
        }

        public override string ToString() => $"{_worker} Spent time on work: {_spentTimeMinutes}";
    }
}