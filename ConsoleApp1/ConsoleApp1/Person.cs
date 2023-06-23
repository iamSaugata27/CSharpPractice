using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        private DateTime _birthDate;
        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }
        public DateTime GetBirthDate()
        {
            return _birthDate;
        }
    }
}
