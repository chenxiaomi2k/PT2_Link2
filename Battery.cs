using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2_Link2
{
    internal class Battery
    {
        public int Energy { get; set; }

        public Battery()
        {
            Energy = 10;
        }

        public void decreaseEnergy()
        {
            Energy -= 2;
        }
    }
}
