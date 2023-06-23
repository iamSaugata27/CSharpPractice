using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    internal class TV:ElectricalDevice
    {
        public TV(bool ison,string brand):base(ison,brand)
        {

        }
        public void WatchTV()
        {
            if (IsOn)
                Console.WriteLine("Watching TV!!");
            else
                Console.WriteLine("TV is switched off, swith on first");
        }
    }
}
