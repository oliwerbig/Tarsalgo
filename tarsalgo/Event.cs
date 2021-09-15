using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    class Event : Time
    {
        public int EntityId { get; set; } = 0;
        public Direction Direction { get; set; }  = Direction.In;
        static readonly string[] DirectionToString = new string[] { "be", "ki" };


        public Event()
        {

        }

        public Event(string payload) : base()
        {
            ParsePayload(payload);
        }

        public string GetDirectionAsString()
        {
            return DirectionToString[(int)Direction];
        }

        void SetDirectionFromString(string directionString)
        {
            if (directionString == DirectionToString[(int)Direction.In])
            {
                Direction = Direction.In;
            }
            else if (directionString == DirectionToString[(int)Direction.Out])
            {
                Direction = Direction.Out;
            }
        }

        void ParsePayload(string payload)
        {
            char splitDelimiter = ' ';
            List<string> values = payload.Split(splitDelimiter).ToList();

            setTimeByHourAndMinute(Int32.Parse(values[0]), Int32.Parse(values[1]));
            EntityId = Int32.Parse(values[2]);
            SetDirectionFromString(values[3]);
        }
    }
}
