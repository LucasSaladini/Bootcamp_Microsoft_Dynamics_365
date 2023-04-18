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

        public void Sin(double angle)
        {
            double radian = angle * Math.PI / 180;
            double sin = Math.Sin(radian);
            Console.WriteLine($"Seno de {angle} = {Math.Round(sin, 4)}");
        }

        public void Cos(double angle)
        {
            double radian = angle * Math.PI / 180;
            double cos = Math.Cos(radian);
            Console.WriteLine($"Cosseno de {angle} = {Math.Round(cos, 4)}");
        }

        public void Tan(double angle)
        {
            double radian = angle * Math.PI / 180;
            double tan = Math.Tan(radian);
            Console.WriteLine($"Tangente de {angle} = {Math.Round(tan, 4)}");
        }

        public void SquareRoot(double x)
        {
            double root = Math.Sqrt(x);
            Console.WriteLine($"Raíz quadrada de {x} = {root}");
        }
    }
}