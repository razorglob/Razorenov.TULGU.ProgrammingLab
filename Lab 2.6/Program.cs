using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("<{0:F2}+{1:F2}>+{2:F2}={0:F2}+<{1:F2}+{2:F2}>", a, b, c, a + b + c);
            Console.Read();
        }
    }
}
