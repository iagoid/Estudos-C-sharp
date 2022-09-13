using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class CaixaEletronico : IConta
    {
        public string Usuario {get; set;}

        public void Depositar()
        {
        }

        public void Sacar()
        {
        }
    }

    // Todas as classes que implementarem a interface precisam
    // OBRIGATORIAMENTE implementar todos os metodos e atributos
    // * Igual uma classe porém todos os metodos são abstratos
    interface IConta
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
    }
}
