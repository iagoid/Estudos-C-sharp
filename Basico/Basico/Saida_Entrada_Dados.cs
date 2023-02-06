using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class Saida_Entrada_Dados
    {

        public static void Dados()
        {
            #region Entrada e saida de dados
            Console.Write("Não quebra a linha");
            Console.WriteLine("Quebra a linha");

            string texto = Console.ReadLine(); //Lê a linha inteira
            Console.WriteLine(texto);

            int codigo = Console.Read(); // Lê 1 caractere(ASCII) e espera apertar a tecla ENTER
            Console.Write(codigo);

            Console.ReadKey();//Lê 1 caractere(ASCII), não espera apertar a tecla ENTER
            Console.Clear(); // Limpa o console para não pular 
            #endregion
        }
    }
}
