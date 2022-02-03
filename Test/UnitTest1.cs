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

        [Test]
        public void positiveNumbers()
        {



            //act
            double res = testCalc.Add(22, 13);


            //Assert
            Assert.That(res, Is.EqualTo(35));



        }
    }
}