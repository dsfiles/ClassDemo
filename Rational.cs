using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    internal class Rational
    {
        public int numerator, denominator;
        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public void Display()
        {
            Console.WriteLine($"{this.numerator}/{this.denominator}");
        }

        public static void Display2(Rational r)
        {
            Console.WriteLine($"{r.numerator}/{r.denominator}");
        }
        public void Invert()
        {
            int temp = numerator;
            numerator = denominator;
            denominator = temp;
        }
    }
}
