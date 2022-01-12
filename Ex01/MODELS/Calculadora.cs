using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01.MODELS
{
    class Calculadora
    {

        public double num1 { get; set; }
        public double num2 { get; set; }

        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

    }
}
