using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Carro
    {
        /*struct é semelhante a uma classe, 
         * porém ela é do tipo de valor enquanto 
         * a classe é um tipo de referência.
         * Uma struct é muito útil quando precisamos de poucas variáveis,
         * pois os objetos criados com base em structs são mais leves 
         * e por ser do tipo de valor não trabalham com referências.
         * Uma struct pode possuir construtores, campos, 
         * propriedades, métodos, indexadores. 
         * Uma struct pode ainda implementar uma interface,
         * porém não existe herança entre structs.
         */
        public int Id { get; set; }
        public string Name { get; set; }

        public Carro(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void Info()
        {
            Console.WriteLine($"{this.Name}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Name = "Opala";
            carro.Id = 1;
            carro.Info();
        }
    }
}
