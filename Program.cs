using System.IO.Pipelines;

namespace Rational
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(2, 3);
            r1.Display();
            r1.Invert();
            r1.Display();
        }
    }
}
