using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2_Link2
{
    internal class FlashLamp
    {
        public bool Status { get; set; }
        private Battery battery;

        public FlashLamp()
        {
            Status = false;
            battery = null;
        }

        public void setBattery(Battery b)
        {
            battery = b;
        }

        public int getBatteryInfo()
        {
            if (battery.Energy > 0)
            {
                return battery.Energy;
            }
            return 0;
        }

        public void turnOn()
        {
            Status = true;
            if (battery.Energy > 0)
            {
                Console.WriteLine("Den sang!");
            }
        }

        public void turnOff()
        {
            Status = false;
            Console.WriteLine("Den tat!");
        }
    }
}
