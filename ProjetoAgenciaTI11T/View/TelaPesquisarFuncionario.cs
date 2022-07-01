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
    public partial class TelaPesquisarFuncionario : Form
    {

        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxCodigoFun.Text == "")
            {
                MessageBox.Show("Digite um Código de Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodigoFun.Text = string.Empty;
                tbxCodigoFun.Focus();
                tbxCodigoFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;

            }
            else
            {
                Funcionarios.CodigoFun = Convert.ToInt32(tbxCodigoFun.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFuncionario();

                tbxCodigoFun.Text = Funcionarios.CodigoFun.ToString();
                tbxNomeFun.Text = Funcionarios.NomeFun;
                tbxEmailFun.Text = Funcionarios.EmailFun;
                tbxSenhaFun.Text = Funcionarios.SenhaFun;

                if (Clientes.Retorno == "Não")
                {
                    tbxCodigoFun.Text = string.Empty;
                    tbxCodigoFun.Focus();
                    tbxCodigoFun.SelectAll();
                    tbxNomeFun.Text = string.Empty;
                    tbxEmailFun.Text = string.Empty;
                    tbxSenhaFun.Text = string.Empty;
                    return;
                }


            }
        }

        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxCodigoFun.Text == "")
            {
                MessageBox.Show("Digite um código de Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodigoFun.Text = string.Empty;
                tbxCodigoFun.Focus();
                tbxCodigoFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Cliente " + tbxCodigoFun.Text + "?",
                  "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionarios.CodigoFun = Convert.ToInt32(tbxCodigoFun.Text);
                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.deletarFuncionario();
                }
            }
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxCodigoFun.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Funcionario ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodigoFun.Text = string.Empty;
                tbxCodigoFun.Focus();
                tbxCodigoFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;

            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do Funcionario " + tbxCodigoFun.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Funcionarios.CodigoFun = Convert.ToInt32(tbxCodigoFun.Text);
                    Funcionarios.NomeFun = tbxNomeFun.Text;
                    Funcionarios.EmailFun = tbxEmailFun.Text;
                    Funcionarios.SenhaFun = tbxSenhaFun.Text;

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.alterarFuncionario();

                }
            }
        }

        private void btnBuscarNomeFun_Click(object sender, EventArgs e)
        {
            if (tbxPesquisarNomeFun.Text == "")
            {
                MessageBox.Show("Digite um nome para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Funcionarios.NomeFun = tbxPesquisarNomeFun.Text;

            dataGridViewFun.DataSource = ManipulaFuncionario.pesquisarNomeFuncionario();

          dataGridViewFun.Columns[0].Visible = false;
          dataGridViewFun.Columns[1].Visible = false;
          dataGridViewFun.Columns[2].Visible = false;
          dataGridViewFun.Columns[3].HeaderCell.Value = "Código";
          dataGridViewFun.Columns[4].HeaderCell.Value = "Nome";
          dataGridViewFun.Columns[5].HeaderCell.Value = "E-mail";
          dataGridViewFun.Columns[6].Visible = false;



        }
    }
}