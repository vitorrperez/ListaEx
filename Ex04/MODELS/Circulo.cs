using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.MODELS
{
    class Circulo
    {
        public double CalcularArea(double raio)
        {
            double area = 3.14 * Math.Pow(raio, 2);
            return area;
        }
    }
}
