using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDelegate
{
    delegate int Op(int n1, int n2);

    class Math
    {
        
        public static int Soma(int d1, int d2)
        {
            return d1 + d2;
        }

        public static int Multiplicacao(int d1, int d2)
        {
            return d1 * d2;
        }

    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            int res;

            Op d1 = new Op(Math.Soma);
            Console.WriteLine(d1(5, 5));

            d1 = Math.Multiplicacao;
            Console.WriteLine(d1(5, 5));
        }
    }
}
