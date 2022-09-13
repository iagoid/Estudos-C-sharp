using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{

    internal class Sobrecarga
    {
        public void MetodoComSobrecarga(string texto1)
        {
            Console.WriteLine(texto1);
        }

        public void MetodoComSobrecarga(int texto1)
        {
            Console.WriteLine(texto1);
        }

        public void MetodoComSobrecarga(string texto1, string texto2)
        {
            Console.WriteLine(texto1 + " " + texto2);
        }
    }
}
