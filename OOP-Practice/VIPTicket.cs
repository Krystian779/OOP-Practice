using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class VIPTicket : Ticket
    {
        // Properties
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }

        //Constructors
        public VIPTicket() : this("") { }

        public VIPTicket(string name) : this(name, 0m, 0, "", 0m) { }



        public VIPTicket(string name, decimal price, int availibleTickets, string additionalExtras, decimal additionalCost) : base(name, price, availibleTickets)
        {
            AdditionalExtras = additionalExtras;
            AdditionalCost = additionalCost;
        }

        // Methods

        public override string ToString()
        {
            return $"{Name}-{Price + AdditionalCost:C}-{AdditionalExtras}- [AVAILIBLE - {AvailibleTickets}]";
        }
    }
}
