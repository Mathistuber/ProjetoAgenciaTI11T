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
    class ManipulaCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            { 
                cmd.Parameters.AddWithValue("@nomeCli",Clientes.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli",Clientes.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli",Clientes.SenhaCli);
                cmd.Parameters.AddWithValue("@imagemCli",Clientes.ImagemCli);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoCli", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de Cliente efetuado com sucesso, deseja efetuar um novo registro?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    Clientes.Retorno = "Sim";
                    return;
                    
                }
                else
                {
                    Clientes.Retorno = "Não";
                    return;
                }

            }
            catch
            {

            }
        }

        public void pesquisarCodigoCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoCli", Clientes.CodigoCli);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Clientes.CodigoCli = Convert.ToInt32(arrayDados["codigoCli"]);
                    Clientes.NomeCli = arrayDados["nomeCli"].ToString();
                    Clientes.EmailCli = arrayDados["emailCli"].ToString();
                    Clientes.SenhaCli = arrayDados["senhaCli"].ToString();
                    Clientes.ImagemCli = (System.Array)arrayDados["imagemCli"];
                    Clientes.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clientes.Retorno = "Não";
                }
            }
            catch(Exception e)
            {

                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codigoCli", Clientes.CodigoCli);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso",
                    "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O Cliente não pode ser excluido",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoCli", Clientes.CodigoCli);
                cmd.Parameters.AddWithValue("@nomeCli", Clientes.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Clientes.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli", Clientes.SenhaCli);
                cmd.Parameters.AddWithValue("@imagemCli", Clientes.ImagemCli);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso", "Atencão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Cliente não foi alterado",
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


        public static BindingSource pesquisarNomeCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisarNomeCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeCli", Clientes.NomeCli);
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
