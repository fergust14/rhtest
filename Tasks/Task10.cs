namespace Tasks
{
    public class Task10
    {
        /*
        * A tarefa é depurar o código existente para executar com êxito todos os testes.
        *
        * Dadas duas datas cada no formato 'dd-mm-aaaa' , você deve encontrar o número de datas da sorte entre elas (inclusive).
        * Para ver se é uma data da sorte, em primeiro lugar, concatene sequencialmente a data, mês e ano em um novo número inteiro apagando os zeros à esquerda.
        * Agora se é divisível por 4 ou 7, então chamamos a data de data de sorte.
        * 
        * Por exemplo, vamos pegar a data "02-08-2024". Depois de concatenar o dia, mês e ano, obtemos 2082024. como é divisível por 4 portanto, a data "02-08-2024" é chamada de data de sorte.
        *
        * Depure a função fornecida findLuckDates para encontrar as datas de sorte corretas a partir da entrada fornecida.
        *
        * Nota: Você deve modificar ao minimo o código fornecido e não pode adicionar ou remover linhas do código.
        * 
        * Dica de como depurar: 
        *  - selecione uma linha e use F9 para ligar/desligar um "pondo de parada" no codigo.
        *  - no menu "Test" selecione "Debug All Tests" ou use o atalho (ctrl+R, ctrl+A)
        *  - use F11 para ir andando linha a linha.
        *  - colocando seu mouse sobre uma variavel é possivel ver se conteudo atual.
        */

        public static int getLuckDates(string date1, string date2)
        {
            string[] strdate1 = date1.Split('-');
            string[] strdate2 = date2.Split('-');
            int d1 = int.Parse(strdate1[0]);
            int m1 = int.Parse(strdate1[1]);
            int y1 = int.Parse(strdate1[2]);
            int d2 = int.Parse(strdate2[0]);
            int m2 = int.Parse(strdate2[1]);
            int y2 = int.Parse(strdate2[2]);
            return findLuckDates(d1, m1, y1, d2, m2, y2);
        }

        private static int findLuckDates(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int[] month;
            int result = 0;
            while (true)
            {
                int x = d1;
                x = x * 100 + m1;
                x = x * 10000 + y1;
                if (x % 4 == 0 || x % 7 == 0)
                {
                    result = result + 1;
                }
                if (d1 == d2 && m1 == m2 && y1 == y2)
                {
                    break;
                }
                d1 = d1 + 1;
                month = Month(y1);
                if (d1 > month[m1])
                {
                    m1 = m1 + 1;
                    d1 = 1;
                    if (m1 > 12)
                    {
                        y1 = y1 + 1;
                        m1 = 1;
                    }
                }
            }
            return result;
        }

        private static int[] Month(int year)
        {
            int[] month = new int[15];
            month[1] = 31;
            month[2] = 28;
            month[3] = 31;
            month[4] = 30;
            month[5] = 31;
            month[6] = 30;
            month[7] = 31;
            month[8] = 31;
            month[9] = 30;
            month[10] = 31;
            month[11] = 30;
            month[12] = 31;
            if (year % 400 == 0)
                month[2] = 28;
            else if (year % 100 == 0)
                month[2] = 29;
            else if (year % 4 == 0)
                month[2] = 29;
            else
                month[2] = 28;
            return month;
        }
    }
}
