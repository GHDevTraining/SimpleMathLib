using System;


namespace SimpleMathLib
{
    public class MathClass
    {

        // Add two numbers together
        public int Add(int a, int b)
        {
            if (a < 1)
                return 0;
            return a + b;
        }

        // Add two doubles together
        public double Add(double a, double b)
        {
            if (a < 1)
                return 0;
            return a + b;
        }
        // Subtract two numbers
        public int Subtract(int a, int b)
        {
            if (a < 1)
                return 0;
            return (a - b);
        }

        // Multiply two numbers
        public int Multiply(int a, int b)
        {
            return (a * b);
        }

        public int Divide(int a, int b)
        {
            return (a / b);
        }

    }
}
