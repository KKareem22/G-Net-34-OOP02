using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Part2
{
    internal class Cinema
    {
        private ClsTicket[] _ticket = new ClsTicket[20];
        public ClsTicket this[int index]
        {
            get
            {
                if(index>=0 && index <_ticket.Length)
                    return _ticket[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < _ticket.Length)
                    _ticket[index] = value;
            }
        }
        public ClsTicket? GetMovieByName(string name)
        {
            foreach(var t in _ticket)
            {
                if (t != null && t.MovieName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return t;
            }
            return null;
        }
        public bool AddTicket(ClsTicket t)
        {
            for(int i=0;i<_ticket.Length;i++)
            {
                if (_ticket[i]==null)
                {
                    _ticket[i] = t;
                    return true;
                }                
            }
            return false;
        }
    }
}
