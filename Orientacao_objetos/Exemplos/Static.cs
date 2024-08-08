using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class Inimigo
    {
        // Muda o valor de Alerta para todos
        public static bool Alerta { get; set; }
        public string Nome { get; set; }

        public Inimigo(string Nome)
        {
            this.Nome = Nome;
        }

        public void Info()
        {
            if (Alerta)
            {
                Console.WriteLine($"{Nome} está alerta");
            } else
            {
                Console.WriteLine($"{Nome} está DISTRAIDO");
            }
        }
    }
}
