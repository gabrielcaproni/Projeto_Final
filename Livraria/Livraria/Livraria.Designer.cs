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
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntAddGenero = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtnomeEditora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblerro = new System.Windows.Forms.Label();
            this.txtCadastroEditora = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.cbeditora = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveBanda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Editora.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editora
            // 
            this.Editora.Controls.Add(this.tabCadastrar);
            this.Editora.Controls.Add(this.tabPage1);
            this.Editora.Controls.Add(this.tabPage2);
            this.Editora.Controls.Add(this.tabBuscar);
            this.Editora.Controls.Add(this.tabAlterar);
            this.Editora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Editora.Location = new System.Drawing.Point(0, 190);
            this.Editora.Margin = new System.Windows.Forms.Padding(4);
            this.Editora.Name = "Editora";
            this.Editora.SelectedIndex = 0;
            this.Editora.Size = new System.Drawing.Size(626, 362);
            this.Editora.TabIndex = 10;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.White;
            this.tabCadastrar.Controls.Add(this.panel2);
            this.tabCadastrar.Controls.Add(this.bntAddGenero);
            this.tabCadastrar.Controls.Add(this.panel3);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 25);
            this.tabCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Size = new System.Drawing.Size(618, 333);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastro Cliente";
            this.tabCadastrar.Click += new System.EventHandler(this.tabCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(625, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 337);
            this.panel2.TabIndex = 13;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.txtdata);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.BtnConfirmaCadastro);
            this.panel3.Controls.Add(this.txtcidade);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtcep);
            this.panel3.Controls.Add(this.txtbairro);
            this.panel3.Controls.Add(this.txtEditora);
            this.panel3.Controls.Add(this.txtcliente);
            this.panel3.Controls.Add(this.txtuf);
            this.panel3.Controls.Add(this.txtendereco);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtpreco);
            this.panel3.Controls.Add(this.txtcpf);
            this.panel3.Location = new System.Drawing.Point(-4, -25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 362);
            this.panel3.TabIndex = 13;
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdata.Location = new System.Drawing.Point(220, 64);
            this.txtdata.Margin = new System.Windows.Forms.Padding(4);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(178, 26);
            this.txtdata.TabIndex = 27;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.Location = new System.Drawing.Point(220, 289);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(178, 26);
            this.txtemail.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 26);
            this.label12.TabIndex = 25;
            this.label12.Text = "E-Mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(30, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(30, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "CEP:";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.BackColor = System.Drawing.Color.White;
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.Black;
            this.BtnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(502, 305);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(112, 45);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "Confirmar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = false;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcidade.Location = new System.Drawing.Point(220, 225);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(178, 26);
            this.txtcidade.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bairro:";
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcep.Location = new System.Drawing.Point(220, 257);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(178, 26);
            this.txtcep.TabIndex = 21;
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbairro.Location = new System.Drawing.Point(220, 193);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(178, 26);
            this.txtbairro.TabIndex = 20;
            // 
            // txtEditora
            // 
            this.txtEditora.AutoSize = true;
            this.txtEditora.BackColor = System.Drawing.Color.White;
            this.txtEditora.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditora.ForeColor = System.Drawing.Color.Black;
            this.txtEditora.Location = new System.Drawing.Point(29, 96);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(51, 26);
            this.txtEditora.TabIndex = 7;
            this.txtEditora.Text = "CPF:";
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcliente.Location = new System.Drawing.Point(220, 29);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(178, 26);
            this.txtcliente.TabIndex = 16;
            // 
            // txtuf
            // 
            this.txtuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtuf.Location = new System.Drawing.Point(220, 129);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(178, 26);
            this.txtuf.TabIndex = 18;
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtendereco.Location = new System.Drawing.Point(220, 161);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(178, 26);
            this.txtendereco.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Nascimento:";
            // 
            // txtpreco
            // 
            this.txtpreco.AutoSize = true;
            this.txtpreco.BackColor = System.Drawing.Color.White;
            this.txtpreco.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpreco.ForeColor = System.Drawing.Color.Black;
            this.txtpreco.Location = new System.Drawing.Point(29, 161);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 26);
            this.txtpreco.TabIndex = 13;
            this.txtpreco.Text = "Endereço:";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcpf.Location = new System.Drawing.Point(220, 96);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(178, 26);
            this.txtcpf.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Blue;
            this.tabPage1.Controls.Add(this.txtnomeEditora);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblerro);
            this.tabPage1.Controls.Add(this.txtCadastroEditora);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(618, 333);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Cadastro Editora";
            // 
            // txtnomeEditora
            // 
            this.txtnomeEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnomeEditora.Location = new System.Drawing.Point(244, 102);
            this.txtnomeEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtnomeEditora.Name = "txtnomeEditora";
            this.txtnomeEditora.Size = new System.Drawing.Size(178, 26);
            this.txtnomeEditora.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(503, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirmar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.txtCadastroEditora.BackColor = System.Drawing.Color.White;
            this.txtCadastroEditora.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCadastroEditora.ForeColor = System.Drawing.Color.Black;
            this.txtCadastroEditora.Location = new System.Drawing.Point(63, 102);
            this.txtCadastroEditora.Name = "txtCadastroEditora";
            this.txtCadastroEditora.Size = new System.Drawing.Size(138, 26);
            this.txtCadastroEditora.TabIndex = 0;
            this.txtCadastroEditora.Text = "Nome Editora:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Blue;
            this.tabPage2.Controls.Add(this.dgClientes);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.cbcliente);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(618, 333);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Busca Cliente";
            // 
            // dgClientes
            // 
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(8, 66);
            this.dgClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 29;
            this.dgClientes.Size = new System.Drawing.Size(571, 218);
            this.dgClientes.TabIndex = 20;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(488, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 41);
            this.button3.TabIndex = 19;
            this.button3.Text = "Alterar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(358, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "Remover";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cbcliente
            // 
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(122, 11);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(187, 24);
            this.cbcliente.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(8, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 26);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cliente:";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Blue;
            this.tabBuscar.Controls.Add(this.cbeditora);
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.btnRemoveBanda);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.dgProdutos);
            this.tabBuscar.Location = new System.Drawing.Point(4, 25);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(618, 333);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Busca Editora";
            // 
            // cbeditora
            // 
            this.cbeditora.FormattingEnabled = true;
            this.cbeditora.Location = new System.Drawing.Point(122, 11);
            this.cbeditora.Name = "cbeditora";
            this.cbeditora.Size = new System.Drawing.Size(187, 24);
            this.cbeditora.TabIndex = 16;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(488, 8);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 41);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnRemoveBanda
            // 
            this.btnRemoveBanda.BackColor = System.Drawing.Color.White;
            this.btnRemoveBanda.FlatAppearance.BorderSize = 0;
            this.btnRemoveBanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBanda.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveBanda.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveBanda.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveBanda.Image")));
            this.btnRemoveBanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBanda.Location = new System.Drawing.Point(358, 8);
            this.btnRemoveBanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveBanda.Name = "btnRemoveBanda";
            this.btnRemoveBanda.Size = new System.Drawing.Size(122, 41);
            this.btnRemoveBanda.TabIndex = 14;
            this.btnRemoveBanda.Text = "Remover";
            this.btnRemoveBanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBanda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveBanda.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Editora:";
            // 
            // dgProdutos
            // 
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(8, 66);
            this.dgProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersWidth = 51;
            this.dgProdutos.RowTemplate.Height = 29;
            this.dgProdutos.Size = new System.Drawing.Size(571, 218);
            this.dgProdutos.TabIndex = 0;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
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
            this.tabAlterar.Size = new System.Drawing.Size(618, 333);
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
            this.pictureBox1.Location = new System.Drawing.Point(30, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 132);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 215);
            this.panel1.TabIndex = 12;
            // 
            // Livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(704, 555);
            this.Controls.Add(this.Editora);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Livraria";
            this.Text = "Livraria";
            this.Load += new System.EventHandler(this.Livraria_Load_1);
            this.Editora.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Editora;
        private TabPage tabCadastrar;
        private Button bntAddGenero;
        private TextBox txtendereco;
        private Label txtpreco;
        private Button BtnConfirmaCadastro;
        private TextBox txtcpf;
        private Label label3;
        private Label txtEditora;
        private Label label4;
        private TabPage tabBuscar;
        private Button btnAlterar;
        private Button btnRemoveBanda;
        private Label label5;
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
        private TextBox txtcliente;
        private TabPage tabPage1;
        private Label txtCadastroEditora;
        private Button button1;
        private TextBox txtuf;
        private Label label1;
        private TextBox txtbairro;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label11;
        private Label label6;
        private TextBox txtcidade;
        private TextBox txtcep;
        private TextBox txtemail;
        private Label label12;
        private TextBox txtdata;
        private TextBox txtnomeEditora;
        private ComboBox cbeditora;
        private TabPage tabPage2;
        private DataGridView dgClientes;
        private Button button3;
        private Button button2;
        private ComboBox cbcliente;
        private Label label13;
    }
}