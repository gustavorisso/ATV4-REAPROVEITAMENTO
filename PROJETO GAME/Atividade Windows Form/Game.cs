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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuário_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando Novo Jogo...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carregando Jogo Salvo...");
        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {
            if (tb_senha.TextLength == tb_senha.MaxLength)
            {
                MessageBox.Show("Tamanho máximo de caracteres atingido");
            }
        }

        private void tb_usuario_TextChanged(object sender, EventArgs e)
        {
            if (tb_usuario.TextLength == tb_usuario.MaxLength)
            {
                MessageBox.Show("Tamanho máximo de caracteres atingido");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Opções Tela = new Opções();
            Tela.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_usuario.Text == "Gustavo" && tb_senha.Text == "1234") ;
            Online Tela = new Online();
            Tela.Show();
            this.Hide();
        }
            

        private void button6_Click(object sender, EventArgs e)
        {
            if (tb_usuario.Text == "Gustavo" && tb_senha.Text == "1234")
            {
                MessageBox.Show("Conectado com sucesso!");
                button5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos ou não cadastrados!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Replays Tela = new Replays();
            Tela.Show();
            this.Hide();
        }
    }
}
        

