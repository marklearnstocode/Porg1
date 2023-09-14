using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_lommeregner
{
    internal class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }

        public double Divide(int x, int y)
        {
            double No1 = x;
            double No2 = y;
            return No1 / No2;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
