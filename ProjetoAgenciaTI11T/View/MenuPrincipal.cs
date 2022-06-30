using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void MenuPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarCliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaCadastrarCliente TelaCadastrarCliente = new telaCadastrarCliente();
            TelaCadastrarCliente.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario telaCadastrarFuncionario = new TelaCadastrarFuncionario();
            telaCadastrarFuncionario.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastrarPacote telaCadastrarPacote = new TelaCadastrarPacote();
            telaCadastrarPacote.ShowDialog();
        }

        private void pesquisarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TelePesquisarCliente telePesquisarCliente = new TelePesquisarCliente();
            telePesquisarCliente.ShowDialog();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisarFuncionario telaPesquisarFuncionario = new TelaPesquisarFuncionario();
            telaPesquisarFuncionario.ShowDialog();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaPesquisarPacote telaPesquisarPacote = new TelaPesquisarPacote();
            telaPesquisarPacote.ShowDialog();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaVendas vendas = new TelaVendas();
            vendas.ShowDialog();
        }
    }
}
