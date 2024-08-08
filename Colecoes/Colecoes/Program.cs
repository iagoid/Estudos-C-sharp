using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Iago");
            dic.Add(20, "Pedro");
            dic.Add(37, "Lucas");

            Console.WriteLine(dic.First());
            
            dic[2] = "Claudio";


            if (dic.ContainsKey(1))
            {
                Console.WriteLine($"Chave esta na coleção com o valor {dic.First(d => d.Key == 1).Value}");
            }

            if (dic.ContainsValue("Lucas"))
            {
                Console.WriteLine($"O valor esta na coleção na posicao {dic.First(d => d.Value == "Lucas").Key}");
            }

            dic.Remove(37);

            foreach (KeyValuePair<int, string> d in dic)
            {
                Console.WriteLine($"{d.Key} - {d.Value}");
            }

            dic.Clear();
        }
    }
}
