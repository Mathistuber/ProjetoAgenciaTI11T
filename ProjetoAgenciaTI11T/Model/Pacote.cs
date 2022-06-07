using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Pacote
    {
        private static int codigoPacote;
        private static string valorPacote;
        private static string origemPacote;
        private static string destinoPacote;
        private static string dataPacoteIda;
        private static string dataPacoteVolta;
        private static string descricaoPacote;
        private static Array imagemPacote;
        private static string retorno;

        public static int CodiogoPacote { get => codigoPacote; set => codigoPacote = value; }
        public static string ValorPacote { get => valorPacote; set => valorPacote = value; }
        public static string OrigemPacote { get => origemPacote; set => origemPacote = value; }
        public static string DestinoPacote { get => destinoPacote; set => destinoPacote = value; }
        public static string DataPacoteIda { get => dataPacoteIda; set => dataPacoteIda = value; }
        public static string DataPacoteVolta { get => dataPacoteVolta; set => dataPacoteVolta = value; }
        public static string DescricaoPacote { get => descricaoPacote; set => descricaoPacote = value; }
        public static Array ImagemPacote { get => imagemPacote; set => imagemPacote = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
