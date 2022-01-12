using System;
using System.Collections.Generic;
using System.Text;

namespace Ex07.MODELS
{
    class Empregado
    {
        public string Nome { get; set; }

        public string Funcao { get; set; }

        public double Salario { get; set; }

        public Empregado (string nome, string funcao, double salario)
        {
            Nome = nome;
            Funcao = funcao;
            Salario = salario;
        }

        public double AumentarSalario(double aumento)
        {
            double salarioAumentado = Salario + aumento;
            return salarioAumentado;
        }
    
    }
}
