using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator
{
    public class Mathematics
    {
        //public double A { get; set; }
        //public double B { get; set; }


        //plus Metode plusser 2 Doubles
        public double plus(double a, double b)
        {
            double sum;
            sum = a + b;
            return sum;
        }

        //Minus - Minusser 2 doubles
        public double Minus(double a, double b)
        {
            double sum;
            sum = a - b;
            return sum;
        }

        //Gange - Ganger 2 Doubles
        public double Multi(double a, double b)
        {
            double sum;
            sum = a * b;
            return sum;
        }

        //Divider - Dividere 2 doubles
        public double Divide(double a, double b)
        {
            double sum;
            sum = a / b;
            return sum;
        }

        //^2 - Ganger en double med sig selv
        public double iAnden(double a)
        {
            double sum;
            sum = a * a;
            return sum;
        }
    }
}
