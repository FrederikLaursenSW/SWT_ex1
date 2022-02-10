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

        [TestCase(13,22,35)]
        [TestCase(2, 3, 5)]
        [TestCase(7, 11, 18)]
        public void positiveNumbers(int a, int b, int c)
        {

            //act
            double res = testCalc.Add(a, b);


            //Assert
            Assert.That(res, Is.EqualTo(c));

        }

        [TestCase(-3, -5, -8)]
        [TestCase(-10, -5, -15)]
        [TestCase(-7, -10, -17)]

        public void negativeNumbers(int a, int b, int c)
        {
            //act
            double res = testCalc.Add(a, b);

            //Assert
            Assert.That(res, Is.EqualTo(c));

        }

        [TestCase(5, 7, 12)]
        [TestCase(12, 10, 22)]
        [TestCase(-5, 10, 5)]
        public void addToResult(int a, int b, int c)
        {
            //act
            double res1 = testCalc.Add(a);

            double res2 = testCalc.Add(b);

            //Assert
            Assert.That(testCalc.Accumulator, Is.EqualTo(c));

        }

    }
}