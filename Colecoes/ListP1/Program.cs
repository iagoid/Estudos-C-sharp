using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();

            list.Add("Golf");
            list.Add("HRV");
            list.Add("Focus");
            list.Add("Argo");
            list.Add("HRV");

            list.Insert(1, "Cruze");

            list2.AddRange(list); // Adiciona uma lista de items

            if (list.Contains("Golf")) {
                Console.WriteLine($"Golf está na lista");
            }

            string[] carros = new string[10];
            list.CopyTo(carros, 2); // Copiar para o array


            int pos = list.IndexOf("HRV");
            Console.WriteLine($"Carro HRV na posicao {pos}"); // Posicao do item

            list.Remove("HRV");
            list.RemoveAt(1);
            
            list.Sort(); // Ordena a lista
            list.Reverse(); // Inverte Lista

            list.Capacity = 10; // Define a capacidade de items que a lista pode ter

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.Clear();
        }
    }
}
