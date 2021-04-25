using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Multiline = true;
            
            richTextBox2.Multiline = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox2.ReadOnly = true;
            textBox1.Text = richTextBox1.Lines.Length.ToString();
            textBox1.ReadOnly = true;

        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Funcionalidade ainda não inserida";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox1.Clear();
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Equipe composta por: Maria Eduarda Dias Correa Redes"+"\nLinguagem utilizada :C#"+"\nFramework utilizado: Windows Forms";
        }



 


        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Lines.Length.ToString();
            textBox1.ReadOnly = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

