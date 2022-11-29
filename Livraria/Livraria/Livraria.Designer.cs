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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.bntAddGenero = new System.Windows.Forms.Button();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.txtranking = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtintegrantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblerro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(67, 185);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 308);
            this.tabControl1.TabIndex = 10;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.White;
            this.tabCadastrar.Controls.Add(this.textBox1);
            this.tabCadastrar.Controls.Add(this.bntAddGenero);
            this.tabCadastrar.Controls.Add(this.cbEditora);
            this.tabCadastrar.Controls.Add(this.txtranking);
            this.tabCadastrar.Controls.Add(this.label6);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtintegrantes);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 26);
            this.tabCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Size = new System.Drawing.Size(751, 278);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // bntAddGenero
            // 
            this.bntAddGenero.FlatAppearance.BorderSize = 0;
            this.bntAddGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // cbEditora
            // 
            this.cbEditora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEditora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(154, 54);
            this.cbEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(560, 29);
            this.cbEditora.TabIndex = 10;
            this.cbEditora.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // txtranking
            // 
            this.txtranking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtranking.Location = new System.Drawing.Point(154, 151);
            this.txtranking.Name = "txtranking";
            this.txtranking.Size = new System.Drawing.Size(560, 27);
            this.txtranking.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(18, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ranking:";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(332, 200);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(153, 56);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "Confirmar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            // 
            // txtintegrantes
            // 
            this.txtintegrantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtintegrantes.Location = new System.Drawing.Point(154, 105);
            this.txtintegrantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtintegrantes.Name = "txtintegrantes";
            this.txtintegrantes.Size = new System.Drawing.Size(560, 27);
            this.txtintegrantes.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Integrantes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Editora:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
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
            this.tabBuscar.Location = new System.Drawing.Point(4, 26);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(751, 278);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.btnRemoveBanda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Banda:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusca.Location = new System.Drawing.Point(95, 11);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(304, 27);
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
            this.tabAlterar.Location = new System.Drawing.Point(4, 26);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Size = new System.Drawing.Size(751, 278);
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
            this.txtAlteraRanking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraRanking.Location = new System.Drawing.Point(149, 166);
            this.txtAlteraRanking.Name = "txtAlteraRanking";
            this.txtAlteraRanking.Size = new System.Drawing.Size(560, 27);
            this.txtAlteraRanking.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ranking:";
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.txtAlteraIntegrantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlteraIntegrantes.Location = new System.Drawing.Point(149, 120);
            this.txtAlteraIntegrantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraIntegrantes.Name = "txtAlteraIntegrantes";
            this.txtAlteraIntegrantes.Size = new System.Drawing.Size(560, 27);
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
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Integrantes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(12, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(12, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
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
            // lblerro
            // 
            this.lblerro.AutoSize = true;
            this.lblerro.Location = new System.Drawing.Point(304, 518);
            this.lblerro.Name = "lblerro";
            this.lblerro.Size = new System.Drawing.Size(12, 15);
            this.lblerro.TabIndex = 12;
            this.lblerro.Text = "*";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(154, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 27);
            this.textBox1.TabIndex = 16;
            // 
            // Livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 559);
            this.Controls.Add(this.lblerro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Livraria";
            this.Text = "Livraria";
            this.Load += new System.EventHandler(this.Livraria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCadastrar;
        private Button bntAddGenero;
        private ComboBox cbEditora;
        private TextBox txtranking;
        private Label label6;
        private Button BtnConfirmaCadastro;
        private TextBox txtintegrantes;
        private Label label3;
        private Label label2;
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
        private TextBox textBox1;
    }
}