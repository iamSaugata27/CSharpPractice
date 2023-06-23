using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var rating = CalculateRatings();
            if(rating==0)
                Console.WriteLine("Promoted To Level 0");
            else
                Console.WriteLine("Promoted To Level Higher");
        }
        private int CalculateRatings()
        {
            return 0;
        }
    }
}
