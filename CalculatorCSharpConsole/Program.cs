﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCSharpConsole
{
    class clsCalculator
    {
        public void Clear() { }
        public void Add(float Num) { }
        public void Subtract(float Num) { }
        public void PrintResult() { }
        public void Divide(float Num) { }
        public void Multiply(float Num) { }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator();


            Calculator1.Clear();

            Calculator1.Add(10);
            Calculator1.PrintResult();

            Calculator1.Add(100);
            Calculator1.PrintResult();

            Calculator1.Subtract(20);
            Calculator1.PrintResult();

            Calculator1.Divide(0);
            Calculator1.PrintResult();

            Calculator1.Divide(2);
            Calculator1.PrintResult();

            Calculator1.Multiply(3);
            Calculator1.PrintResult();

            Calculator1.Clear();
            Calculator1.PrintResult();

            Console.ReadLine();
        }
    }
}