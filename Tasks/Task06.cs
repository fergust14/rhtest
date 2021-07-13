using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task06
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers) 
        {
            var result = new List<decimal>();

            int positivos = 0;
            int negativos = 0;
            int zeros = 0;
            int tamanhoLista = numbers.Count;

            foreach (int number in numbers)
            {
                if (number == 0)
                {
                    zeros += 1;
                }
                else if (number > 0)
                {
                    positivos += 1;
                }
                else
                {
                    negativos += 1;
                }
            }
            decimal ratioPositivos = (decimal)positivos / (decimal)tamanhoLista;
            decimal ratioNegativos = (decimal)negativos / (decimal)tamanhoLista;
            decimal ratioZeros = (decimal)zeros / (decimal)tamanhoLista;

            result.Add(Math.Round(ratioPositivos, 6));
            result.Add(Math.Round(ratioNegativos, 6));
            result.Add(Math.Round(ratioZeros, 6));

            return result;
        }
    }
}
