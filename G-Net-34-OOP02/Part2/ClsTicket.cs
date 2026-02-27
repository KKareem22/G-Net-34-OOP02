using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Part2
{
    internal class ClsTicket
    {
        private string _movieName;
        private decimal _price;
        public string MovieName
        {
            get { return _movieName; }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                    _movieName = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; }
        public static int ticketCounter = 0;
        public int TickectID { get; private set; }
        public ClsTicket(string moivename,decimal price,TicketType ticketType,Seat seat)
        {
            MovieName = moivename;
            Price = price;
            Type = ticketType;
            Seat = seat;
            ticketCounter++;
            TickectID = ticketCounter;
        }
        public decimal PriceAfterTax => Price *1.14m;
        public static int GetTotalTicketsSold => ticketCounter;
        



    }
}
