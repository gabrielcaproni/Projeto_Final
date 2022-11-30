using System.Data;

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
            cbEditora.DataSource = tabelaDados;
            cbEditora.DisplayMember = "nome";
            cbEditora.ValueMember = "codEditora";
            // preenchendo cbAlteraGenero
            // cbAlteraGenero.DataSource = tabelaDados;
            // cbAlteraGenero.DisplayMember = "genero";
            // cbAlteraGenero.ValueMember = "idgenero";
            //
            lblerro.Text = con.mensagem;
            cbEditora.Text = "";
            //cbAlteraGenero.Text = "";
        }
        void listaProduto()
        {
            ConectaBanco con = new ConectaBanco();
            dgProdutos.DataSource = con.lista_produto();
        }


        private void Livraria_Load_1(object sender, EventArgs e)
        {
            listaEditora();
            listaProduto();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            
                Livro b = new Livro();
                b.Nome = txtlivro.Text;
                b.Editora = Convert.ToInt32(cbEditora.SelectedValue.ToString());
                b.DataLancamento = txtdata.Text;
                b.PrecoVenda = txtpreco.Text;

                // Enviar para o banco

                ConectaBanco conecta = new ConectaBanco();
                bool retorno = conecta.insereProduto(b);
                if (retorno == true)
                {
                    MessageBox.Show("Dados inseridos com sucesso !");
                }
                else
                    lblerro.Text = conecta.mensagem;

                
       
        
        }

    }
}