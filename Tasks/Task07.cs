using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task07
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock() 
        {
            var result = new List<string>();
            var repositorio = new Repository();
            foreach (Product produto in repositorio.Products)
            {
                if (produto.Stock.Quantity == 0)
                {
                    result.Add(produto.Name);
                }
            }
            return result;
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock() 
        {
            int result = 0;
            var repositorio = new Repository();
            foreach (Product produto in repositorio.Products)
            {
                result += produto.Stock.Quantity;
            }

            return result;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity) 
        {
            var repositorio = new Repository();
            var produtoSelecionado = repositorio.Products.Find(x => x.Id == productId);

            if (produtoSelecionado.Stock.Quantity >= orderQuantity)
            {
                bool result = true;
                return result;
            }
            else
            {
                bool result = false;
                return result;
            }
        }
    }
}
