using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class Get_Set
    {
        private string nome;
        private int idade;
        public string Descricao { get; set; } // Não muito utilizado
        public string ValorPadrao { get; } = "Estudante";

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Defino regras
        public int Idade
        {
            get { return idade; }
            set { 
                if(value >= 18)
                {
                    idade = value;
                }
            }
        }

    }
}
