using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;
using System.IO;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaVendas : Form
    {
        public TelaVendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxCliente.Text = string.Empty;


            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCodCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                if (Clientes.Retorno == "Não")
                {
                    tbxCodCli.Text = string.Empty;
                    tbxCodCli.Focus();
                    tbxCodCli.SelectAll();
                    tbxCliente.Text = string.Empty;
                    return;
                }
                else
                {
                    tbxCodCli.Text = Clientes.CodigoCli.ToString();
                    tbxCliente.Text = Clientes.NomeCli;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um Código de Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxFuncionario.Text = string.Empty;


            }
            else
            {
                Funcionarios.CodigoFun = Convert.ToInt32(tbxCodFun.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFuncionario();

                tbxCodFun.Text = Funcionarios.CodigoFun.ToString();
                tbxFuncionario.Text = Funcionarios.NomeFun;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbxCodPacote.Text == "")
            {
                MessageBox.Show("Digite um Código de ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodPacote.Text = string.Empty;
                tbxCodPacote.Focus();
                tbxCodPacote.SelectAll();
                tbxPacote.Text = string.Empty;

            }
            else
            {
                Pacote.CodiogoPacote = Convert.ToInt32(tbxCodPacote.Text);
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.pesquisarCodigoPacote();

                if (Pacote.Retorno == "Não")
                {
                    tbxCodPacote.Text = string.Empty;
                    tbxCodPacote.Focus();
                    tbxCodPacote.SelectAll();
                    tbxPacote.Text = string.Empty;
                    return;
                }
                else
                {
                    tbxCodPacote.Text = Pacote.CodiogoPacote.ToString();
                    tbxPacote.Text = Pacote.ValorPacote;
                }



            }
        }

        private void btnSalvarPacote_Click(object sender, EventArgs e)
        {
            if (tbxCliente.Text == "" | tbxCodCli.Text == "" | tbxFuncionario.Text == "" | tbxCodFun.Text == "" | tbxPacote.Text == "" | tbxCodPacote.Text == "" | comboBox1.Text == "")
            {
                MessageBox.Show("Preencha todas as informações Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clientes.NomeCli = tbxCliente.Text;
                Funcionarios.NomeFun = tbxFuncionario.Text;
                Pacote.ValorPacote = tbxPacote.Text;

                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.cadastrarCliente();
            }
        }
    }

}