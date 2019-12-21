using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPFundamentals.Util
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
        public double Power(double x, double y)
        {
            double total = 1;
            for (int i = 1; i <= y; i++)
            {
                total *= x;
            }
            return total;
        }
    }
}
