using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekrutacja
{
    public class SimpleCalculator
   {

        public double Calculate(double x, double y, char operation)
        {
            switch (operation)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    if (y == 0)
                    {
                        throw new DivideByZeroException("You cannot divide by zero");
                    }
                    return x / y;
                default:
                    throw new Exception($"{operation} is not a proper operation");

            }
        }
    }
}
