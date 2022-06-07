using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;


namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaFuncionario
    {
        public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFuncionario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", "");
                cmd.Parameters.AddWithValue("@emailFun", "");
                cmd.Parameters.AddWithValue("@senhaFun", "");

                SqlParameter nv = cmd.Parameters.AddWithValue("@codigoFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de Funcionario efetuado com sucesso, deseja efetuar outro cadastro?", "Atenção",MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    Funcionarios.Retorno = "Sim";
                    return;
                }
                else
                {
                    Funcionarios.Retorno = "Não";
                    return;
                }


            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Test");
            }
        }
    }
}
