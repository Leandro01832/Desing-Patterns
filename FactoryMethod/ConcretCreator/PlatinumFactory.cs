using FactoryMethod.ConcretProdut;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcretCreator
{
    class PlatinumFactory : CartaoFactory
    {
        private int limiteCredito;
        private int cobrancaAnual;

        public PlatinumFactory(int LimiteCredito, int CobrancaAnual)
        {
            this.limiteCredito = LimiteCredito;
            this.cobrancaAnual = CobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(limiteCredito, cobrancaAnual);
        }
    }
}
