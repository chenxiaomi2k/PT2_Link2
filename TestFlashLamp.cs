using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2_Link2
{
    internal class TestFlashLamp
    {
        static void Main(string[] args)
        {
            Battery b = new Battery();
            FlashLamp f = new FlashLamp();
            f.setBattery(b);
            for (int i = 0; i < 9; i++)
            {
                f.turnOn();
                b.decreaseEnergy();
                f.turnOff();
            }
            Console.WriteLine("Nang luong con lai trong Pin: {0}", f.getBatteryInfo());
        }
    }
}
