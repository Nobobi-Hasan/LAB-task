using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator bc = new BasicCalculator();
            ScientificCalculator sc = new ScientificCalculator();

            Console.WriteLine("Basic calculator operatrions.....");
            Console.WriteLine("_________________________________");
            Console.WriteLine(bc.sum(10, 5));
            Console.WriteLine(bc.sub(10, 5));
            Console.WriteLine(bc.multiplication(10, 5));
            Console.WriteLine(bc.division(10, 5));

            Console.WriteLine("");


            Console.WriteLine("Scientific calculator operatrions.....");
            Console.WriteLine("______________________________________");
            Console.WriteLine(sc.sum(10, 5));
            Console.WriteLine(sc.sub(10, 5));
            Console.WriteLine(sc.multiplication(10, 5));
            Console.WriteLine(sc.division(10, 5));
            Console.WriteLine(sc.XtoY(10, 5));
            Console.WriteLine(sc.sin(0));


        }
    }
}
