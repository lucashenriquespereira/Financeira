using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    internal class ContratoPessoaFisica : Contrato
    {
        private string CPF { get; set; }
        private DateTime DataDeNascimento { get; set; }
        internal int Idade()
        {
            int idade = DateTime.Now.Year - DataDeNascimento.Year;
            if (DateTime.Now.Month < DataDeNascimento.Month)
                idade -= 1;
            else if (DateTime.Now.Month == DataDeNascimento.Month && DateTime.Now.Day < DataDeNascimento.Day)
                idade -= 1;
            return idade;
        }
        protected virtual decimal CalcularPrestacao(decimal Valor, int Prazo)
        {
            switch (Idade())
            {
                case <= 30:
                    return CalcularPrestacao(Valor,Prazo) + 1;
                case <= 40:
                    return CalcularPrestacao(Valor, Prazo) + 2;
                case <= 50:
                    return CalcularPrestacao(Valor, Prazo) + 3;
                default:
                    return CalcularPrestacao(Valor, Prazo) + 4;
            }
        }
        protected override void exibirInfo()
        {
            exibirInfo();
            Console.WriteLine($"O contratante tem {Idade} anos");
        }
    }
}
