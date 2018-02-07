using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leitor_de_arquivos_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            StreamReader leitor = new StreamReader(openFileDialog1.FileName);
            while (!leitor.EndOfStream)
            {
                textBox1.Text += leitor.ReadLine();
            }

        leitor.Close();
        leitor.Dispose();


    }

     

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter escrita = new StreamWriter(saveFileDialog1.FileName);
            escrita.Write(textBox1.Text);
            escrita.Flush();
            escrita.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse arquivo de texto foi criado por Artur Mauricio Pitta Junior");
        }
    }
}
