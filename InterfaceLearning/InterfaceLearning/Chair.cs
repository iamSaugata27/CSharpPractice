using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLearning
{
    internal class Chair:Furniture,IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }
        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair has destroyed!");
            Console.WriteLine($"Playing Destruction Sound {DestructionSound}");
            Console.WriteLine("Spawning Chair parts");
        }
    }
}
