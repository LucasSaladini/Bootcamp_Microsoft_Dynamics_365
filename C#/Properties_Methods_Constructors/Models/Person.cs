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
            get => _name.ToUpper(); //Body expression
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
            get => _age;  //Body expression

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