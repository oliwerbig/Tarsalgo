using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    class Entity
    {
        public int Id { get; set; } = 0;
        public List<Event> Events = new();

        public Entity()
        {

        }

        public Entity(int id)
        {
            Id = id;
        }

        public TimeSpan CalculateTotalTimeIn()
        {
            TimeSpan totalTimeIn = new();

            List<Event> @in = new();
            List<Event> @out = new();
            foreach (Event e in Events) 
            {
                if (e.EntityId == Id)
                {
                    if (e.Direction == Direction.In)
                    {
                        @in.Add(e);
                    }
                    else if (e.Direction == Direction.Out)
                    {
                        @out.Add(e);
                    }
                }
            }

            Event endOfLogging = new();
            endOfLogging.TimeInMinutes = 900;
            @out.Add(endOfLogging);

            TimeStamp a = new();
            TimeStamp b = new();
            for (int i = 0; i< @in.Count; i++)
            {
                a.TimeInMinutes = @in[i].TimeInMinutes;
                b.TimeInMinutes = @out[i].TimeInMinutes;
                totalTimeIn.TimeInMinutes += a.calculateTimeElapsed(b).TimeInMinutes;
            }

            return totalTimeIn;
        }
    }
}
