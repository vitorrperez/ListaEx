using System;
using Ex08.MODELS;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do cateto 1");
            double cateto1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto 2");
            double cateto2 = double.Parse(Console.ReadLine());

            TrianguloRetangulo trigRet = new TrianguloRetangulo(cateto1, cateto2);

            Console.WriteLine($"O valor da hipotenusa é {trigRet.CalcularHipotenusa()}");

            
            
            
        }
    }
}
