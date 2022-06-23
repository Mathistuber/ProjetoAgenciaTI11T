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
    public partial class TelePesquisarCliente : Form
    {
        public TelePesquisarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (tbxCodigoCli.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodigoCli.Text = string.Empty;
                tbxCodigoCli.Focus();
                tbxCodigoCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;

            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCodigoCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                tbxCodigoCli.Text = Clientes.CodigoCli.ToString();
                tbxNomeCli.Text = Clientes.NomeCli;
                tbxEmailCli.Text = Clientes.EmailCli;
                tbxSenhaCli.Text = Clientes.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCli);
                pictureBox2.Image = Image.FromStream(ms);

            }   
            if(Clientes.Retorno == "Não")
                {
                    tbxCodigoCli.Text = string.Empty;
                    tbxCodigoCli.Focus();
                    tbxCodigoCli.SelectAll();
                    tbxNomeCli.Text = string.Empty;
                    tbxEmailCli.Text = string.Empty;
                    tbxSenhaCli.Text = string.Empty;
                    pictureBox2.Image = null;
                    return;
            }
        }
    }
}
