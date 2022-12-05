using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Livraria : Form
    {
        private object txtnome;
        private object txtvenda;

        public Livraria()
        {
            InitializeComponent();
        }

        void listaEditora()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.lista_editora();
            cbeditora.DataSource = tabelaDados;
            cbeditora.DisplayMember = "nome";
            cbeditora.ValueMember = "codEditora";
            // preenchendo cbAlteraGenero
            // cbAlteraGenero.DataSource = tabelaDados;
            // cbAlteraGenero.DisplayMember = "genero";
            // cbAlteraGenero.ValueMember = "idgenero";
            //
            lblerro.Text = con.mensagem;
            cbeditora.Text = "";
            //cbAlteraGenero.Text = "";
        }
        private void listaCliente()
        {
            ConectaBanco con = new ConectaBanco();
            cbcliente.DataSource = con.listaCliente();
            lblerro.Text = con.mensagem;05/12
        }

            private void Livraria_Load_1(object sender, EventArgs e)
            {
                listaEditora();
                listaCliente();
            }

            private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
            {

                Cliente b = new Cliente();
                b.Nome = txtcliente.Text;
                b.DataNascimento = txtdata.Text;
                b.CPF = txtcpf.Text;
                b.UF = txtuf.Text;
                b.Endereco = txtendereco.Text;
                b.Bairro = txtbairro.Text;
                b.Cidade = txtcidade.Text;
                b.CEP = txtcep.Text;
                b.Email = txtemail.Text;
                // Enviar para o banco

                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.insereCliente(b);
                if (retorno == true)
                {
                    MessageBox.Show("Dados inseridos com sucesso !");
                }
                else
                    lblerro.Text = conecta.mensagem;




            }

            private void txtnomeEditora_TextChanged(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                Editora b = new Editora();

                b.Nome = txtnomeEditora.Text;
                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.insereEditora(b);
                if (retorno == true)
                {
                    MessageBox.Show("Dados inseridos com sucesso !");
                }
                else
                    lblerro.Text = conecta.mensagem;
            }

            private void tabCadastrar_Click(object sender, EventArgs e)
            {

            }

            private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }