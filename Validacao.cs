using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Financeira
{
    internal class Validacao
    {
        public static bool ValidaSimNao(string resposta)
        {
            resposta = resposta.ToLower();
            if (!RegexSim(resposta) && !RegexNao(resposta))
                return false;
            else
                return true;
        }
        public static bool SimNaoValido(string resposta)
        {
            resposta = resposta.ToLower();
            if (RegexSim(resposta))
                return true;
            else
                return false;
        }
        public static bool RegexSim(string resposta) //System.Text.RegularExpressions.Regex
        {
            return new Regex(@"^((s)|(sim)){1}$").Match(resposta).Success;
        }
        public static bool RegexNao(string resposta) //System.Text.RegularExpressions.Regex
        {
            return new Regex(@"^((n)|(nao)|(não)){1}$").Match(resposta).Success;
        }
        public static bool ValidaPFPJ(string resposta)
        {
            resposta = resposta.ToLower();
            if (!RegexPF(resposta) && !RegexPJ(resposta))
                return false;
            else
                return true;
        }
        public static bool PFPJValido(string resposta)
        {
            resposta = resposta.ToLower();
            if (RegexPF(resposta))
                return true;
            else
                return false;
        }
        public static bool RegexPF(string resposta)
        {
            return new Regex(@"^((pf)|(p f)|(pessoafisica)|(pessoafísica)|(pessoa fisica)|(pessoa física)){1}$").Match(resposta).Success;
        }
        public static bool RegexPJ(string resposta)
        { 
            return new Regex(@"^((pj)|(p j)|(pessoajuridica)|(pessoajurídica)|(pessoa juridica)|(pessoa jurídica)){1}$").Match(resposta).Success;
        }
    }
}
