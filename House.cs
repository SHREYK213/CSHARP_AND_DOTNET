using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    struct House
    {
        public House(int numberOfWindows, string color)
        {
            NumberOfWindows = numberOfWindows;
            Color = color;
        }

        public int NumberOfWindows { get; set; }
        public string Color { get; set; }
    }
}
