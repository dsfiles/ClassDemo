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
            int d = Gcd(numerator, denominator);
            this.numerator = numerator/d;
            this.denominator = denominator/d;
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


        public Rational Add(Rational r1, Rational r2)
        {
            int numerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            int denominator = r1.denominator * r2.denominator;
            return new Rational(numerator, denominator);

        }

        public static int Gcd(int a, int b)
        {
            // Base case: If b is 0, then a is the GCD.
            if (b == 0)
            {
                return a;   
            }
            else
            {
                return Gcd(b, a % b);
            }
        }

    }
}
