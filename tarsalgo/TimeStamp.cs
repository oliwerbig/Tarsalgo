using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    class TimeStamp : Time
    {
        public List<Event> Events { get; set; } = new List<Event>();
        public Dictionary<int, Entity> EntitiesInside { get; set; } = new Dictionary<int, Entity>();

        public TimeStamp()
        {

        }

        public TimeStamp(int hour, int minute) : base(hour, minute)
        {

        }

        public TimeStamp(int timeInMinutes) : base(timeInMinutes)
        {
        }

        public TimeSpan calculateTimeElapsed(TimeStamp otherTimeStamp)
        {
            TimeSpan timeElapsed = new TimeSpan(otherTimeStamp.TimeInMinutes - TimeInMinutes);
            return timeElapsed;
        }
    }
}
