using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Part2
{
    internal struct Seat
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }
        public override string ToString()
        {
            return $"{Row}_{Number}";
        }

    }
}
