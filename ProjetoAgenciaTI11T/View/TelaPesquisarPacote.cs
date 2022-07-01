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
                MessageBox.Show("Digite um Código de ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                Pacote.CodiogoPacote = Convert.ToInt32(tbxCodigoPacote.Text);
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

        private void btnBuscarNomePacote_Click(object sender, EventArgs e)
        {
            if (tbxOrigem.Text == "")
            {
                MessageBox.Show("Digite um nome para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Pacote.OrigemPacote = tbxOrigem.Text;

            dataGridViewPaco.DataSource = ManipulaPacote.pesquisaOrigemPacote();
            dataGridViewPaco.Columns[0].Visible = false;
            dataGridViewPaco.Columns[1].Visible = false;
            dataGridViewPaco.Columns[2].Visible = false;
            dataGridViewPaco.Columns[3].Visible = false;
            dataGridViewPaco.Columns[4].Visible = false;
            dataGridViewPaco.Columns[5].Visible = false;
            dataGridViewPaco.Columns[6].HeaderCell.Value = "Valor";
            dataGridViewPaco.Columns[7].HeaderCell.Value = "Destino";
            dataGridViewPaco.Columns[8].HeaderCell.Value = "Origem";
            dataGridViewPaco.Columns[9].HeaderCell.Value = "Ida";
            dataGridViewPaco.Columns[10].HeaderCell.Value = "Volta";
            dataGridViewPaco.Columns[11].Visible = false;
            dataGridViewPaco.Columns[12].Visible = false;
        }

    }
}
