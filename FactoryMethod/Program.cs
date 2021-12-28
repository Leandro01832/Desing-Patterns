using FactoryMethod.ConcretCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;

            Console.Write("Digite o tipo de cartão que gostaria de obter:");
            string console = Console.ReadLine();

            switch (console.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "titanium":
                    cartaoFactory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    cartaoFactory = new PlatinumFactory(500000, 1000);
                    break;

                default:
                    break;
            }

            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
            Console.WriteLine("Os detalhes do seu cartão estão abaixo: \n");
            Console.WriteLine("Tipo de cartão: {0}\n Credito limite {1} \n Cobrança anual {2}",
                cartaoCredito.TipoCArtao, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);
            
            Console.ReadKey();
            Console.Read();
        }
    }
}
