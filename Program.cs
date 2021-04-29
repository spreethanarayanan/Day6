using System;

namespace DAY6
{
    class Program
    {
       public  static  Tuple <double , double,double> Calc(double a, double b)
        {
            return new Tuple<double, double,double>((a + b), (a - b),(a * b));
        }
        static void Main(string[] args)
        {
            Tuple<double, double,double> output = Program.Calc(1.2, 3.4);
            Console.WriteLine("sum=" + output.Item1);
            Console.WriteLine("sub=" + output.Item2);
            Console.WriteLine("mul=" + output.Item3);
            Console.ReadLine();





        }

    }
}
