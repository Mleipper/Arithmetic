using Arithmetic.Calc;
using System;
using System.IO;
using System.Linq;

namespace Aritmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

                double Value;
                double[] data2;
                //linq to get file data
                var values = File.ReadAllLines("SampleData.csv")
                .SelectMany(a => a.Split(',')
                .Select(str => double.TryParse(str, out Value) ? Value : 0));

                data2 = values.ToArray();
               

                double[] data = { 1, 2, 3 };
                
                var calc = new Calculator(data2);
                Console.WriteLine(calc.getStatsPrintOut());
                Console.WriteLine();
                calc.printBininfo();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be found");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
