using System;
using System.Collections.Generic;
using System.Text;

namespace Övning2
{
    public class AddTickets
    {
        public List<Tickets> addTicket;


        public AddTickets()
        {
            addTicket = new List<Tickets>();

        }

       //public CalculateTicketPrice CalculatePrice()
        //{
        //    CalculateTicketPrice price = new CalculateTicketPrice();

        //    int sum = 0;
        //    foreach  (var agePrice in addTicket)
        //    {
                
        //        sum += agePrice;
        //    }
        //}

        

        public Tickets[] getTicket()
        {
            return addTicket.ToArray();
        }

        internal void AddTicket(int ticket)
        {
            addTicket.Add(new Tickets(ticket));
        } 
    }
}
