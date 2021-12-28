using FactoryMethod.Product;

namespace FactoryMethod.ConcretProdut
{
    public class CartaoTitanium : CartaoCredito
    {
        private readonly string tipoCartao;
        private int limiteCredito;
        private int cobrancaAnual;

        public CartaoTitanium(int LimiteCredito, int CobrancaAnual)
        {
            this.tipoCartao = "Titanium";
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
