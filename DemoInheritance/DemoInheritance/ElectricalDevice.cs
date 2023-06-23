using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public ElectricalDevice(bool ison,string brand)
        {
            this.IsOn = ison;
            this.Brand = brand;
        }
        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwithOff()
        {
            IsOn = false;
        }
    }
}
