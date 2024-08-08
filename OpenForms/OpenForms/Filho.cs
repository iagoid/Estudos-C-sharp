using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenForms
{
    public partial class Filho : Form
    {
        private Pai pai;

        public Filho()
        {
            InitializeComponent();
            pai = Application.OpenForms["Pai"] as Pai;

            // Tive que mudar o campo  "modifier" para public para acessar o campo
            this.textBox1.Text = pai.textBox1.Text; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pai.textBox1.Text = textBox1.Text;
        }
    }
}
