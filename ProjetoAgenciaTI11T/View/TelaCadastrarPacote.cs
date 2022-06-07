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
    public partial class TelaCadastrarPacote : Form
    {
        public TelaCadastrarPacote()
        {
            InitializeComponent();
        }

        private void btnBuscarPacote_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg; *.png ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSalvarPacote_Click(object sender, EventArgs e)
        {
            if ( tbxValor.Text == "" | tbxOrigemPacote.Text == "" | tbxDestino.Text == "" | tbxDataIda.Text == "" | tbxDataVolta.Text == ""| tbxDescrição.Text == "" | pictureBox2.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pacote.ValorPacote = tbxValor.Text;
                Pacote.OrigemPacote = tbxOrigemPacote.Text;
                Pacote.DestinoPacote = tbxDestino.Text;
                Pacote.DataPacoteIda = tbxDataIda.Text;
                Pacote.DataPacoteVolta = tbxDataVolta.Text;
                Pacote.DescricaoPacote = tbxDescrição.Text;
                if (pictureBox2.Image != null)
                {

                    MemoryStream memoryStream = new MemoryStream();
                    pictureBox2.Image.Save(memoryStream, pictureBox2.Image.RawFormat);
                    Pacote.ImagemPacote = memoryStream.ToArray();
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
                if (ctl is PictureBox)
                {
                    pictureBox2.Image = null;
                }
            }
        }

    }
}
