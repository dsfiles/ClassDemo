using System.IO.Pipelines;

namespace Rational
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(4, 6);
           
            r1.Display();
            Rational.Display2(r1);
            Rational r2 = new Rational(3, 9);
            var r3 = r1.Add(r1, r2);
            r3.Display();
            /*
             *  
           public Rational Add(Rational r1, Rational r2)
            {
            int numerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            int denominator = r1.denominator * r2.denominator;
            return new Rational(numerator, denominator);

        }
        }
             */
        }
    }
}
