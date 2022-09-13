using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    static class ClasseEstatica
    {
        public static int taxa;

        // Classes estatica não são adicionadas a objetos
        // elas são vistas em todo o projeto
        // todos seus valores e metodos precisam ser estáticos
        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }


    }
}
