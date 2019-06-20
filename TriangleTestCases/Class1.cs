using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment02;

namespace TriangleTestCases
{
    [TestFixture]
    public class Class1
    {
        
        [Test]
        public void TestCaseNotPossible()
        {
            //Arrange
            int s1 = 2, s2 = 3, s3 = 5;
            //Assert
            StringAssert.Contains("incorrect",TriangleSolver.Analyze(s1, s2, s3));
        }

        [Test]
        public void TestCaseEquilateral()
        {
            //Arrange
            int s1 = 3, s2 = 3, s3 = 3;
            //Assert
            StringAssert.Contains("Equilateral",TriangleSolver.Analyze(s1, s2, s3));
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void TestCaseScalene()
        {
            //Arrange
            int s1 = 4, s2 = 5, s3 = 7;
            //Assert
            StringAssert.Contains("Scalene",TriangleSolver.Analyze(s1, s2, s3));
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void TestCaseAllzero()
        {
            //Arrange
            int s1 = 0, s2 = 0, s3 = 0;
            //Assert
            StringAssert.Contains("incorrect",TriangleSolver.Analyze(s1, s2, s3));
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void TestCaseIsosceles()
        {
            //Arrange
            int s1 = 9, s2 = 9, s3 = 5;

            //Assert
            StringAssert.Contains("Isosceles",TriangleSolver.Analyze(s1, s2, s3));
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void NotPossible()
        {
            //Arrange
            int s1 = 0, s2 = -7, s3 = -6;
            //Assert
            StringAssert.Contains("invalid", TriangleSolver.Analyze(s1, s2, s3));
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void TestCaseNegativeSides()
        {
            //Arrange
            int s1 = -7, s2 = 4, s3 = 7;

            //Assert
            StringAssert.Contains("invalid", TriangleSolver.Analyze(s1, s2, s3));
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void TestCaseTwoSidesNegative()
        {
            //Arrange
            int s1 = -5, s2 = -5, s3 = 6;
            //Assert
            StringAssert.Contains("invalid", TriangleSolver.Analyze(s1, s2, s3));
            Console.WriteLine("Please check the result");
        }


    }
}
