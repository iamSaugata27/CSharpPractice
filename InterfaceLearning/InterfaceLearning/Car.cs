﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLearning
{
    internal class Car:Vehicle,IDestroyable
    {
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyableNearby { get; set; }
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplotion.mp3";
            DestroyableNearby = new List<IDestroyable>();
        }
        public void Destroy()
        {
            Console.WriteLine($"Playing Destruction Sound {DestructionSound}");
            Console.WriteLine("Create Fire");
            foreach (IDestroyable destroyable in DestroyableNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
