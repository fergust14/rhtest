using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tasks
{
    public class Task08
    {
        /*
         *  Dada uma lista de nomes modifique a função "getFirstCharString" para retornar a primeira letra de cada nome válido.
         *  
         *  exemplo: na lista { "André", "João", "Ana", "Giromildo", "RAUL SEIXAS" }
         *  
         *  o Retorno seria "AJAGR";
         *  
         *  Linq, operadores ternários e Expression body são preferíveis, mas não obrigatórios.
         * 
         */

        public static string getFirstCharString(List<string> listNames) 
        {
            string result = "";
            string verificar = "^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ]";
            foreach (string nome in listNames)
            {
                if (nome != null)
                {
                    if (Regex.IsMatch(nome, verificar))
                    {
                        result = result + nome.Substring(0, 1);
                    }
                }
            }
            return result;
        }
    }
}
