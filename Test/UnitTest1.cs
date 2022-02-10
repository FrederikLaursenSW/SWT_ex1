using NUnit.Framework;
using SWtest_calculator_EX;

namespace test
{
    public class Tests
    {
        private Calc testCalc;

        [SetUp]
        public void Setup()
        {
            //arrange
            testCalc = new Calc();
        }

        [TestCase(4,2,2)]
        [TestCase(3,6,0.5)]
        [TestCase( -4,2,-2)]
        public void divide_twoNumbers_returnSum(int a, int b, double c)
        {
            double res = testCalc.Divide(a, b);


            Assert.That(res, Is.EqualTo(c));
        }

        [TestCase(13,22,35)]
        [TestCase(2, 3, 5)]
        [TestCase(-10, -5, -15)]
        [TestCase(-7, -10, -17)]
        public void add_twoNumbers_returnSum(int a, int b, int c)
        {

            //act
            double res = testCalc.Add(a, b);


            //Assert
            Assert.That(res, Is.EqualTo(c));

        }

        [TestCase(5, 7, 12)]
        [TestCase(12, 10, 22)]
        [TestCase(-5, 10, 5)]
        public void add_oneNumber_returnSum(int a, int b, int c)
        {
            //act
            double res1 = testCalc.Add(a);

            double res2 = testCalc.Add(b);

            //Assert
            Assert.That(testCalc.Accumulator, Is.EqualTo(c));

        }


        [TestCase(5, 5, 25)]
        [TestCase(-12, -10, 120)]
        [TestCase(-5, 10, -50)]
        public void multiply_TwoNumbers_returnResult(int a, int b, int c)
        {
            //act
          //  double res1 = Multiply(double a, double b);

          double res1 = testCalc.Multiply(a, b);

          //Assert
            Assert.That(testCalc.Accumulator, Is.EqualTo(c));

        }




    }
}