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
        protected virtual decimal CalcularPrestacao(decimal Valor , int Prazo)
        {
            return (Valor / Prazo);
        }
        public virtual void ExibirInfo()
        {
            Console.Clear();
            Console.WriteLine($"Dados do contrato: " +
                $"- Valor: R$ {Valor}" +
                $"- Prazo: {Prazo}" +
                $"- Valor da Prestação: R$ {CalcularPrestacao(Valor,Prazo)}");
        }
        public virtual void NovoContrato()
        {
            do
            {
                Console.WriteLine("Qual o seu nome?");
                Contratante = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Contratante));
            Console.WriteLine("Qual o valor do Contrato?");
            Valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Qual o prazo do contrato?");
            Prazo = int.Parse(Console.ReadLine());
        }
    }
}