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
    public partial class Opções : Form
    {
        public Opções()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dificuldade Tela = new Dificuldade();
            Tela.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Game Tela = new Game();
            Tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controles Tela = new Controles();
            Tela.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comandos Tela = new Comandos();
            Tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tempo_de_Jogo Tela = new Tempo_de_Jogo();
            Tela.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graficos Tela = new Graficos();
            Tela.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Som Tela = new Som();
            Tela.Show();
            this.Hide();
        }
    }
}
