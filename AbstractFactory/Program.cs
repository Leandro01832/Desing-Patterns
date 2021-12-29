using AbstractFactory.ConcretesFactory;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            ITelemovel nokiaTelemovel = new Nokia();
            TelemovelClient nokia = new TelemovelClient(nokiaTelemovel);
            Console.WriteLine("********************** Nokia **************************");
            Console.WriteLine(nokia.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(nokia.BuscarNormalPhoneModeloDetalhes());

            ITelemovel samsungTelemovel = new Samsung();
            TelemovelClient samsung = new TelemovelClient(samsungTelemovel);
            Console.WriteLine("********************** Samsung **************************");
            Console.WriteLine(samsung.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(samsung.BuscarNormalPhoneModeloDetalhes());

            Console.Read();
        }
    }
}
