using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            EstacaoMeteorologica estacaoMeteorologica = new EstacaoMeteorologica();
            NovasAgenciasNoticias agenciasNoticias1 = new NovasAgenciasNoticias("Agência de noticia de São Paulo");
            estacaoMeteorologica.Anexar(agenciasNoticias1);
            NovasAgenciasNoticias agenciasNoticias2 = new NovasAgenciasNoticias("Agência de noticia de Suzano");
            estacaoMeteorologica.Anexar(agenciasNoticias2);

            estacaoMeteorologica.Temperatura = 31.6f;
            estacaoMeteorologica.Temperatura = 41.4f;
            estacaoMeteorologica.Temperatura = 37.9f;
            estacaoMeteorologica.Temperatura = 28.2f;
            estacaoMeteorologica.Temperatura = 35.4f;
            estacaoMeteorologica.Temperatura = 40.7f;
            estacaoMeteorologica.Temperatura = 31.5f;

            Console.Read();
        }
    }
}
