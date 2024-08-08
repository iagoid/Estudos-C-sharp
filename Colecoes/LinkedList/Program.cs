using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Carro");
            list.AddFirst("Avião");
            list.AddFirst("Navio");
            list.AddFirst("Motocicleta");

            list.AddLast("Bicicleta");

            list.AddAfter(list.Find("Avião"), "Helicoptero");

            list.AddBefore(list.FindLast("Avião"), "Teco-Teco");

            list.Remove("Bicicleta");
            list.RemoveFirst();
            list.RemoveLast();
            list.Reverse();


            foreach (string t in list)
            {
                Console.WriteLine(t);
            }


        }
    }
}
