using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class EstruturasCondicionais
    {
        public static void Condicoes()
        {
            #region Estruturas Condicionais, Operador Ternario e Switch
            int numeroInt = 0;

            if (0 == 1)
            {
            }
            else if (1 != 2)
            {
            }
            else
            {
            }


            string frase = 1 > 0 ? "Condição Verdadeira" : "Condição Falsa";
            Console.WriteLine(frase);

            numeroInt = 0 | 4;
            switch (numeroInt)
            {
                case 0:
                    break;
                case 1 | 2:
                    Console.WriteLine("1 ou 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("4 ou 5");
                    break;
                default:
                    Console.WriteLine("Opção defaulr");
                    break;
            }
            #endregion
        }
    }
}
