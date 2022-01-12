using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02.MODELS
{
    class Salario
    {
        public double valorBruto { get; set; }


        public double CalcularINSS()
        {
            double descontoINSS = (valorBruto * 20) / 100;
            return descontoINSS;
        }

        public double ObterValorLiquido()
        {
            double salaarioLiquido = valorBruto - CalcularINSS();
            return salaarioLiquido;
        }

    }
}
