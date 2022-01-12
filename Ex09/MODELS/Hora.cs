using System;
using System.Collections.Generic;
using System.Text;

namespace Ex09.MODELS
{
    class Hora
    {
        public string Horas { get; set; }
        public string Minutos { get; set; }
        public string Segundos { get; set; }

        public Hora(string hora, string minuto, string segundo)
        {
            Horas = hora;
            Minutos = minuto;
            Segundos = segundo;
        }

        public void ObterHora()
        {
            Console.WriteLine($"{Horas}:{Minutos}:{Segundos}");
        }

    }
}
