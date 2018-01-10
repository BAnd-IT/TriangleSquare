using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSquareLib
{
    public class TriangleSquare
    {
        public double SquareCalc(double A, double B, double C) {

            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new ArgumentOutOfRangeException("Value must to be more than 0");
            }

            if (A + B <= C || B + C <= A || A + C <= B)
            {
                throw new ArgumentOutOfRangeException("Triangle inequality");
            }

            //calculating
            double p = (A + B + C)/2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
    }
}
