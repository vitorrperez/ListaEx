using System;
using System.Collections.Generic;
using System.Text;

namespace Ex08.MODELS
{
    class TrianguloRetangulo
    {
        public double Cateto1 { get; set; }
        public double Cateto2 { get; set; }


        public TrianguloRetangulo(double cateto1, double cateto2)
        {
            Cateto1 = cateto1;
            Cateto2 = cateto2;
        }

        public double CalcularHipotenusa()
        {
            double hipotenusa = 0;
            hipotenusa = Math.Pow(hipotenusa, 2) + Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2);

            hipotenusa = Math.Sqrt(hipotenusa);

            return hipotenusa;
        }
    }
}
