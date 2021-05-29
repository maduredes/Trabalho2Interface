using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho2.Models;

namespace Trabalho2
{
    public partial class Form1 : Form
    {
       

       public int contaContaCorrente=0;
       public int contaRG=0;
       public int contaTelefone=0;
       public int contaAgencia=0;
       public  int contaNome=0;
       public int contaCEP=0;


        public Form1()
        {
            InitializeComponent();
            richTextBox1.Multiline = true;
            AutoScroll = true;

            richTextBox2.Multiline = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox2.ReadOnly = true;
            textBox1.Text = richTextBox1.Lines.Length.ToString();
            textBox1.ReadOnly = true;

        }
        

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(richTextBox1.Text);
            MemoryStream stream = new MemoryStream(byteArray);
            StreamReader streamReader = new StreamReader(stream);

            Lexico lexico = new Lexico();
            lexico.setInput(streamReader);
            int linha = 1;
            try
            {

                Token t = null;

                // criar contador para cada tipo de dado
                while ((t = lexico.nextToken()) != null)
                {

                    Console.WriteLine(t.getLexeme() );
                   
                    switch(t.getId())
                    {
                        case 2:
                            contaNome= contaNome+1;
                            break;

                        case 3:
                            contaRG= contaRG+1;
                            break;

                        case 4:
                            contaTelefone= contaTelefone+1;
                            break;

                        case 5:
                            contaCEP = contaCEP+1;
                            break;

                        case 6:
                            contaAgencia = contaAgencia+1;
                            break;
                        case 7:
                            contaContaCorrente = contaContaCorrente+1;
                            break;
                    }

                    linha++;
                }

                richTextBox2.Text = "Dados analisados: \n" + "Nome: " + contaNome + "\nRG:" + contaRG + "\nTelefone: " + contaTelefone + "\nCEP:" + contaCEP + "\nAgência:" + contaAgencia + "\nConta Corrente:" + contaContaCorrente;


            }
            catch (LexicalError ex)
            {
               Console.WriteLine(ex.Message + " " + ex.getPosition());
               
                richTextBox2.Text = "erro na linha: " + richTextBox1.Lines.Length.ToString() +" "+ ex.Message;
               

            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            contaRG = 0;
            contaNome = 0;
            contaTelefone = 0;
            contaContaCorrente = 0;
            contaCEP = 0;
            contaAgencia = 0;

            richTextBox2.Clear();
            richTextBox1.Clear();
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
           

                richTextBox2.Text = "Equipe composta por: Maria Eduarda Dias Correa Redes" + "\nLinguagem utilizada :C#" + "\nFramework utilizado: Windows Forms";
            
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

