using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class Enumerador
    {
        // Enums
        // Enumera automaticamente começando do 0+
        enum DiasSemana
        {
            Domingo,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta, 
            Sabado
        }

        enum MesTrimestre
        {
            Janeiro = 1,
            Maio = 5,
            Setembro = 9,
        }

        public static void Enumerar()
        {

            int dia = (int)DiasSemana.Domingo;
            Console.WriteLine($"Domingo é o dia {dia}");

            DiasSemana nomeDia = (DiasSemana) 1;
            Console.WriteLine($"O dia 1 é {nomeDia}");


        }
    }
}
