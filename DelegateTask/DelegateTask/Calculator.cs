using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    delegate int MathOperation(int x, int y);
    internal class Calculator
    {
        public int Sum(int x, int y) => x + y;
        public int Multiply(int x, int y) => x * y;
        public int Subtract(int  x, int y) => x - y;
        public int Divide(int x, int y) 
        {
            if (y == 0)
            {
                Console.WriteLine("Can't divide by zero");
                return 0;
            }
            else 
                return x / y;
        }
        public void PerformOperation(int x, int y,MathOperation mathOperation)
        {
            Console.WriteLine(mathOperation( x, y));
        }
    }
}
