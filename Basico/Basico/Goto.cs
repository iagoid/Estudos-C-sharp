using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class Goto
    {

        public static void Vai()
        {
            #region GOTO
            goto mensagem;
            Console.WriteLine("Código Pulado");

        mensagem:
            Console.WriteLine("Assim funciona o GOTO");
            #endregion
        }
    }
}
