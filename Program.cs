using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira
{
    class Program
    {
        public static void Main(String[] args)
        {
            string resposta;
            do
            {
                Console.WriteLine("Gostaria de adicionar um contrato?");
                resposta = Console.ReadLine();
            } while (!Validacao.ValidaSimNao(resposta));
            if (Validacao.SimNaoValido(resposta) == true)
                NovoCadastro();
            else
                Console.WriteLine("Obrigado e volte sempre!");
            
            void NovoCadastro()
            {
                do
                {
                    Console.WriteLine("Você gostaria de adicionar um contrato de Pessoa Fisica ou de Pessoa Juridica?");
                    resposta = Console.ReadLine();
                } while (!Validacao.ValidaPFPJ(resposta));
                if (Validacao.PFPJValido(resposta) == true)
                {
                    ContratoPessoaFisica cadastrarPF = new (); 
                    cadastrarPF.NovoContrato();
                    cadastrarPF.ExibirInfo();
                }
                else
                {
                    ContratoPessoaJuridica cadastrarPJ = new();
                    cadastrarPJ.NovoContrato();
                    cadastrarPJ.ExibirInfo();
                }
            }
        }
    }
}