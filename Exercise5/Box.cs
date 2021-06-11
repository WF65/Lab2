using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Box
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public int height { get; set; }

        public int getVolume()
        {
            return length * breadth * height;
        }
    }
}
