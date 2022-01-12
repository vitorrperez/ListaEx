using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10.MODELS
{
    class Lampada
    {
        public string Cor { get; set; }
        public bool EstaAcesa { get; set; }

        public Lampada()
        {

        }

        public Lampada(string cor, bool estadoLampada)
        {
            Cor = cor;
            EstaAcesa = estadoLampada;
        }

        public Lampada(string cor)
        {
            Cor = cor;
            EstaAcesa = true;
        }


    }
}
