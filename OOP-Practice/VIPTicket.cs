using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class VIPTicket:Ticket
    {
        // Properties
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }

        //Constructors

        // Methods

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
