using System;
using Ex02.MODELS;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();   
            Console.WriteLine("Diite o salario do empregado");
            salario.valorBruto = double.Parse(Console.ReadLine());


            Console.WriteLine($"O salário bruto é de {salario.valorBruto}\n");
            Console.WriteLine($"O desconto do INSS é: {salario.CalcularINSS()}\n");
            Console.WriteLine($"O valor ligquido a receber é {salario.ObterValorLiquido()}");


        }
    }
}
