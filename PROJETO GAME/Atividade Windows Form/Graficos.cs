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
    public partial class Graficos : Form
    {
        public Graficos()
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
            MessageBox.Show("Gráficos setados para Baixo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gráficos setados para Médio!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gráficos setados para Alto!");
        }
    }
}
