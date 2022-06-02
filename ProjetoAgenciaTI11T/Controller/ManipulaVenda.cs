using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaVenda
    {
        public void cadastrarVenda()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVendas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoVenda", "");
                cmd.Parameters.AddWithValue("@codigoCliFK", "");
                cmd.Parameters.AddWithValue("@codigoFunFK", "");
                cmd.Parameters.AddWithValue("@codigoPacoteFK", "");
                cmd.Parameters.AddWithValue("@pagoVenda", "");
            }
            catch
            {

            }
        }
    }
}
