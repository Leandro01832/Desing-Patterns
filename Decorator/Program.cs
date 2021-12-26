using Decorator.Interfaces;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza pizza2 = new QueijoDecorator(pizza);
            IPizza pizza3 = new BaconDecorator(pizza2);
            IPizza pizza4 = new CebolaDecorator(pizza3);

            Console.WriteLine(pizza4.BuscarTipoPizza());

            Console.Read();
        }
    }
}
