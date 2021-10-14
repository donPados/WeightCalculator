using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;


namespace CalculatorLibrary2
{
    public class Calculator
    {
        //public Calculator()
        public static double DiameterCalculate(double Diam, double DiamLeng)
        {
            double Result = double.NaN;
            Result= Diam + DiamLeng;
            
            Result = Diam * Diam * 3.14 / 4 * DiamLeng;
            return Result;
        }
        public static double HexaCalculate()
        {
            //hossz*(3/2*GYÖK(3)*(laptáv*laptáv/3))
        }

        public static double PipeCalculate()
        {
            //=((NagyD*NagyD*3.14/4)-((NagyD-2*kisd)*(NagyD-2*kisd)*3.14/4))*NagyD
        }
        
        
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        public void Finish()
        {
        }
    }
}
