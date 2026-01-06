using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Ticket
    {
        // Properties

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailibleTickets { get; set; }

        //Constructors

        // Methods

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
