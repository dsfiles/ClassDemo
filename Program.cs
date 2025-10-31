using System.IO.Pipelines;

namespace Rational
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(4, 6);
            r1.Display();
            r1.Invert();
            r1.Display();
            Rational.Display2(r1);
            /*
             *  public static void Display2(Rational r)
        {
               Console.WriteLine($"{r.numerator}/{r.denominator}");
        }
             */
        }
    }
}
