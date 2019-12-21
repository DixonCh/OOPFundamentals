using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPFundamentals.Util;
using OOPFundamentals.Patterns;
using static OOPFundamentals.Patterns.DivCommand;

namespace OOPFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            while (true)
            {
                Console.WriteLine("Enter the value of X: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of Y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.WriteLine("5. Power");
                Console.WriteLine("Enter your choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                MathCommand cmd = MathCommandFactory.Get(ch);
                if (cmd != null)
                {
                    double result = cmd.calculate(x, y);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
                Console.WriteLine("Do you want to continue[Y/N]:");
                if (Console.ReadLine().ToUpper().Equals("N"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
