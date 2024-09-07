using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCSharpConsole
{
    class clsSimpleCalculator
    {
        private float _Result = 0;
        private float _LastNumber = 0;
        private string _LastOperation = "Clear";
        private bool _IsZero(float Number)
        {
            return (Number == 0);
        }

        public void Clear()
        {
            _Result = 0;
            _LastNumber = 0;
            _LastOperation = "Clear";
        }
        public void Add(float Num)
        {
            _LastNumber = _Result;
            _Result += Num;
            _LastOperation = "Add";
        }
        public void Subtract(float Num)
        {
            _LastNumber = _Result;
            _Result -= Num;
            _LastOperation = "Subtract";
        }
        public void PrintResult() { }
        public bool Divide(float Num)
        {
            _LastOperation = "Divide";
            if (_IsZero(Num))
            {
                _LastNumber = _Result;
                _Result /= 1;
                return false;
            }
            else
            {
                _LastNumber = _Result;
                _Result /= Num;
                return true;
            }
        }
        public void Multiply(float Num)
        {
            _LastNumber = _Result;
            _Result *= Num;
            _LastOperation = "Multiply";
        }

    }
    internal class SimpleCalculator

    {
        public static void ShowclsSimpleCalculator()
        {
            clsSimpleCalculator Calculator1 = new clsSimpleCalculator();
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
        }
    }
}
