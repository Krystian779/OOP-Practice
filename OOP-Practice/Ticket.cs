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
        public Ticket()
        {
            AvailibleTickets = 0;
            Price = 0.0m;
            Name = "Default Ticket";
        }
        public Ticket(string name, decimal price, int availibleTickets)
        {
            AvailibleTickets = availibleTickets;
            Price = price;
            Name = name;
        }

        // Methods

        public override string ToString()
        {
            return $"{Name} - {Price:C} - [AVAILIBLE -{AvailibleTickets}]";
        }
    }
}
