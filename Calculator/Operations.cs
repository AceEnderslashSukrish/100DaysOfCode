using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        double _num1 { get; set; }
        double _num2 { get; set; }

        public Operations()
        {

        }
        public Operations(double num1, double num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public double Add()
        {
            return _num1 + _num2;
        }
        public double Add(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count-1; i++)
            {
                numbers[i+1] = numbers[i] + numbers[i+1];
            }
            return numbers[numbers.Count-1];
        }

        public double Subtract()
        {
            return (_num1 - _num2);
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide()
        {
            return _num1 / _num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply()
        {
            return _num1 * _num2;
        }

        public double Multiple(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
