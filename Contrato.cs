using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    public class Contrato
    {
        public Guid IdContrato { get; set; } = Guid.NewGuid();
        public string Contratante { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }
        protected virtual decimal calcularPrestacao(decimal Valor , int Prazo)
        {
            return (Valor / Prazo);
        }
        protected virtual void exibirInfo()
        {
            Console.Clear();
            Console.WriteLine($"Dados do contrato: " +
                $"- Valor: R$ {Valor}" +
                $"- Prazo: {Prazo}" +
                $"- Valor da Prestação: R$ {calcularPrestacao}");
        }
    }
}