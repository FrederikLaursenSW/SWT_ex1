using System;


namespace SWtest_calculator_EX
{

    public class Calc
    {
     

        public Calc()
        {
        }

        public double Add(double a, double b)
        {
            double result = 0;
            result = a + b;

            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = 0;
            result = a - b;
            Accumulator = result;

            return result;
        }

        public double Multipli(double a, double b)
        { 
            double result = 0;
            result = a * b;

            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            double result = 0;
            result = Math.Pow(x, exp);

            Accumulator = result;
            return result;
        }


        public double Accumulator { get; private set; }

        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        public void Clear()
        {
            Accumulator=0;
        }


    }
}