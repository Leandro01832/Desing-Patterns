using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Pizza : IPizza
    {

        public string BuscarTipoPizza()
        {
            var pizza = "Esta é uma pizza normal";

            return pizza;
        }
    }
}
