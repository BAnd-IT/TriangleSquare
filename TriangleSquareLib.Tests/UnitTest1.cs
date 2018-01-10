using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleSquareLib.Tests
{
    [TestClass]
    public class TriangleSquareTests
    {
        [TestMethod]
        public void Calc_3_4_5_return_6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            TriangleSquare x = new TriangleSquare();
            double actual = x.SquareCalc(a,b,c);

            Assert.AreEqual(expected, actual, "Triangle square should have been {0}", expected);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException), "Exception \"zero value\" not thrown!")]
        [TestMethod]
        public void ZeroValueCheck_ExceptionThrown()
        {
            double A = 3;
            double B = 4;
            double C = 5;

            TriangleSquare x = new TriangleSquare();
            x.SquareCalc(A, B, 0);
            TriangleSquare y = new TriangleSquare();
            y.SquareCalc(A, 0, C);
            TriangleSquare z = new TriangleSquare();
            z.SquareCalc(0, B, C);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException), "Exception \"inequality\" not thrown!")]
        [TestMethod]
        public void TriangleInequalityCheck_ExceptionThrown()
        {
            TriangleSquare x = new TriangleSquare();
            x.SquareCalc(2, 3, 6);
        }
    }
}
