using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Livraria
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=livraria2si");
        public String mensagem;

        public DataTable lista_editora()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("Lista_Editora", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_editora

        public DataTable lista_produto()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("lista_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_produto


        public bool insereProduto(Livro livro)
        {
            MySqlCommand cmd = new MySqlCommand("insere_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("novoNome", livro.Nome);
            cmd.Parameters.AddWithValue("precoVenda", livro.PrecoVenda);
            cmd.Parameters.AddWithValue("precoCusto", livro.PrecoCusto);
            cmd.Parameters.AddWithValue("qtdEstoque", livro.QtdEstoque);
            cmd.Parameters.AddWithValue("dataLancamento", livro.DataLancamento);
            cmd.Parameters.AddWithValue("codEditora", livro.Editora);
            cmd.Parameters.AddWithValue("codVenda", livro.codVenda);
            cmd.Parameters.AddWithValue("codCliente", livro.codCliente);
            cmd.Parameters.AddWithValue("codCategoria", livro.codCategoria);



            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereProduto 

        public bool insereEditora(Editora editora)
        {
            MySqlCommand cmd = new MySqlCommand("insere_editora", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("novoNome", editora.Nome);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereEditora



    }
}
