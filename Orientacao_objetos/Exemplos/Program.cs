using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inimigo i1 = new Inimigo("Maluco");
            Inimigo i2 = new Inimigo("Doido");
            Inimigo i3 = new Inimigo("Crazy");
            i1.Info();
            i2.Info();
            i3.Info();
            Inimigo.Alerta = true;
            i1.Info();
            i2.Info();
            i3.Info();

        }
    }
}
