using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Windows_Form
{
    public partial class Dificuldade : Form
    {
        public Dificuldade()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Opções Tela = new Opções();
            Tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dificuldade setada em Iniciante!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dificuldade setada em Normal!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dificuldade setada em Intermediário!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dificuldade setada em Estrela!");
        }
    }
}
