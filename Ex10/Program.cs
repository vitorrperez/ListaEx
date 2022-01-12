using System;
using Ex10.MODELS;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            var lampada1 = new Lampada();
            var lampada3 = new Lampada("branca");
            var lampada2 = new Lampada("azul", true);

            lampada1.Cor = "Verde";
            lampada1.EstaAcesa = true;

            Console.WriteLine($" 1º construtor {lampada1.Cor}///{lampada1.EstaAcesa} \n 2º Construtor {lampada2.Cor}\n 3ºConstrutor" +
                $"+ {lampada3.Cor}////{lampada3.EstaAcesa}");

            
        }
    }
}
