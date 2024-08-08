using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // https://learn.microsoft.com/pt-br/dotnet/api/system.windows.forms.maskedtextbox.mask?view=windowsdesktop-7.0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = maskedTextBox1.Text;

            MessageBox.Show(msg + " REMOVIDO OS CARACTRERES ESPECCIAIS (ExcludePromptAndLiteral)");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.ToString() == "Fechar")
            {
                this.Close();
            } else if (e.ClickedItem.Text.ToString() == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Text.ToString() == "Mensagem")
            {
                MessageBox.Show("Você clicou na mensagem");
            }
        }


    }
}
