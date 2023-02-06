using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class EstruturaRepeticao
    {

        public static void Repeticao()
        {
            #region Estruturas de Repetição
            int contador = 0;
            int[] vetor = { 11, 22, 33 };

            while (contador <= 3)
            {
                Console.Write(contador);
                contador++;
            }

            do
            {
                Console.WriteLine("\nNão faz a primeira verificação");
            } while (false);


            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                if (i == j)
                {
                    break;
                }
                Console.WriteLine(i + " <--> " + j);
            }

            foreach (int i in vetor)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
