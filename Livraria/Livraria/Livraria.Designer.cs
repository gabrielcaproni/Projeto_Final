namespace Livraria
{
    partial class Livraria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livraria));
            this.Editora = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnomeEditora = new System.Windows.Forms.TextBox();
            this.lblerro = new System.Windows.Forms.Label();
            this.txtCadastroEditora = new System.Windows.Forms.Label();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecoCusto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlivro = new System.Windows.Forms.TextBox();
            this.bntAddGenero = new System.Windows.Forms.Button();
            this.cbeditora = new System.Windows.Forms.ComboBox();
            this.txtprecoVenda = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveBanda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.cbAlteraGenero = new System.Windows.Forms.ComboBox();
            this.txtAlteraRanking = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.txtAlteraIntegrantes = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Editora.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Editora
            // 
            this.Editora.Controls.Add(this.tabPage1);
            this.Editora.Controls.Add(this.tabCadastrar);
            this.Editora.Controls.Add(this.tabBuscar);
            this.Editora.Controls.Add(this.tabAlterar);
            this.Editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editora.Location = new System.Drawing.Point(67, 184);
            this.Editora.Margin = new System.Windows.Forms.Padding(4);
            this.Editora.Name = "Editora";
            this.Editora.SelectedIndex = 0;
            this.Editora.Size = new System.Drawing.Size(809, 362);
            this.Editora.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtnomeEditora);
            this.tabPage1.Controls.Add(this.lblerro);
            this.tabPage1.Controls.Add(this.txtCadastroEditora);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(801, 333);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Cadastro Editora";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(244, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 56);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirmar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnomeEditora
            // 
            this.txtnomeEditora.Location = new System.Drawing.Point(162, 102);
            this.txtnomeEditora.Name = "txtnomeEditora";
            this.txtnomeEditora.Size = new System.Drawing.Size(291, 22);
            this.txtnomeEditora.TabIndex = 13;
            this.txtnomeEditora.TextChanged += new System.EventHandler(this.txtnomeEditora_TextChanged);
            // 
            // lblerro
            // 
            this.lblerro.AutoSize = true;
            this.lblerro.Location = new System.Drawing.Point(228, 272);
            this.lblerro.Name = "lblerro";
            this.lblerro.Size = new System.Drawing.Size(12, 16);
            this.lblerro.TabIndex = 12;
            this.lblerro.Text = "*";
            // 
            // txtCadastroEditora
            // 
            this.txtCadastroEditora.AutoSize = true;
            this.txtCadastroEditora.Location = new System.Drawing.Point(63, 102);
            this.txtCadastroEditora.Name = "txtCadastroEditora";
            this.txtCadastroEditora.Size = new System.Drawing.Size(93, 16);
            this.txtCadastroEditora.TabIndex = 0;
            this.txtCadastroEditora.Text = "Nome Editora:";
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.White;
            this.tabCadastrar.Controls.Add(this.txtqtd);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.txtprecoCusto);
            this.tabCadastrar.Controls.Add(this.label1);
            this.tabCadastrar.Controls.Add(this.txtlivro);
            this.tabCadastrar.Controls.Add(this.bntAddGenero);
            this.tabCadastrar.Controls.Add(this.cbeditora);
            this.tabCadastrar.Controls.Add(this.txtprecoVenda);
            this.tabCadastrar.Controls.Add(this.txtpreco);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtdata);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.txtEditora);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 25);
            this.tabCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Size = new System.Drawing.Size(801, 333);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastro Produto";
            // 
            // txtqtd
            // 
            this.txtqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtqtd.Location = new System.Drawing.Point(216, 246);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(560, 26);
            this.txtqtd.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(18, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quantidade Estoque:";
            // 
            // txtprecoCusto
            // 
            this.txtprecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtprecoCusto.Location = new System.Drawing.Point(216, 155);
            this.txtprecoCusto.Name = "txtprecoCusto";
            this.txtprecoCusto.Size = new System.Drawing.Size(560, 26);
            this.txtprecoCusto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Preço Custo:";
            // 
            // txtlivro
            // 
            this.txtlivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtlivro.Location = new System.Drawing.Point(216, 12);
            this.txtlivro.Margin = new System.Windows.Forms.Padding(4);
            this.txtlivro.Name = "txtlivro";
            this.txtlivro.Size = new System.Drawing.Size(560, 26);
            this.txtlivro.TabIndex = 16;
            // 
            // bntAddGenero
            // 
            this.bntAddGenero.FlatAppearance.BorderSize = 0;
            this.bntAddGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntAddGenero.ForeColor = System.Drawing.Color.DimGray;
            this.bntAddGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddGenero.Location = new System.Drawing.Point(719, 61);
            this.bntAddGenero.Margin = new System.Windows.Forms.Padding(4);
            this.bntAddGenero.Name = "bntAddGenero";
            this.bntAddGenero.Size = new System.Drawing.Size(30, 22);
            this.bntAddGenero.TabIndex = 15;
            this.bntAddGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAddGenero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntAddGenero.UseVisualStyleBackColor = true;
            // 
            // cbeditora
            // 
            this.cbeditora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbeditora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbeditora.FormattingEnabled = true;
            this.cbeditora.Location = new System.Drawing.Point(216, 59);
            this.cbeditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbeditora.Name = "cbeditora";
            this.cbeditora.Size = new System.Drawing.Size(560, 29);
            this.cbeditora.TabIndex = 10;
            // 
            // txtprecoVenda
            // 
            this.txtprecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtprecoVenda.Location = new System.Drawing.Point(216, 206);
            this.txtprecoVenda.Name = "txtprecoVenda";
            this.txtprecoVenda.Size = new System.Drawing.Size(560, 26);
            this.txtprecoVenda.TabIndex = 12;
            // 
            // txtpreco
            // 
            this.txtpreco.AutoSize = true;
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpreco.ForeColor = System.Drawing.Color.Gray;
            this.txtpreco.Location = new System.Drawing.Point(18, 212);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(105, 20);
            this.txtpreco.TabIndex = 13;
            this.txtpreco.Text = "Preço Venda:";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(385, 279);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(153, 45);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "Confirmar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdata.Location = new System.Drawing.Point(216, 105);
            this.txtdata.Margin = new System.Windows.Forms.Padding(4);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(560, 26);
            this.txtdata.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Lançamento:";
            // 
            // txtEditora
            // 
            this.txtEditora.AutoSize = true;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditora.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora.Location = new System.Drawing.Point(18, 67);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(64, 20);
            this.txtEditora.TabIndex = 7;
            this.txtEditora.Text = "Editora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Produto:";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.White;
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.btnRemoveBanda);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.txtBusca);
            this.tabBuscar.Controls.Add(this.dgProdutos);
            this.tabBuscar.Location = new System.Drawing.Point(4, 25);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(801, 333);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(553, 6);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 32);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBanda
            // 
            this.btnRemoveBanda.FlatAppearance.BorderSize = 0;
            this.btnRemoveBanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveBanda.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveBanda.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveBanda.Image")));
            this.btnRemoveBanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBanda.Location = new System.Drawing.Point(424, 6);
            this.btnRemoveBanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveBanda.Name = "btnRemoveBanda";
            this.btnRemoveBanda.Size = new System.Drawing.Size(122, 32);
            this.btnRemoveBanda.TabIndex = 14;
            this.btnRemoveBanda.Text = "Remover";
            this.btnRemoveBanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveBanda.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Banda:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusca.Location = new System.Drawing.Point(95, 11);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(304, 26);
            this.txtBusca.TabIndex = 1;
            // 
            // dgProdutos
            // 
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(31, 40);
            this.dgProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersWidth = 51;
            this.dgProdutos.RowTemplate.Height = 29;
            this.dgProdutos.Size = new System.Drawing.Size(697, 218);
            this.dgProdutos.TabIndex = 0;
            // 
            // tabAlterar
            // 
            this.tabAlterar.Controls.Add(this.cbAlteraGenero);
            this.tabAlterar.Controls.Add(this.txtAlteraRanking);
            this.tabAlterar.Controls.Add(this.label7);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Controls.Add(this.txtAlteraIntegrantes);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.label8);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Location = new System.Drawing.Point(4, 25);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Size = new System.Drawing.Size(801, 333);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.UseVisualStyleBackColor = true;
            // 
            // cbAlteraGenero
            // 
            this.cbAlteraGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbAlteraGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlteraGenero.FormattingEnabled = true;
            this.cbAlteraGenero.Location = new System.Drawing.Point(149, 70);
            this.cbAlteraGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAlteraGenero.Name = "cbAlteraGenero";
            this.cbAlteraGenero.Size = new System.Drawing.Size(560, 29);
            this.cbAlteraGenero.TabIndex = 23;
            // 
            // txtAlteraRanking
            // 
            this.txtAlteraRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraRanking.Location = new System.Drawing.Point(149, 166);
            this.txtAlteraRanking.Name = "txtAlteraRanking";
            this.txtAlteraRanking.Size = new System.Drawing.Size(560, 26);
            this.txtAlteraRanking.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ranking:";
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(327, 214);
            this.btnConfirmaAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(153, 56);
            this.btnConfirmaAlteracao.TabIndex = 22;
            this.btnConfirmaAlteracao.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            // 
            // txtAlteraIntegrantes
            // 
            this.txtAlteraIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraIntegrantes.Location = new System.Drawing.Point(149, 120);
            this.txtAlteraIntegrantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraIntegrantes.Name = "txtAlteraIntegrantes";
            this.txtAlteraIntegrantes.Size = new System.Drawing.Size(560, 26);
            this.txtAlteraIntegrantes.TabIndex = 19;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraNome.Location = new System.Drawing.Point(149, 26);
            this.txtAlteraNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(560, 29);
            this.txtAlteraNome.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Integrantes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(12, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(12, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 136);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Editora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Livraria";
            this.Text = "Livraria";
            this.Load += new System.EventHandler(this.Livraria_Load_1);
            this.Editora.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Editora;
        private TabPage tabCadastrar;
        private Button bntAddGenero;
        private ComboBox cbeditora;
        private TextBox txtprecoVenda;
        private Label txtpreco;
        private Button BtnConfirmaCadastro;
        private TextBox txtdata;
        private Label label3;
        private Label txtEditora;
        private Label label4;
        private TabPage tabBuscar;
        private Button btnAlterar;
        private Button btnRemoveBanda;
        private Label label5;
        private TextBox txtBusca;
        private DataGridView dgProdutos;
        private TabPage tabAlterar;
        private ComboBox cbAlteraGenero;
        private TextBox txtAlteraRanking;
        private Label label7;
        private Button btnConfirmaAlteracao;
        private TextBox txtAlteraIntegrantes;
        private TextBox txtAlteraNome;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Label lblerro;
        private TextBox txtlivro;
        private TabPage tabPage1;
        private Label txtCadastroEditora;
        private TextBox txtnomeEditora;
        private Button button1;
        private TextBox txtprecoCusto;
        private Label label1;
        private TextBox txtqtd;
        private Label label2;
    }
}