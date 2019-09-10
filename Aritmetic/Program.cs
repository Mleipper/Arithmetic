using Arithmetic.Calc;
using System;

namespace Aritmetic
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] data = { 1, 2, 3 };
            var calc = new Calculator(data);
            Console.WriteLine(calc.getStatsPrintOut());
            Console.ReadKey();
        }
    }
}
