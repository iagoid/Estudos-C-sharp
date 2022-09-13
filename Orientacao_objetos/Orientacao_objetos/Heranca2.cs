using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class Mamiferos
    {
        // O metodo virtual já tem uma implementação base
        // assim as classes que herdam podem modificar ele
        // ou usá-lo
        // *O metodo virtual não precisa ter a classe com abstract
        public virtual void Ambiente()
        {
            Console.WriteLine("Sem ambiente definido");
        }
        
        public virtual void Curiosidade()
        {
            Console.WriteLine("Sem curisidade");
        }
    }

    class CanisLupusFamiliaris : Mamiferos {

        // Sealed impede que o metodo seja sobreescrito por
        // outras classes que herdam essa
        public sealed override void Ambiente()
        {
            Console.WriteLine("Ambiente doméstico");
        }
    }

    class CachorroCaramelo : CanisLupusFamiliaris
    {
        public override void Curiosidade()
        {
            Console.WriteLine("Melhor cachorro do BRASIL!!!");
        }

        //public override void Ambiente()
        //{
        //    Console.WriteLine("Ambiente doméstico e ruas do Brasil");
        //}
    }
    
    class Shitzu : CanisLupusFamiliaris
    {
    }
    
}
