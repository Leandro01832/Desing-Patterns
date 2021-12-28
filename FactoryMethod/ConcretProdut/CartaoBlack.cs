using FactoryMethod.Product;

namespace FactoryMethod.ConcretProdut
{
    public class CartaoBlack : CartaoCredito
    {
        private readonly string tipoCartao;
        private int limiteCredito;
        private int cobrancaAnual;

        public CartaoBlack(int LimiteCredito, int CobrancaAnual)
        {
            this.tipoCartao = "Black";
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
