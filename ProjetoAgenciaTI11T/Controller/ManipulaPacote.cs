using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaPacote
    {
        public void cadastrarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPacote",Pacote.ValorPacote);
                cmd.Parameters.AddWithValue("@origemPacote",Pacote.OrigemPacote);
                cmd.Parameters.AddWithValue("@destinoPacote",Pacote.DestinoPacote);
                cmd.Parameters.AddWithValue("@dataPacoteIda",Pacote.DataPacoteIda);
                cmd.Parameters.AddWithValue("@dataPacoteVolta",Pacote.DataPacoteVolta);
                cmd.Parameters.AddWithValue("@descricao",Pacote.DescricaoPacote);
                cmd.Parameters.AddWithValue("@imagemPacote","");

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoPacote", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de Pacote efetuado com sucesso, deseja efetuar outro cadastro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacote.Retorno = "Não";
                    return;
                }
            }

            catch
            {

            }
        }
    }
}
