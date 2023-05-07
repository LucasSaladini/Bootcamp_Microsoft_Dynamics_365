using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Models
{
    public class Person
    {
        public Person() { }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname => $"{Name} {Surname}".ToUpper();
    }
}