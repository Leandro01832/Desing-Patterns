using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Interfaces;

namespace Decorator
{
    public class CebolaDecorator : PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de cebola";

            return pizza;
        }
    }
}
