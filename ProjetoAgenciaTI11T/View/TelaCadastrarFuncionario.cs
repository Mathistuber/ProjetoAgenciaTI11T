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

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaCadastrarFuncionario : Form
    {
        public TelaCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvarFun_Click(object sender, EventArgs e)
        {
            if (tbxNomeFun.Text == "" | tbxEmailFun.Text == "" | tbxSenhaFun.Text == "")
            {
                MessageBox.Show("Preencha todas as informações corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Funcionarios.NomeFun = tbxNomeFun.Text;
                Funcionarios.EmailFun = tbxEmailFun.Text;
                Funcionarios.SenhaFun = tbxSenhaFun.Text;

                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.cadastrarFuncionario();

            }

            if (Funcionarios.Retorno == "Sim")
            {
                LimpaTela();
                return;
            }

            if (Funcionarios.Retorno == "Não")
            {
                fecharCadastro();
                return;
            }

        }
        public void fecharCadastro()
        {
            this.Close();
        }

        public void LimpaTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = String.Empty;
                }
            }
        }
    }
}
