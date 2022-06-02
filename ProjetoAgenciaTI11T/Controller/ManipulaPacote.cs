using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
                cmd.Parameters.AddWithValue("@valorPacote", "");
                cmd.Parameters.AddWithValue("@origemPacote", "");
                cmd.Parameters.AddWithValue("@destinoPacote", "");
                cmd.Parameters.AddWithValue("@dataPacoteIda", "");
                cmd.Parameters.AddWithValue("@dataPacoteVolta", "");
                cmd.Parameters.AddWithValue("@descricao", "");
                cmd.Parameters.AddWithValue("@imagemPacote", "");
            }
            catch
            {

            }
        }
    }
}
