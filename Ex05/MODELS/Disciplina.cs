using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05.MODELS
{
    class Disciplina
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double ObterMedia()
        {
            double media = (Nota1 + Nota2 + Nota3) / 3;
            return media;
        }
    }
}
