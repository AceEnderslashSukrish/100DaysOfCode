using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operations
    {
        float _num1 { get; set; }
        float _num2 { get; set; }

        public Operations(float num1, float num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public float Add()
        {
            return _num1 + _num2;
        }
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float Subtract()
        {
            return (_num1 - _num2);
        }

        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public float Divide()
        {
            return _num1 / _num2;
        }

        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        public float Multiply()
        {
            return _num1 * _num2;
        }

        public float Multiple(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
