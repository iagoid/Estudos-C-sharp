using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class Forma
    {
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }
        public virtual void Area() {
            double area = Altura * Largura;
            Console.WriteLine("Area " + area);
        }
    }

    internal class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); // Chamo o metodo herdado
            Console.WriteLine("Desenhando um circulo");
        }
        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Area circulo " + area);
        }
    }
    
    internal class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); // Chamo o metodo herdado
            Console.WriteLine("Desenhando um retangulo");
        }
        public override void Area()
        {
            base.Area();
        }
    }
    
    internal class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar(); // Chamo o metodo herdado
            Console.WriteLine("Desenhando um triangulo");
        }
        public override void Area()
        {
            double area = (Altura * Largura)/2;
            Console.WriteLine("Area retangulo " + area);
        }
    }
}
