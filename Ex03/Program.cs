using System;
using Ex03.MODELS;
namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraFinanceira cf = new CalculadoraFinanceira();

            Console.WriteLine("Digite seu capital");
            double capital = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a taxa");
            double taxaJuros = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o periodo ");
            double periodo = double.Parse(Console.ReadLine());


            double composto = cf.CalcularJurosCompostos(capital, taxaJuros, periodo);
            double simples = cf.CalcularJurosSimples(capital, taxaJuros, periodo);

            Console.WriteLine($"juros composto {composto}");

            Console.WriteLine($"Juros simples {simples}");
        }
    }
}
