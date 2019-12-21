using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.Patterns
{
    public abstract class MathCommand
    {
        public abstract double calculate(double x, double y);

    }
    public class AddCommand : MathCommand
    {
        public override double calculate(double x, double y)
        {
            return x + y;
        }


    }
    public class SubCommand : MathCommand
    {
        public override double calculate(double x, double y)
        {
            return x - y;
        }
    }
    public class MulCommand : MathCommand
    {
        public override double calculate(double x, double y)
        {
            return x * y;
        }
    }
    public class DivCommand : MathCommand
    {
        public override double calculate(double x, double y)
        {
            return x / y;
        }
        public class PowerCommand : MathCommand
        {
            public override double calculate(double x, double y)
            {
                double total = 1;
                for (int i = 1; i <= y; i++)
                {
                    total *= x;
                }
                return total;
            }

        }
        public class MathCommandFactory
        {
            public static MathCommand Get(int param)
            {
                if (param == 1)
                {
                    return new AddCommand();
                }
                else if (param == 2)
                {
                    return new SubCommand();
                }
                else if (param == 3)
                {
                    return new MulCommand();
                }
                else if (param == 4)
                {
                    return new DivCommand();
                }
                else if (param == 5)
                {
                    return new PowerCommand();
                }
                return null;
            }
        }
    }
}
