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
        protected override decimal calcularPrestacao(decimal Valor, int Prazo)
        {
            return calcularPrestacao(Valor, Prazo) + 3;
        }
        protected override void exibirInfo()
        {
            exibirInfo();
        }
    }
}
