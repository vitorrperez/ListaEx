using System;
using Ex01.MODELS;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º numero");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º numero");
            double n2 = double.Parse(Console.ReadLine());


            Calculadora calc = new Calculadora();


             double resultadoSoma =  calc.Soma(n1, n2);
            double resultadoSub = calc.Subtrair(n1, n2);

            Console.WriteLine($"O resultado da soma é {resultadoSoma}");
            Console.WriteLine($"O resultado da subtração é {resultadoSub}");


        }
    }
}
