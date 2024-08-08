using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratos
{
    internal class Program
    {

        // Não é possível instanciar classes abstratas
        //Todas as classes que herdam de uma classe abstrata precisam
        // implementaar o metodo abstrato
        abstract class Veiculo
        {
            protected int Velocidade { get; set; }

            public void Info()
            {
                Console.WriteLine($"Velocidade {this.Velocidade}");
            }

            // A funçao não contém conteudo quando abstrata
            abstract public void Aceleracao(int Multiplicador);
        }

        class Carro:Veiculo
        {
            override public void Aceleracao(int Multiplicador)
            {

                this.Velocidade += Multiplicador;
            }
            
        }

        static void Main(string[] args)
        {
            
            Carro c1 = new Carro();
            c1.Aceleracao(20);
            c1.Aceleracao(80);
            c1.Aceleracao(-20);
            c1.Info();
        }
    }
}
