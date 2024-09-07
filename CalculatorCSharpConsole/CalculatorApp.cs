using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    enum Operations
    {
        Add = 1,
        Subtract,
        Multiply,
        Div,
        Mod,
        Pow,
        Sqrt,
        Ln,
        Log10,
        Sin,
        Cos,
        Tan,
        ArcSin,
        ArcCos,
        ArcTan,
        Sinh,
        Cosh,
        Tanh,
        Clear,
        Exist
    }

    class Calculator
    {
        private double _pi = Math.PI;
        private double _result = 0;
        private double _lastNumber = 0;
        private double _previousResult = 0;
        private string _lastOperation = "Add";
        private string _previousOperation = "Add";
        private List<string> _previousOperations = new List<string>();

        private void ChangeOperation(string operation)
        {
            _previousOperation = _lastOperation;
            _previousOperations.Add(operation);
            _lastOperation = operation;
        }

        public double ConvertRadiansToDegrees(double num)
        {
            return num * (_pi / 180);
        }

        public void CancelLastOperation()
        {
            _previousOperations.RemoveAt(_previousOperations.Count - 1);
            _lastOperation = _previousOperation;
            _previousOperation = _previousOperations[_previousOperations.Count - 1];
        }

        public void PrintResult()
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine($"Result After {_lastOperation} {_lastNumber} is: {_result}");
        }

        public void SetNumber(double num)
        {
            _lastNumber = num;
            _previousResult = _result;
            _result = num;
            ChangeOperation("SetNumber");
        }

        public void Clear()
        {
            _lastNumber = 0;
            _previousResult = _result;
            _result = 0;
            ChangeOperation("Clear");
        }

        public void Add(double num)
        {
            _lastNumber = num;
            _previousResult = _result;
            _result += num;
            ChangeOperation("Add");
        }

        public void Subtract(double num)
        {
            _lastNumber = num;
            _previousResult = _result;
            _result -= num;
            ChangeOperation("Subtract");
        }

        public void Multiply(double num)
        {
            _lastNumber = num;
            _previousResult = _result;
            _result *= num;
            ChangeOperation("Multiply");
        }

        public void Divide(double num)
        {
            _lastNumber = num;
            _previousResult = _result;
            if (num == 0)
            {
                Console.WriteLine("YOU CAN'T DIVIDE ON ZERO");
            }
            else
            {
                _result /= num;
            }
            ChangeOperation("Divide");
        }

        public void Mod(double num)
        {
            _lastNumber = num;
            _previousResult = _result;
            _result = (int)_result % (int)num;
            ChangeOperation("Mod");
        }

        public void Pow(double num)
        {
            _lastNumber = num;
            _previousResult = _result;
            _result = Math.Pow(_result, num);
            ChangeOperation("Pow");
        }

        public void Sqrt()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Sqrt(_result);
            ChangeOperation("Sqrt");
        }

        public void Ln()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Log(_result);
            ChangeOperation("Ln");
        }

        public void Log10()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Log10(_result);
            ChangeOperation("Log10");
        }

        public void Sin()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Sin(_result);
            ChangeOperation("Sin");
        }

        public void Cos()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Cos(_result);
            ChangeOperation("Cos");
        }

        public void Tan()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Tan(_result);
            ChangeOperation("Tan");
        }

        public void ArcSin()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Asin(_result);
            ChangeOperation("ArcSin");
        }

        public void ArcCos()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Acos(_result);
            ChangeOperation("ArcCos");
        }

        public void ArcTan()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Atan(_result);
            ChangeOperation("ArcTan");
        }

        public void Sinh()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Sinh(_result);
            ChangeOperation("Sinh");
        }

        public void Cosh()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Cosh(_result);
            ChangeOperation("Cosh");
        }

        public void Tanh()
        {
            _lastNumber = _result;
            _previousResult = _result;
            _result = Math.Tanh(_result);
            ChangeOperation("Tanh");
        }
        public void PerformOperation(Operations op, double num = 0)
        {
            switch (op)
            {
                case Operations.Add: Add(num); break;
                case Operations.Subtract: Subtract(num); break;
                case Operations.Multiply: Multiply(num); break;
                case Operations.Div: Divide(num); break;
                case Operations.Mod: Mod(num); break;
                case Operations.Pow: Pow(num); break;
                case Operations.Sqrt: Sqrt(); break;
                case Operations.Ln: Ln(); break;
                case Operations.Log10: Log10(); break;
                case Operations.Sin: Sin(); break;
                case Operations.Cos: Cos(); break;
                case Operations.Tan: Tan(); break;
                case Operations.ArcSin: ArcSin(); break;
                case Operations.ArcCos: ArcCos(); break;
                case Operations.ArcTan: ArcTan(); break;
                case Operations.Sinh: Sinh(); break;
                case Operations.Cosh: Cosh(); break;
                case Operations.Tanh: Tanh(); break;
                case Operations.Clear: Clear(); break;
                default: Console.WriteLine("Invalid operation!"); break;
            }
        }

        public static void ShowOperations()
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("                        Calculator                       ");
            Console.WriteLine("=========================================================");
            Console.WriteLine($"{"1.",-5} {"Add",-10} {"2.",-5} {"Subtract",-10} {"3.",-5} {"Multiply"}");
            Console.WriteLine($"{"4.",-5} {"Divide",-10} {"5.",-5} {"Mod",-10} {"6.",-5} {"Pow"}");
            Console.WriteLine($"{"7.",-5} {"Sqrt",-10} {"8.",-5} {"Ln",-10} {"9.",-5} {"Log10"}");
            Console.WriteLine($"{"10.",-5} {"Sin",-10} {"11.",-5} {"Cos",-10} {"12.",-5} {"Tan"}");
            Console.WriteLine($"{"13.",-5} {"ArcSin",-10} {"14.",-5} {"ArcCos",-10} {"15.",-5} {"ArcTan"}");
            Console.WriteLine($"{"16.",-5} {"Sinh",-10} {"17.",-5} {"Cosh",-10} {"18.",-5} {"Tanh"}");
            Console.WriteLine($"{"19.",-5} {"Clear",-10} {"20.",-5} {"Exist",-10}");
            Console.WriteLine("=========================================================");

        }
    }

    class CalculatorProgram
    {
        public static void StartCalculator()
        {

            Calculator calculator = new Calculator();
            int operation;
            double num;

            Calculator.ShowOperations(); // Show operations at the start
            Console.Write("Enter the number: ");
            num = Convert.ToDouble(Console.ReadLine());
            calculator.SetNumber(num);

            while (true)
            {
                Console.Write("Enter the operation number: ");
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation == (int)Operations.Exist)
                {
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("End Calculator :(");
                    Console.WriteLine("=========================================================");
                    Environment.Exit(0);
                }
                if (operation == (int)Operations.Clear || operation == (int)Operations.Sqrt || operation == (int)Operations.Ln || operation == (int)Operations.Log10 ||
          operation == (int)Operations.Sin || operation == (int)Operations.Cos || operation == (int)Operations.Tan || operation == (int)Operations.ArcSin ||
          operation == (int)Operations.ArcCos || operation == (int)Operations.ArcTan || operation == (int)Operations.Sinh || operation == (int)Operations.Cosh ||
          operation == (int)Operations.Tanh)
                {
                    calculator.PerformOperation((Operations)operation);
                }
                else
                {
                    Console.Write("Enter the number: ");
                    num = Convert.ToDouble(Console.ReadLine());
                    calculator.PerformOperation((Operations)operation, num);
                }

                if (operation == (int)Operations.Clear)
                {
                    Console.Clear();
                    Calculator.ShowOperations();
                }

                calculator.PrintResult();
            }
        }


    }
}
