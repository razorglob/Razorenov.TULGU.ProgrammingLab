﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}/{1:F3}={2:F3}", a, b, a / b);
            Console.Read();

        }
    }
}
