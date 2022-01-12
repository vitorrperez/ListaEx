using System;
using Ex04.MODELS;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad = new Quadrado();
            Circulo circ = new Circulo();

            double lado, raio;

            lado = 10;
            raio = 5;

            double areaQuadrado =  quad.CalcularArea(lado);
            double areaCirculo = circ.CalcularArea(raio);

            double valorDiferença = areaQuadrado - areaCirculo;

            Console.WriteLine($"O valor da diferença é de {valorDiferença}");


            
        }
    }
}
