using System;
using Ex05.MODELS;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();


            Console.WriteLine("Digite o nome do aluno");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite a 1ª nota");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2ª nota");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3ª nota");
            double n3 = double.Parse(Console.ReadLine());

            aluno.AtribuirNota(n1, n2, n3);

            Console.WriteLine($"O aluno {aluno.Nome}, obteve a média {aluno.ObterMedia()}");

        }
    }
}
