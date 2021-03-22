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
    public partial class Tempo_de_Jogo : Form
    {
        public Tempo_de_Jogo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tempo de jogo setado para 5 minutos!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Opções Tela = new Opções();
            Tela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tempo de jogo setado para 10 minutos!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tempo de jogo setado para 15 minutos!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tempo de jogo setado para 20 minutos!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tempo de jogo setado para 30 minutos!");
        }
    }
}
