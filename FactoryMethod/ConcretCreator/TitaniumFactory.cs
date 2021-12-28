using FactoryMethod.ConcretProdut;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.ConcretCreator
{
    class TitaniumFactory : CartaoFactory
    {
        private int limiteCredito;
        private int cobrancaAnual;

        public TitaniumFactory(int LimiteCredito, int CobrancaAnual)
        {
            this.limiteCredito = LimiteCredito;
            this.cobrancaAnual = CobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoTitanium(limiteCredito, cobrancaAnual);
        }
    }
}
