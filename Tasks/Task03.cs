using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task03
    {
        /*
         * Dada a lista de inteiros, retorne o somatório de todos os itens com valor POSITIVO da lista     
         * LEMBRANDO que 0 (zero) NÃO é um número positivo
         */
        public static int GetSum(List<int> list) 
        {
            int somatorio = 0;
            foreach (int numero in list)
            {
                if (numero > 0)
                {
                    somatorio += numero;
                }
            }
            return somatorio;
        }
    }
}
