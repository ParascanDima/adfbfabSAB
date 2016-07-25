namespace DomainModel.Time
{
    internal abstract class Calculate
    {
        public static TimeST Calc(TimeST startTime, TimeST? endTime)
        {
            if (endTime != null)
            {
                var temp = (TimeST) endTime;
                return temp - startTime;
            }
            return new TimeST();
        }
    }
}