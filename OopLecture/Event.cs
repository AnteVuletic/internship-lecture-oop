using System;

namespace OopLecture
{
    public class Event
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} - \n From: {StartDateTime} \n To: {EndDateTime} ";
        }

        public int GetTimespanInHours()
        {
            return (EndDateTime - StartDateTime).Hours;
        }
    }
}
