using System;
using System.Collections.Generic;
using System.Text;
using Ex05.MODELS;

namespace Ex05.MODELS
{
    class Aluno
    {
        public Disciplina Disciplina { get; set; }
        public string Nome { get; set; }

        Disciplina disciplina = new Disciplina();


        public void AtribuirNota(double n1, double n2, double n3)
        {
            

            disciplina.Nota1 = n1;
            disciplina.Nota2 = n2;
            disciplina.Nota3 = n3;
        }

        public double ObterMedia()
        {
            return disciplina.ObterMedia();
        }
    }
}
