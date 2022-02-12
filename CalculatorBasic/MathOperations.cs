using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBasic
{
    internal static class MathOperations
    {
        static private decimal a, b, c, d;

        
        public static decimal Add (decimal a, decimal b)
        {
            return a + b;
        }
        public static decimal Subtract (decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Multiplication (decimal a, decimal b)
        {
            return (a * b);
        }
        public static decimal Division (decimal a, decimal b)
        {
            return (a / b);
        }

        public static decimal Calculate(decimal a, decimal b, int mathChoice)
        {
            switch (mathChoice)
            {
                case 1:
                    return a + b;
                case 2:
                    return a - b;
                case 3:
                    return (a * b);
                case 4:
                    return (a / b);
                case 5:
                    {
                        Environment.Exit(0);
                        return 1;
                    }
                default:
                    throw new Exception("Wybrałeś złą opcję");
            }
        }

    }
}
