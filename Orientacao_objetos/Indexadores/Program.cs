using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal class Program
    {

        class Carro
        {
            private int[] velMax = new int[5] { 80, 120, 150, 280, 210 };
            
            public int this[int i]
            {
                get
                {
                    return velMax[i];
                }
                set
                {
                    velMax[i] = value;
                }
            }
        
        }

        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Console.WriteLine(carro[1]);
            carro[1] = 200;
        }
    }
}
