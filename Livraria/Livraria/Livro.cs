using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    internal class Livro  
    {
            string nome, precoVenda, dataLancamento, precoCusto, qtdestoque;
            int editora, codvenda, codcliente, codcategoria;

        public string Nome { get => nome; set => nome = value; }
        public string PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public string PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public string QtdEstoque { get => qtdestoque; set => qtdestoque = value; }
        public string DataLancamento { get => dataLancamento; set => dataLancamento = value; }
        public int Editora { get => editora; set => editora = value; }
        public int codVenda { get => codvenda; set => codvenda = value; }
        public int codCliente { get => codcliente; set => codcliente = value; }
        public int codCategoria { get => codcategoria; set=> codcategoria = value; }
    }
}
