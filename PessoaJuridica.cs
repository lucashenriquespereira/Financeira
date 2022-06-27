using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    internal class ContratoPessoaJuridica : Contrato
    {
        private string CNPJ { get; set; }
        private string InscricaoEstadual { get; set; }
        protected override decimal CalcularPrestacao(decimal Valor, int Prazo)
        {
            return base.CalcularPrestacao(Valor, Prazo) + 3;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
        }
        public override void NovoContrato()
        {
            base.NovoContrato();
            Console.WriteLine("Numero do CNPJ, por favor");
            CNPJ = Console.ReadLine();
            Console.WriteLine("Numero da sua Inscrição Estadual, por favor");
            InscricaoEstadual = Console.ReadLine();
        }
    }
}
