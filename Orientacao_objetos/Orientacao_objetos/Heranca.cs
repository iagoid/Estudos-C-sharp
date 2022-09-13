using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{

    // Passo os metodos e atributos comuns 
    // e os adiciono em uma classe generica(Veiculo)
    // após isso faço a herança com as classes
    // relacionadas(Carro e Bicicleta)

    // Classes abstratas não podem ser instânciadas como objetos
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        // No metodo abstrato
        // cada classe herdeira precisa da sua própria imprementação
        public abstract void Acelerar(); 
 
        public void Freiar()
        {
            Console.WriteLine("Freiando");
        }
    }

    class Carro : Veiculo
    {
        public string VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor");
        }

        public override void Acelerar()
        {
             Console.WriteLine("Acelerando o carro");
        }
    }

    // A palavra sealed define que a classe 
    // não pode ser herdada
    sealed class Bicicleta : Veiculo
    {
        public string VelocidadeMaxima { get; set; }

        public void Pedalar()
        {
            Console.WriteLine("Pedalando");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando a bicicleta");
        }
    }

    class Caminhonete : Carro
    {
        public bool cabineExtendida { get; set; }
    }
}
