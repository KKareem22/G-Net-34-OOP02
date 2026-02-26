using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP02.Classes
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                    _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;
            }
        }
        public double Area => Length * Width;
    }
}
