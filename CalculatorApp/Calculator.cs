using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Calculator
    {
        private int x = 0 , y = 0;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Add()
        {
            return x + y;
        }
        public int Subtract()
        {
            return x - y;
        }
        public int Multiply()
        {
            return x * y;
        }
        public string Divide()
        {
            if (y == 0)
            {
                return "Cannot divide by zero";
            }
            return (x / y).ToString();
        }
    }
}
