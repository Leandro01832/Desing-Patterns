using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Product
{
   public abstract class CartaoCredito
    {
        public abstract string TipoCArtao { get; }
        public abstract int LimiteCredito { get; set; }
        public abstract int CobrancaAnual { get; set; }
    }
}
