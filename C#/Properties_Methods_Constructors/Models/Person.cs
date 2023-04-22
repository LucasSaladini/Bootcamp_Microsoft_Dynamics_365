using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Properties_Methods_Constructors.Models
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _name = value;
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser inferior a zero");
                }

                _age = value;
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"Nome: {Name}, Idade: {Age}");
        }
    }
}