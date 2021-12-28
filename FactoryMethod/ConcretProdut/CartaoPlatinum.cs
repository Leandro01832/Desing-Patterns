using FactoryMethod.Product;

namespace FactoryMethod.ConcretProdut
{
    public class CartaoPlatinum : CartaoCredito
    {
        private readonly string tipoCartao;
        private int limiteCredito;
        private int cobrancaAnual;

        public CartaoPlatinum(int LimiteCredito, int CobrancaAnual)
        {
            this.tipoCartao = "Platinum";
            this.limiteCredito = LimiteCredito;
            this.cobrancaAnual = CobrancaAnual;
        }

        public override string TipoCArtao
        { get { return tipoCartao; } }
        public override int LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }
        public override int CobrancaAnual
        {
            get { return cobrancaAnual; }
            set { cobrancaAnual = value; }
        }
    }
}
