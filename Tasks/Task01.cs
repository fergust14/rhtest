using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task01
    {
        /*
         * Dada a lista de inteiros, retorne o maior número da lista         
         */
        public static int? GetMax(List<int> list) 
        {
            int maiorNumero = list.Max();
            return maiorNumero;
        }
    }
}
