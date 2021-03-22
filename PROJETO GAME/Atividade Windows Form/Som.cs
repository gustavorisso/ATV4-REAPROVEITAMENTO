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
    public partial class Som : Form
    {
        public Som()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Som da torcida Habilitado!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Som da torcida Desabilitado!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Som da narração Habilitado!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Som da narração Desabilitado!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Música Habilitada!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Música Desabilitada!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sons do sistema Habilitados!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sons do sistema Desabilitados!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Opções Tela = new Opções();
            Tela.Show();
            this.Hide();
        }
    }
}
