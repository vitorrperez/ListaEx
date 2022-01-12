using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06.MODELS
{
    class Livro
    {
        public string Isbn { get; set; }
        public string TituloOriginal { get; set; }
        public string TituloPortugues { get; set; }
        public string Autor { get; set; }
        public int QuantidadePaginas { get; set; }
        public string Edicao { get; set; }
        public string DataDePublicacao { get; set; }

        public void RetonarTitulos()
        {
            Console.WriteLine($"O Titulo original é {TituloOriginal}\n O título em portugues é {TituloPortugues}");
        }
    }
}
