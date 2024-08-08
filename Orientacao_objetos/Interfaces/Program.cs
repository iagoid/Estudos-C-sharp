using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }

    public interface Combate {
        void disparar();
    }

    class Carro:Veiculo, Combate
    {
        public void ligar()
        {
            Console.WriteLine("Ligando carro");
        }

        public void desligar()
        {
            Console.WriteLine("Desligando carro");
        }

        public void info()
        {
            Console.WriteLine("Este é meu carro");
        }

        public void disparar()
        {
            Console.WriteLine("DISPARANDO PROJÉTIL");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            
            carro.info();
            carro.ligar();
            carro.disparar();
            carro.desligar();
        }
    }
}
