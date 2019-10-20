using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("с= ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);
            Console.Read();

        }
    }
}
