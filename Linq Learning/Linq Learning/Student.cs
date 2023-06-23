using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Learning
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with ID {Id}, Gender {Gender} and Age {Age} from University with ID {UniversityId}");
        }
    }
}
