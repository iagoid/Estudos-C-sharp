﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    // Essas classses são as mesmas classe porémm separadas em 2 arquivos
    partial class PartialClass
    {
        public void TodasOsAtributos()
        {
            Console.WriteLine(this.altura);
            Console.WriteLine(this.nome);
            Console.WriteLine(this.idade);
        }
    }
}
