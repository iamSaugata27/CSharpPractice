using System;

namespace DemoInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, "Sony");
            radio.SwitchOn();
            radio.ListenRadio();

            TV mytv = new TV(true, "LG");
            mytv.SwithOff();
            mytv.WatchTV();
        }
    }
}
