using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Indexers
    {
        private readonly Dictionary<string, string> _myDictionary = new();

        public string this[string key]
        {
            get { return _myDictionary[key]; }
            set { _myDictionary[key] = value; }
        }
    }
}
