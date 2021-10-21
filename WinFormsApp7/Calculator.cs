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
        /// <summary>
        /// Calculating Diameter volume
        /// </summary>
        public static double DiameterCalculate(double Diam, double DiamLeng)
        {
            double Result = double.NaN;
            Result= Diam + DiamLeng;
            
            Result = Diam * Diam * 3.14 / 4 * DiamLeng;
            return Result;
        }
        /// <summary>
        /// Calculate Hexagon volume
        /// </summary>
        /// <param name="SW"></param>
        /// <param name="SWLength"></param>
        /// <returns></returns>
        public static double HexaCalculate(double SW, double SWLength)
        {
            //hossz*(3/2*GYÖK(3)*(laptáv*laptáv/3))
            double Result = double.NaN;
            Result = SWLength * (3 / 2 * Math.Sqrt(3)) * (SWLength * SWLength / 3);
            return Result;
        }
        /// <summary>
        /// Calculating Pipe volume
        /// </summary>
        /// <param name="OutDiam"></param>
        /// <param name="Wall"></param>
        /// <param name="PipeLength"></param>
        /// <returns></returns>
        public static double PipeCalculate(double OutDiam, double Wall, double PipeLength)
        {
            //=((NagyD*NagyD*3.14/4)-((NagyD-2*kisd)*(NagyD-2*kisd)*3.14/4))*NagyD
            double InDiam = OutDiam - 2 * Wall;
            double Result = double.NaN;
            Result=((OutDiam*OutDiam*3.14/4)-((OutDiam-2*InDiam)*(OutDiam-2*InDiam)*3.14/4))*OutDiam;
            return Result;
        }

        public void Finish()
        {
        }
    }
}
