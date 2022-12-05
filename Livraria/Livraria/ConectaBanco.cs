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
        public String? mensagem;

        public DataTable? lista_editora()
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

        public DataTable? listaCliente()
        {
            MySqlCommand cmd = new MySqlCommand("lista_cliente", conexao);
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

        }// fim lista_cliente


        public bool insereCliente(Cliente cliente)
        {
            MySqlCommand cmd = new MySqlCommand("insere_cliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("dataNascimento", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("cpf", cliente.CPF);
            cmd.Parameters.AddWithValue("uf", cliente.UF);
            cmd.Parameters.AddWithValue("endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("cep", cliente.CPF );
            cmd.Parameters.AddWithValue("email", cliente.Email);



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
