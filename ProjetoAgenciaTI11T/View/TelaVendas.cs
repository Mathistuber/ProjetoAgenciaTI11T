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

    }

}