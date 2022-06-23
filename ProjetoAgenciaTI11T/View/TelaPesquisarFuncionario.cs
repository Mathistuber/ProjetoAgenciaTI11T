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

    }
}