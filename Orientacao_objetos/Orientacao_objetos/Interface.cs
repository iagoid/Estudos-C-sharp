using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{


    interface IAnimal
    {
        void Nome(string Nome);
        void Dono(string Dono);
        void Especie(string Especie);
    }

    // Qualquer classe que herda uma interface
    // é obrigada a implementar todos os metodos da interface
    internal class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
        public string Especie { get; set; }
        

        void IAnimal.Nome(string Nome)
        {
            this.Nome = Nome;
        }

        void IAnimal.Dono(string Dono)
        {
            this.Dono = Dono;
        }

        void IAnimal.Especie(string Especie)
        {
            this.Especie = Especie;
        }
    }
}
