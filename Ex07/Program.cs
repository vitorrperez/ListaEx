using System;
using Ex07.MODELS;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado1 = new Empregado("João", "Analista de Sistemas", 5400.00);
            

            Console.WriteLine($"O funcionário {empregado1.Nome}, possui o cargo de {empregado1.Funcao}, com o salario de {empregado1.Salario}\n"+
                $"Agora passará a ganhar {empregado1.AumentarSalario(600.00)}");
        }
    }
}
