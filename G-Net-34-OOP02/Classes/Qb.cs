using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Classes
{
    internal class Qb
    {
        private double _balance;
        private string _owner;
        public string Owner { get; set; }
        public double Balance
        {
            get
            { if (_balance < 0)
                    return -1;
            return _balance;
            }
            set
            {
                if(value>=0)
                    _balance = value;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
                _balance -= amount;
        }
    }
}
