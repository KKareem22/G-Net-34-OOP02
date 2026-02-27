using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Part2
{
    public static class BookingHelper
    {
        private static int _refCounter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;
            return (numberOfTickets >= 5) ? total * 0.9 : total;
        }

        public static string GenerateBookingReference()
        {
            _refCounter++;
            return $"BK-{_refCounter}";
        }
    }
}
