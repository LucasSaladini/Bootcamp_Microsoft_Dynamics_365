using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathOperators.Models
{
    public class Calculator
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Division(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Power(int x, int y)
        {
            double power = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {power}");
        }
    }
}