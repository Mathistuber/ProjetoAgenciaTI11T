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

                if (Clientes.Retorno == "Não")
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
                else
                {
                    tbxCodigoCli.Text = Clientes.CodigoCli.ToString();
                    tbxNomeCli.Text = Clientes.NomeCli;
                    tbxEmailCli.Text = Clientes.EmailCli;
                    tbxSenhaCli.Text = Clientes.SenhaCli;

                    MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCli);
                    pictureBox2.Image = Image.FromStream(ms);
                }



            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (tbxCodigoCli.Text == "")
            {
                MessageBox.Show("Digite um código de cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodigoCli.Text = string.Empty;
                tbxCodigoCli.Focus();
                tbxCodigoCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox2.Image = null;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Cliente " + tbxCodigoCli.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCli = Convert.ToInt32(tbxCodigoCli.Text);
                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.deletarCliente();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(tbxCodigoCli.Text == "")
            {
                MessageBox.Show("Digite um de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodigoCli.Text = string.Empty;
                tbxCodigoCli.Focus();
                tbxCodigoCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox2.Image = null;

            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os do Cliente" + tbxCodigoCli.Text + "?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCli = Convert.ToInt32(tbxCodigoCli.Text);
                    Clientes.NomeCli = tbxNomeCli.Text;
                    Clientes.EmailCli = tbxEmailCli.Text;
                    Clientes.SenhaCli = tbxSenhaCli.Text;

                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    Clientes.ImagemCli = ms.ToArray();


                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.alterarCliente();

                }
            }
        }

        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg; *.png ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnBuscarNomeCliente_Click(object sender, EventArgs e)
        {
            if (tbxNomeCliente.Text == "")
            {
                MessageBox.Show("Digite um nome para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Clientes.NomeCli = tbxNomeCliente.Text;

            dataGridView1.DataSource = ManipulaCliente.pesquisarNomeCliente();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderCell.Value = "Código";
            dataGridView1.Columns[5].HeaderCell.Value = "Nome";
            dataGridView1.Columns[6].HeaderCell.Value = "E-mail";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderCell.Value = "Imagem";
        }
    }
}
