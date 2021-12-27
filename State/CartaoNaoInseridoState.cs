using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class CartaoNaoInseridoState : ICaixaEletronicoState
    {
        public void EjetarCartao()
        {
            Console.WriteLine("Não é possivel ejetar o cartão. O cartão não foi inserido.");
        }

        public void InformarSenha()
        {
            Console.WriteLine("Não é possivel informar a senha. Insira o cartão.");
        }

        public void InserirCartao()
        {
            Console.WriteLine("Cartão inserido com sucesso.");
        }

        public void SacarDinheiro()
        {
            Console.WriteLine("Não é possível realizar o saque. Insira o cartão.");
        }
    }
}
