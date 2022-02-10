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

        public double Add(double addend)
        {
            Accumulator+= addend;

            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            double result = 0;
            result = a - b;
            Accumulator = result;

            return result;  
        }

        public double Multiply(double a, double b)
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

        public double Power( double exp)
        {
            double result = 0;
            Accumulator = Math.Pow(Accumulator, exp);

            return Accumulator;
        }


        public double Accumulator { get; private set; }

        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }
        public  double Divide( double divisor)
        {
            Accumulator = Accumulator / divisor;
            return Accumulator;
        }



        public void Clear()
        {
            Accumulator=0;
        }


    }
}