using System;
using Ex06.MODELS;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro();
            Livro livro2 = new Livro();

            Console.WriteLine("Olá usuário digite os dados do seu livro\n\n");

            Console.WriteLine("Titulo Original");
            livro1.TituloOriginal = Console.ReadLine();

            Console.WriteLine("Titulo em Portugues");
            livro1.TituloPortugues = Console.ReadLine();

            Console.WriteLine("Autor");
            livro1.Autor = Console.ReadLine();

            Console.WriteLine("Quantidade de paginas");
            livro1.QuantidadePaginas = int.Parse(Console.ReadLine());



            Console.WriteLine("Olá usuário digite os dados do seu 2º livro\n\n");

            Console.WriteLine("Titulo Original");
            livro2.TituloOriginal = Console.ReadLine();

            Console.WriteLine("Titulo em Portugues");
            livro2.TituloPortugues = Console.ReadLine();

            Console.WriteLine("Autor");
            livro2.Autor = Console.ReadLine();

            Console.WriteLine("Quantidade de paginas");
            livro2.QuantidadePaginas = int.Parse(Console.ReadLine());


            livro1.RetonarTitulos();
            Console.WriteLine("\n");
            livro2.RetonarTitulos();


        }
    }
}
