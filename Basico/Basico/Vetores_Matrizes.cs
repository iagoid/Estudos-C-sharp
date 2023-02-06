using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class Vetores_Matrizes
    {

        public static void VetoresMatrizes()
        {
            #region Vetores e Matrizes
            int[] vetor = new int[3];
            int[] vetor2 = { 11, 22, 33 };
            vetor[0] = 10;
            vetor[1] = 20;
            vetor[2] = 30;

            foreach (int i in vetor)
            {
                Console.WriteLine(i);
            }

            // MATRIZ
            int[,] matriz = new int[2, 3];
            int[,] matriz2 = {  {00, 01, 02 },
                                {10, 11, 12 },
                                {20, 21, 22 },
            };
            Console.WriteLine(matriz2[1, 1]);

            int[,,] matriz3 = {
                                {{000, 001, 002 }, {010, 011, 012 }},
                                {{100, 101, 102 }, {110, 111, 112 }},
                                {{200, 201, 202 }, {210, 211, 212 }},
            };
            Console.WriteLine(matriz3[1, 1, 1]);

            #endregion
        }

    }
}
