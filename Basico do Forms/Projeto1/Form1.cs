using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* O Design do formulário é todo feito no arquivo Form1.Designer.cs
 * Nas references temos as referências para usar no projeto
 * E as properties que são as propriedade do projeto(nome, versões, etc)
 * 
 * Para compilar menu build->BuildSolution, ele é salvo dentro da pasta bin do projeto
 * em uma pasta debug ou release(dependendo do tipo de compilação)
*/


// Namespace usado para ser incorporado e posteriormente referenciado
// no código fonte do projeto
namespace Projeto1 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int teste = 10;
            Console.WriteLine(teste);
           
        }
    }
}
