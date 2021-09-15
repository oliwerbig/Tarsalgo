using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    class Event
    {
        private int entityId { get; set; } = 0;
        private Direction direction = Direction.In;

        public Event(string payload)
        {
            parsePayload(payload);
        }

        string getDirectionAsString()
        {
            return directionToString[getDirection()];
        }

        void setDirectionFromString(string directionString)
        {
            if (directionString == directionToString[In])
            {
                setDirection(Direction.In);
            }
            else if (directionString == directionToString[Out])
            {
                setDirection(Direction.Out);
            }
        }

        void parsePayload(string payload)
        {
            char splitDelimiter = ' ';
            List<string> values = new List<string>();
            string[] items = payload.Split(' ');

            foreach(string item in items)
            {
                values.Add(item);
            }

            setTime(stoi(values[0]), stoi(values[1]));
            setEntityId(stoi(values[2]));
            setDirectionFromString(values[3]);
        }
    }
}
