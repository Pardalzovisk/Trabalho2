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
            if (idade < anosContribuicao)
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
