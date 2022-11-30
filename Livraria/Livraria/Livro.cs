using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    internal class Livro  
    {
        string nome, precoVenda, dataLancamento;
            int editora;

        public string Nome { get => nome; set => nome = value; }
        public string PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public string DataLancamento { get => dataLancamento; set => dataLancamento = value; }
        public int Editora { get => editora; set => editora = value; }
    }
}
