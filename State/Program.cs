using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Console.WriteLine("O estado atual interno do caixa eletronico é: " +
                    caixaEletronico.caixaEletronicoState.GetType().Name);

            Console.WriteLine();

            caixaEletronico.InformarSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.EjetarCartao();
            caixaEletronico.InserirCartao();

            Console.WriteLine("O estado atual interno do caixa eletronico é: " +
                    caixaEletronico.caixaEletronicoState.GetType().Name);

            Console.WriteLine();

            caixaEletronico.InformarSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.InserirCartao();
            caixaEletronico.EjetarCartao();

            Console.WriteLine("O estado atual interno do caixa eletronico é: " +
                    caixaEletronico.caixaEletronicoState.GetType().Name);

            Console.WriteLine();
            Console.Read();
        }
    }
}
