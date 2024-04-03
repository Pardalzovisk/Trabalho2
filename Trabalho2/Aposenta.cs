using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Trabalho2
{
    public class Aposenta
    {
        public bool PodeSeAposentar(int idade, int anosContribuicao)
        {
            int diferencaIdade = idade - anosContribuicao;
            //Band-aid para verificar anos contribuidos maiores do que a idade
            if (idade < anosContribuicao || diferencaIdade < 16)
            {
                return false;
            }
            else if (idade >= 65 || anosContribuicao >= 30 || (idade >= 60 && anosContribuicao >= 25))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
