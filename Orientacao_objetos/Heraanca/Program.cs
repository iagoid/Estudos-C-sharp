using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heraanca
{
    internal class Program
    {
        class Veiculo
        {
            public int Rodas { get; set; }
            public int VelMaxima { get; set; }
            public bool Ligado { get; set; }
            protected string Marca {get; set; }


            public Veiculo(int rodas, int velMaxima)
            {
                Rodas = rodas;
                VelMaxima = velMaxima;
            }

            public void AlterarEstado()
            {
                this.Ligado = !Ligado;
            }
        }


        class Carro:Veiculo
        {
            public string Nome { get; set; }
            public string Cor { get; set; }
            
            // Passo diretamente pelo construtor
            public Carro(string Nome, string Cor, int VelMax = 0):base(4, VelMax != 0 ? VelMax : 120)
            {
                // Não é necessário passar argumento por agumento
                //Rodas = 4;
                //VelMaxima = 120;
                this.Cor = Cor;
                this.Nome = Nome;
                this.Marca = "VolksWagem"; // Posso alterar mesmo com protected
            }

            public void Info()
            {
                Console.WriteLine($"{this.Nome} - {this.Cor} - {this.VelMaxima} - {this.Rodas} - {this.Ligado}");
            }
        }

        static void Main(string[] args)
        {
            Carro c = new Carro("Ferrarri", "Vermelho");
            // c.Marca = "VolksWagem"; // Não posso pois é protected
            c.Info();
            c.AlterarEstado();
            c.Info();

            Carro c2 = new Carro("Camaro", "Amarelo", 220);
            c2.Info();

        }
    }
}
