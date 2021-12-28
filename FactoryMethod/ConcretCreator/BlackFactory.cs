using FactoryMethod.ConcretProdut;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.ConcretCreator
{
    class BlackFactory : CartaoFactory
    {
        private int limiteCredito;
        private int cobrancaAnual;

        public BlackFactory(int LimiteCredito, int CobrancaAnual)
        {
            this.limiteCredito = LimiteCredito;
            this.cobrancaAnual = CobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoBlack(limiteCredito, cobrancaAnual);
        }
    }
}
