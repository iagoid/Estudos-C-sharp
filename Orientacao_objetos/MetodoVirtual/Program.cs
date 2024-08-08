using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoVirtual
{

    class Base
    {
        // Metodo virtual pode ser sobreescrito
        // Em versões mais recentes não precisa declarar isso explicitamente
        virtual public void info()
        {
            Console.WriteLine("Base");
        }
    }

    class Derivada1:Base
    {
        override public void info()
        {
            Console.WriteLine("Derivada 1");
        }
    }

    class Derivada2 : Base
    {
        override public void info()
        {
            Console.WriteLine("Derivada 2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Base Ref; 

            Derivada1 d1 = new Derivada1();
            d1.info();

            Ref = d1;
            Ref.info();
            Ref = new Derivada2();
            Ref.info();
        }
    }
}


