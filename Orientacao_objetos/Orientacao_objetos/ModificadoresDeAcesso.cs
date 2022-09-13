using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class Humano
    {
        public string nome; // Acesso por todos
        private int idade; // Acesso apenas dentro da classe
        protected float altura;// Acesso dentro da classe herdada porém não pelo objeto
        internal string sobrenome; // Restrito a essa aplicação, não pode ser usado em DLL
    }


    class Homem : Humano
    {
        void SuaAltura()
        {
            Console.WriteLine("Sua altura é " + this.altura);
        }

        void CriarHumano()
        {
            Humano h = new Humano();
        }
    }
}
