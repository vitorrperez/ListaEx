using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.MODELS
{
    class CalculadoraFinanceira
    {
        public double CalcularJurosSimples(double capital, double taxaJuros, double periodo)
        {
            double montante = capital * (1 + taxaJuros * periodo);
            return montante;
        }

        public double CalcularJurosCompostos(double capital, double taxaJuros, double periodo)
        {

            double montante = capital * (Math.Pow((1 + taxaJuros), periodo));
            return montante;
        }
    }
}
