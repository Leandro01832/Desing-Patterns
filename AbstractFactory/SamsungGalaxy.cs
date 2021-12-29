using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
