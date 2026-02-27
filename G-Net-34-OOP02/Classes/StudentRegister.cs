using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Classes
{
    internal class StudentRegister
    {
        private string[] students = new string[5];
        public string this[int index]
        {
            get
            {
                if(index >=0 && index <students.Length)
                    return students[index];
                return "Not in range";
            }
            set
            {
                if (index >= 0 && index < students.Length)
                    students[index] = value;
            }
        }
    }
}
