using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PersonNew
    {
        public string UserName { get; set; }
        public DateTime BirthDate { get; private set; }
        public PersonNew(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                var years = timeSpan.Days;
                return years/365;
            }
        }
    }
}
