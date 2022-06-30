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
    public partial class TelaPesquisarPacote : Form
    {
        public TelaPesquisarPacote()
        {
            InitializeComponent();
        }

        private void btnBuscarPacote_Click(object sender, EventArgs e)
        {
            if (tbxCodigoPacote.Text == "")
            {
                MessageBox.Show("Digite um Código de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodigoPacote.Text = string.Empty;
                tbxCodigoPacote.Focus();
                tbxCodigoPacote.SelectAll();
                tbxValorPacote.Text = string.Empty;
                tbxOrigem.Text = string.Empty;
                tbxDestinoPacote.Text = string.Empty;
                tbxDataIda.Text = string.Empty;
                tbxDescrição.Text = string.Empty;


            }
            else
            {
                Clientes.CodigoCli = Convert.ToInt32(tbxCodigoPacote.Text);
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.pesquisarCodigoPacote();

                if (Pacote.Retorno == "Não")
                {
                    tbxCodigoPacote.Text = string.Empty;
                    tbxCodigoPacote.Focus();
                    tbxCodigoPacote.SelectAll();
                    tbxValorPacote.Text = string.Empty;
                    tbxOrigemPacote.Text = string.Empty;
                    tbxDestinoPacote.Text = string.Empty;
                    tbxDataIda.Text = string.Empty;
                    tbxDataVolta.Text = string.Empty;
                    tbxDescrição.Text = string.Empty;
                    pictureBoxPacote.Image = null;
                    return;
                }
                else
                {
                    tbxCodigoPacote.Text = Pacote.CodiogoPacote.ToString();
                    tbxValorPacote.Text = Pacote.ValorPacote;
                    tbxOrigemPacote.Text = Pacote.OrigemPacote;
                    tbxDestinoPacote.Text = Pacote.DestinoPacote;
                    tbxDataIda.Text = Pacote.DataPacoteIda;
                    tbxDataVolta.Text = Pacote.DataPacoteVolta;
                    tbxDescrição.Text = Pacote.DescricaoPacote;

                    MemoryStream ms = new MemoryStream((byte[])Pacote.ImagemPacote);
                    pictureBoxPacote.Image = Image.FromStream(ms);
                }



            }
        }
    }
}
