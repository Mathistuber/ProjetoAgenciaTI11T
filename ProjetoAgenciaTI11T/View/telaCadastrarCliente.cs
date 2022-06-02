using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;

namespace ProjetoAgenciaTI11T.View
{
    public partial class telaCadastrarCliente : Form
    {
        public telaCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg; *.png ";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialogImagem.FileName);
            }
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNomeCliente.Text == "" | tbxEmailCliente.Text == "" | tbxSenhaCliente.Text == "" | pictureBox1.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clientes.NomeCli = tbxNomeCliente.Text;
                Clientes.EmailCli = tbxEmailCliente.Text;
                Clientes.SenhaCli = tbxSenhaCliente.Text;
                if (pictureBox1.Image != null)
                {

                    MemoryStream memoryStream = new MemoryStream();
                    pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
                    Clientes.ImagemCli = memoryStream.ToArray();
                }

                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.cadastrarCliente();

            }

            if (Clientes.Retorno == "Sim")
            {
                LimpaTela();
                return;
            }

            if (Clientes.Retorno == "Não")
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
                if(ctl is PictureBox)
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
