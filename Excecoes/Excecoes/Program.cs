using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf = Console.ReadLine();
            if (cpf.Trim().Length != 11)
            {
                throw new CPFInvalidoException();
            }
        }

        public class CPFInvalidoException : Exception
        {
            const string mensagem = "Digitos verificaadores inválidos.";
            public CPFInvalidoException() : base (mensagem)
            {
                this.HelpLink = "google.com.br";
            }
        }
    }
}
