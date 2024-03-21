using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2
{
    public class Exercicios
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int ConverterMetrosParaMilimetros(int metros)
        {
            return metros * 1000;
        }

        public bool PodeSeAposentar(int idade, int anosContribuicao)
        {
            if (idade >= 65 || anosContribuicao >= 30 || (idade >= 60 && anosContribuicao >= 25))
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
