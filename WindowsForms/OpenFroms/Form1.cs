using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFroms
{
    public partial class Form1 : Form
    {

        public Form1 form1;

        public Form1()
        {
            InitializeComponent();

            form1 = Application.OpenForms["Form1"] as Form1;
            this.textBox1.Text = form1.textBox1.Text;
        }
    }
}
