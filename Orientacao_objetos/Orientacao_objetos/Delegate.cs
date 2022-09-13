using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class Delegate
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine("A soma é " + (n1+n2));
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("A subtração é " + (n1-n2));
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("A multiplicação é " + (n1*n2));
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine("A divisao é " + (n1/n2));
        }
    }
}
