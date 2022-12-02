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
                b.Editora = Convert.ToInt32(cbeditora.SelectedValue.ToString());
                b.DataLancamento = txtdata.Text;
                b.PrecoCusto = txtprecoCusto.Text;
                b.PrecoVenda = txtprecoVenda.Text;
                b.QtdEstoque = txtqtd.Text;
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
    }
}