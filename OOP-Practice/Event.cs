using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Event: IComparable<Event>
    {
        public enum EventType
        {
            Music,
            Comedy,
            Theatre,
            
        }
        // Properties
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; }
        public EventType TypeOfEvent { get; set; }

        //Constructors
        
        // Methods
        public int CompareTo(Event other)
        {
            return this.EventDate.CompareTo(other.EventDate);
        }

    }
}
