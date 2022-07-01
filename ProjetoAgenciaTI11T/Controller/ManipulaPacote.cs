using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                cmd.Parameters.AddWithValue("@valorPacote", Pacote.ValorPacote);
                cmd.Parameters.AddWithValue("@origemPacote", Pacote.OrigemPacote);
                cmd.Parameters.AddWithValue("@destinoPacote", Pacote.DestinoPacote);
                cmd.Parameters.AddWithValue("@dataPacoteIda", Pacote.DataPacoteIda);
                cmd.Parameters.AddWithValue("@dataPacoteVolta", Pacote.DataPacoteVolta);
                cmd.Parameters.AddWithValue("@descricaoPacote", Pacote.DescricaoPacote);
                cmd.Parameters.AddWithValue("@imagemPacote", Pacote.ImagemPacote);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoPacote", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de Pacote efetuado com sucesso, deseja efetuar um novo registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
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

        public void pesquisarCodigoPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoPacote", Pacote.CodiogoPacote);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Pacote.CodiogoPacote = Convert.ToInt32(arrayDados["codigoPacote"]);
                    Pacote.ValorPacote = arrayDados["valorPacote"].ToString();
                    Pacote.OrigemPacote = arrayDados["origemPacote"].ToString();
                    Pacote.DestinoPacote = arrayDados["destinoPacote"].ToString();
                    Pacote.DataPacoteIda = arrayDados["dataPacoteIda"].ToString();
                    Pacote.DataPacoteVolta = arrayDados["dataPacoteVolta"].ToString();
                    Pacote.DescricaoPacote = arrayDados["descricaoPacote"].ToString();
                    Pacote.ImagemPacote = (System.Array)arrayDados["imagemPacote"];
                    Pacote.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pacote.Retorno = "Não";
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoPacote", Pacote.CodiogoPacote);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Pacote excluido com sucesso",
                    "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O Pacote não pode ser excluido",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarPacote()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoPacote", Pacote.CodiogoPacote);
                cmd.Parameters.AddWithValue("@valorPacote", Pacote.ValorPacote);
                cmd.Parameters.AddWithValue("@origemPacote", Pacote.OrigemPacote);
                cmd.Parameters.AddWithValue("@destinoPacote", Pacote.DestinoPacote);
                cmd.Parameters.AddWithValue("@dataPacoteIda", Pacote.DataPacoteIda);
                cmd.Parameters.AddWithValue("@dataPacoteVolta", Pacote.DataPacoteVolta);
                cmd.Parameters.AddWithValue("@descricaoPacote", Pacote.DescricaoPacote);
                cmd.Parameters.AddWithValue("@imagemPacote", Pacote.ImagemPacote);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Pacote não pode ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public static BindingSource pesquisaOrigemPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarOrigemPacote", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@origemPacote", Pacote.OrigemPacote);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
        
    }
}
