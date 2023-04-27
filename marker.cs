using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class marker
    {
        public string brandName;
        public string productName;
        public string color;
        public int maxInkCapesity;
        public int currentInkCapesity;

        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
