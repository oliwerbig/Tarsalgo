using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    class Time
    {
        public int TimeInMinutes { get; set; } = 0;

        public Time()
        {

        }

        public Time(int hour, int minute)
        {
            setTimeByHourAndMinute(hour, minute);
        }

        public Time(int timeInMinutes) {
            TimeInMinutes = timeInMinutes;
        }
        
        public void setTimeByHourAndMinute(int hour, int minute)
        {
            TimeInMinutes = hour * minute;
        }

        public int getHour()
        {
            return TimeInMinutes / 60;
        }

        public int getMinute()
        {
            return TimeInMinutes % 60;
        }

        public string getTimeAsString()
        {
            return getHour().ToString() + ":" + getMinute().ToString();
        }
    }
}
