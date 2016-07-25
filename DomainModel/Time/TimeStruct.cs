namespace DomainModel.Time
{
    struct TimeST
    {
        public int minutes, hours;

        public TimeST(int _hours, int _minutes)
        {
            minutes = _minutes;
            hours = _hours;
        }

        public void CheckTime()
        {
            if (minutes > 60)
            {
                minutes -= 60;
                hours++;
                if (hours > 60)
                {
                    hours -= 24;
                }
            }

            if (hours > 23)
            {
                hours -= 24;
            }
        }

        public static TimeST operator +(TimeST left, TimeST right)
        {
            left.minutes += right.minutes;
            left.hours += right.hours;
            left.CheckTime();

            return left;
        }

        public static TimeST operator -(TimeST left, TimeST right)
        {
            left.minutes -= right.minutes;
            left.hours -= right.hours;
            left.CheckTime();

            return left;
        }

        public static TimeST operator +(TimeST left, int hours)
        {
            left.hours += hours;
            left.CheckTime();

            return left;
        }

        public static TimeST operator -(TimeST left, int hours)
        {
            left.minutes -= hours;
            left.CheckTime();

            return left;
        }

        public static bool operator ==(TimeST left, TimeST right)
        {
            return (left.minutes == right.minutes && left.hours == right.hours);
        }

        public static bool operator !=(TimeST left, TimeST right)
        {
            return (left.minutes != right.minutes || left.hours != right.hours);
        }

        public static bool operator >(TimeST left, TimeST right)
        {
            bool result = true;

            if (left.hours == right.hours)
            {
                if (left.minutes == right.minutes)
                {
                    result = false;
                }
                else if (left.minutes < right.minutes)
                {
                    result = false;
                }
            }
            else if (left.hours < right.hours)
            {
                result = false;
            }

            return result;
        }

        public static bool operator <(TimeST left, TimeST right)
        {
            bool result = false;

            if (left.hours == right.hours)
            {
                if (left.minutes == right.minutes)
                {
                    result = true;

                }
                else if (left.minutes < right.minutes)
                {
                    result = true;
                }
            }
            else if (left.hours < right.hours)
            {
                result = true;
            }

            return result;
        }

        public static bool operator <=(TimeST left, TimeST right)
        {
            return (left == right || left < right);
        }

        public static bool operator >=(TimeST left, TimeST right)
        {
            return (left == right || left > right);
        }

        public static TimeST operator ++(TimeST left)
        {
            left.hours++;

            left.CheckTime();

            return left;
        }

        public static TimeST operator --(TimeST left)
        {
            left.hours--;

            left.CheckTime();

            return left;
        }

        public override string ToString()
        {
            return " " + hours + "h  " + minutes + "m  ";
        }

        
    }    
}