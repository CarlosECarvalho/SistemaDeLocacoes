namespace SistemaDeLocacoes
{
    partial class Empresas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_RazaoSocial = new Label();
            lb_NomeFantasia = new Label();
            lb_CNPJ_CPF = new Label();
            lb_Endereco = new Label();
            lb_DescricaoEndereco = new Label();
            lb_CEP = new Label();
            lb_Tel1 = new Label();
            lb_Tel2 = new Label();
            lb_Email = new Label();
            lb_PessoaRecado = new Label();
            tx_RazaoSocial = new TextBox();
            tx_NomeFantasia = new TextBox();
            tx_Endereco = new TextBox();
            mk_CPF_CNPJ = new MaskedTextBox();
            mk_CEP = new MaskedTextBox();
            mk_Tel1 = new MaskedTextBox();
            mk_Tel2 = new MaskedTextBox();
            mk_Email = new MaskedTextBox();
            dg_EnderecosCliente = new DataGridView();
            OptPessoaF = new RadioButton();
            OptPessoaJ = new RadioButton();
            bt_Novo = new Button();
            bt_Editar = new Button();
            bt_Salvar = new Button();
            bt_Inativar = new Button();
            cmb_Descricao = new ComboBox();
            chk_Cliente = new CheckBox();
            chk_Fornecedor = new CheckBox();
            chk_Transportadora = new CheckBox();
            tx_Categoria = new TextBox();
            lb_Categoria = new Label();
            cmb_Situacao = new ComboBox();
            lb_Situacao = new Label();
            lb_Num = new Label();
            lb_Bairro = new Label();
            lb_Cidade = new Label();
            lb_Estado = new Label();
            lb_Pais = new Label();
            tx_Num = new TextBox();
            tx_Bairro = new TextBox();
            tx_Cidade = new TextBox();
            tx_Pais = new TextBox();
            cmb_Estado = new ComboBox();
            gb_Contatos = new GroupBox();
            tx_Pessoa = new TextBox();
            gb_Endereco = new GroupBox();
            mk_DataAlteracao = new MaskedTextBox();
            lb_DtAlteracao = new Label();
            lb_Cod = new Label();
            tx_Cod = new TextBox();
            bt_ListarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_EnderecosCliente).BeginInit();
            gb_Contatos.SuspendLayout();
            gb_Endereco.SuspendLayout();
            SuspendLayout();
            // 
            // lb_RazaoSocial
            // 
            lb_RazaoSocial.AutoSize = true;
            lb_RazaoSocial.Location = new Point(322, 3);
            lb_RazaoSocial.Name = "lb_RazaoSocial";
            lb_RazaoSocial.Size = new Size(75, 15);
            lb_RazaoSocial.TabIndex = 0;
            lb_RazaoSocial.Text = "Razão Social:";
            // 
            // lb_NomeFantasia
            // 
            lb_NomeFantasia.AutoSize = true;
            lb_NomeFantasia.Location = new Point(322, 43);
            lb_NomeFantasia.Name = "lb_NomeFantasia";
            lb_NomeFantasia.Size = new Size(89, 15);
            lb_NomeFantasia.TabIndex = 1;
            lb_NomeFantasia.Text = "Nome Fantasia:";
            // 
            // lb_CNPJ_CPF
            // 
            lb_CNPJ_CPF.AutoSize = true;
            lb_CNPJ_CPF.Location = new Point(111, 3);
            lb_CNPJ_CPF.Name = "lb_CNPJ_CPF";
            lb_CNPJ_CPF.Size = new Size(37, 15);
            lb_CNPJ_CPF.TabIndex = 2;
            lb_CNPJ_CPF.Text = "CNPJ:";
            // 
            // lb_Endereco
            // 
            lb_Endereco.AutoSize = true;
            lb_Endereco.Location = new Point(85, 18);
            lb_Endereco.Name = "lb_Endereco";
            lb_Endereco.Size = new Size(62, 15);
            lb_Endereco.TabIndex = 3;
            lb_Endereco.Text = "Endereço :";
            // 
            // lb_DescricaoEndereco
            // 
            lb_DescricaoEndereco.AutoSize = true;
            lb_DescricaoEndereco.Location = new Point(620, 69);
            lb_DescricaoEndereco.Name = "lb_DescricaoEndereco";
            lb_DescricaoEndereco.Size = new Size(113, 15);
            lb_DescricaoEndereco.TabIndex = 4;
            lb_DescricaoEndereco.Text = "Descrição Endereço:";
            // 
            // lb_CEP
            // 
            lb_CEP.AutoSize = true;
            lb_CEP.Location = new Point(9, 18);
            lb_CEP.Name = "lb_CEP";
            lb_CEP.Size = new Size(31, 15);
            lb_CEP.TabIndex = 6;
            lb_CEP.Text = "CEP:";
            // 
            // lb_Tel1
            // 
            lb_Tel1.AutoSize = true;
            lb_Tel1.Location = new Point(2, 15);
            lb_Tel1.Name = "lb_Tel1";
            lb_Tel1.Size = new Size(33, 15);
            lb_Tel1.TabIndex = 7;
            lb_Tel1.Text = "Tel 1:";
            // 
            // lb_Tel2
            // 
            lb_Tel2.AutoSize = true;
            lb_Tel2.Location = new Point(95, 14);
            lb_Tel2.Name = "lb_Tel2";
            lb_Tel2.Size = new Size(33, 15);
            lb_Tel2.TabIndex = 8;
            lb_Tel2.Text = "Tel 2:";
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Location = new Point(191, 15);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(39, 15);
            lb_Email.TabIndex = 9;
            lb_Email.Text = "Email:";
            // 
            // lb_PessoaRecado
            // 
            lb_PessoaRecado.AutoSize = true;
            lb_PessoaRecado.Location = new Point(428, 14);
            lb_PessoaRecado.Name = "lb_PessoaRecado";
            lb_PessoaRecado.Size = new Size(111, 15);
            lb_PessoaRecado.TabIndex = 10;
            lb_PessoaRecado.Text = "Pessoa para recado:";
            // 
            // tx_RazaoSocial
            // 
            tx_RazaoSocial.Location = new Point(324, 17);
            tx_RazaoSocial.Name = "tx_RazaoSocial";
            tx_RazaoSocial.Size = new Size(648, 23);
            tx_RazaoSocial.TabIndex = 12;
            // 
            // tx_NomeFantasia
            // 
            tx_NomeFantasia.Location = new Point(324, 58);
            tx_NomeFantasia.Name = "tx_NomeFantasia";
            tx_NomeFantasia.Size = new Size(648, 23);
            tx_NomeFantasia.TabIndex = 13;
            // 
            // tx_Endereco
            // 
            tx_Endereco.Location = new Point(86, 33);
            tx_Endereco.Name = "tx_Endereco";
            tx_Endereco.Size = new Size(289, 23);
            tx_Endereco.TabIndex = 14;
            // 
            // mk_CPF_CNPJ
            // 
            mk_CPF_CNPJ.Location = new Point(114, 17);
            mk_CPF_CNPJ.Name = "mk_CPF_CNPJ";
            mk_CPF_CNPJ.Size = new Size(131, 23);
            mk_CPF_CNPJ.TabIndex = 15;
            mk_CPF_CNPJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // mk_CEP
            // 
            mk_CEP.Location = new Point(10, 33);
            mk_CEP.Mask = "00000-9999";
            mk_CEP.Name = "mk_CEP";
            mk_CEP.Size = new Size(72, 23);
            mk_CEP.TabIndex = 17;
            // 
            // mk_Tel1
            // 
            mk_Tel1.Location = new Point(5, 30);
            mk_Tel1.Mask = "(99)00000-0000";
            mk_Tel1.Name = "mk_Tel1";
            mk_Tel1.Size = new Size(90, 23);
            mk_Tel1.TabIndex = 18;
            // 
            // mk_Tel2
            // 
            mk_Tel2.Location = new Point(98, 29);
            mk_Tel2.Mask = "(99)00000-0000";
            mk_Tel2.Name = "mk_Tel2";
            mk_Tel2.Size = new Size(90, 23);
            mk_Tel2.TabIndex = 19;
            // 
            // mk_Email
            // 
            mk_Email.Location = new Point(194, 30);
            mk_Email.Name = "mk_Email";
            mk_Email.Size = new Size(230, 23);
            mk_Email.TabIndex = 20;
            // 
            // dg_EnderecosCliente
            // 
            dg_EnderecosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_EnderecosCliente.Location = new Point(14, 235);
            dg_EnderecosCliente.Margin = new Padding(0);
            dg_EnderecosCliente.Name = "dg_EnderecosCliente";
            dg_EnderecosCliente.Size = new Size(958, 317);
            dg_EnderecosCliente.TabIndex = 0;
            dg_EnderecosCliente.TabStop = false;
            dg_EnderecosCliente.Text = "Endereços de Entrega";
            // 
            // OptPessoaF
            // 
            OptPessoaF.AutoSize = true;
            OptPessoaF.Location = new Point(10, 4);
            OptPessoaF.Name = "OptPessoaF";
            OptPessoaF.Size = new Size(93, 19);
            OptPessoaF.TabIndex = 23;
            OptPessoaF.TabStop = true;
            OptPessoaF.Text = "Pessoa Física";
            OptPessoaF.UseVisualStyleBackColor = true;
            OptPessoaF.CheckedChanged += OptPessoaF_Click;
            // 
            // OptPessoaJ
            // 
            OptPessoaJ.AutoSize = true;
            OptPessoaJ.Location = new Point(10, 21);
            OptPessoaJ.Name = "OptPessoaJ";
            OptPessoaJ.Size = new Size(104, 19);
            OptPessoaJ.TabIndex = 24;
            OptPessoaJ.TabStop = true;
            OptPessoaJ.Text = "Pessoa Jurídica";
            OptPessoaJ.UseVisualStyleBackColor = true;
            OptPessoaJ.CheckedChanged += OptPessoaJ_Click;
            // 
            // bt_Novo
            // 
            bt_Novo.Location = new Point(607, 203);
            bt_Novo.Name = "bt_Novo";
            bt_Novo.Size = new Size(89, 29);
            bt_Novo.TabIndex = 25;
            bt_Novo.Text = "Novo";
            bt_Novo.UseVisualStyleBackColor = true;
            // 
            // bt_Editar
            // 
            bt_Editar.Location = new Point(794, 203);
            bt_Editar.Name = "bt_Editar";
            bt_Editar.Size = new Size(86, 28);
            bt_Editar.TabIndex = 26;
            bt_Editar.Text = "Editar";
            bt_Editar.UseVisualStyleBackColor = true;
            // 
            // bt_Salvar
            // 
            bt_Salvar.Location = new Point(886, 202);
            bt_Salvar.Name = "bt_Salvar";
            bt_Salvar.Size = new Size(86, 29);
            bt_Salvar.TabIndex = 27;
            bt_Salvar.Text = "Salvar";
            bt_Salvar.UseVisualStyleBackColor = true;
            // 
            // bt_Inativar
            // 
            bt_Inativar.Location = new Point(702, 203);
            bt_Inativar.Name = "bt_Inativar";
            bt_Inativar.Size = new Size(86, 29);
            bt_Inativar.TabIndex = 28;
            bt_Inativar.Text = "Inativar";
            bt_Inativar.UseVisualStyleBackColor = true;
            // 
            // cmb_Descricao
            // 
            cmb_Descricao.FormattingEnabled = true;
            cmb_Descricao.Location = new Point(623, 86);
            cmb_Descricao.Name = "cmb_Descricao";
            cmb_Descricao.Size = new Size(132, 23);
            cmb_Descricao.TabIndex = 29;
            // 
            // chk_Cliente
            // 
            chk_Cliente.AutoSize = true;
            chk_Cliente.BackColor = Color.Transparent;
            chk_Cliente.Location = new Point(851, 63);
            chk_Cliente.Margin = new Padding(0);
            chk_Cliente.Name = "chk_Cliente";
            chk_Cliente.Size = new Size(63, 19);
            chk_Cliente.TabIndex = 30;
            chk_Cliente.Text = "Cliente";
            chk_Cliente.UseVisualStyleBackColor = false;
            // 
            // chk_Fornecedor
            // 
            chk_Fornecedor.AutoSize = true;
            chk_Fornecedor.Location = new Point(851, 79);
            chk_Fornecedor.Name = "chk_Fornecedor";
            chk_Fornecedor.Size = new Size(86, 19);
            chk_Fornecedor.TabIndex = 31;
            chk_Fornecedor.Text = "Fornecedor";
            chk_Fornecedor.UseVisualStyleBackColor = true;
            // 
            // chk_Transportadora
            // 
            chk_Transportadora.AutoSize = true;
            chk_Transportadora.Location = new Point(851, 95);
            chk_Transportadora.Name = "chk_Transportadora";
            chk_Transportadora.Size = new Size(105, 19);
            chk_Transportadora.TabIndex = 32;
            chk_Transportadora.Text = "Transportadora";
            chk_Transportadora.UseVisualStyleBackColor = true;
            // 
            // tx_Categoria
            // 
            tx_Categoria.Location = new Point(11, 58);
            tx_Categoria.Name = "tx_Categoria";
            tx_Categoria.Size = new Size(117, 23);
            tx_Categoria.TabIndex = 33;
            // 
            // lb_Categoria
            // 
            lb_Categoria.AutoSize = true;
            lb_Categoria.Location = new Point(10, 43);
            lb_Categoria.Name = "lb_Categoria";
            lb_Categoria.Size = new Size(61, 15);
            lb_Categoria.TabIndex = 34;
            lb_Categoria.Text = "Categoria:";
            // 
            // cmb_Situacao
            // 
            cmb_Situacao.FormattingEnabled = true;
            cmb_Situacao.Items.AddRange(new object[] { "ATIVO", "INATIVO" });
            cmb_Situacao.Location = new Point(763, 86);
            cmb_Situacao.Name = "cmb_Situacao";
            cmb_Situacao.Size = new Size(78, 23);
            cmb_Situacao.TabIndex = 35;
            // 
            // lb_Situacao
            // 
            lb_Situacao.AutoSize = true;
            lb_Situacao.Location = new Point(763, 70);
            lb_Situacao.Name = "lb_Situacao";
            lb_Situacao.Size = new Size(55, 15);
            lb_Situacao.TabIndex = 36;
            lb_Situacao.Text = "Situação:";
            // 
            // lb_Num
            // 
            lb_Num.AutoSize = true;
            lb_Num.Location = new Point(378, 17);
            lb_Num.Name = "lb_Num";
            lb_Num.Size = new Size(37, 15);
            lb_Num.TabIndex = 37;
            lb_Num.Text = "Num:";
            // 
            // lb_Bairro
            // 
            lb_Bairro.AutoSize = true;
            lb_Bairro.Location = new Point(432, 17);
            lb_Bairro.Name = "lb_Bairro";
            lb_Bairro.Size = new Size(41, 15);
            lb_Bairro.TabIndex = 38;
            lb_Bairro.Text = "Bairro:";
            // 
            // lb_Cidade
            // 
            lb_Cidade.AutoSize = true;
            lb_Cidade.Location = new Point(542, 17);
            lb_Cidade.Name = "lb_Cidade";
            lb_Cidade.Size = new Size(47, 15);
            lb_Cidade.TabIndex = 39;
            lb_Cidade.Text = "Cidade:";
            // 
            // lb_Estado
            // 
            lb_Estado.AutoSize = true;
            lb_Estado.Location = new Point(693, 17);
            lb_Estado.Name = "lb_Estado";
            lb_Estado.Size = new Size(45, 15);
            lb_Estado.TabIndex = 40;
            lb_Estado.Text = "Estado:";
            // 
            // lb_Pais
            // 
            lb_Pais.AutoSize = true;
            lb_Pais.Location = new Point(758, 17);
            lb_Pais.Name = "lb_Pais";
            lb_Pais.Size = new Size(31, 15);
            lb_Pais.TabIndex = 41;
            lb_Pais.Text = "País:";
            // 
            // tx_Num
            // 
            tx_Num.Location = new Point(380, 33);
            tx_Num.Name = "tx_Num";
            tx_Num.Size = new Size(53, 23);
            tx_Num.TabIndex = 42;
            // 
            // tx_Bairro
            // 
            tx_Bairro.Location = new Point(435, 33);
            tx_Bairro.Name = "tx_Bairro";
            tx_Bairro.Size = new Size(108, 23);
            tx_Bairro.TabIndex = 43;
            // 
            // tx_Cidade
            // 
            tx_Cidade.Location = new Point(545, 33);
            tx_Cidade.Name = "tx_Cidade";
            tx_Cidade.Size = new Size(148, 23);
            tx_Cidade.TabIndex = 44;
            // 
            // tx_Pais
            // 
            tx_Pais.Location = new Point(761, 33);
            tx_Pais.Name = "tx_Pais";
            tx_Pais.Size = new Size(105, 23);
            tx_Pais.TabIndex = 45;
            // 
            // cmb_Estado
            // 
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Location = new Point(696, 33);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(62, 23);
            cmb_Estado.TabIndex = 46;
            // 
            // gb_Contatos
            // 
            gb_Contatos.Controls.Add(tx_Pessoa);
            gb_Contatos.Controls.Add(mk_Tel1);
            gb_Contatos.Controls.Add(lb_Tel1);
            gb_Contatos.Controls.Add(lb_Tel2);
            gb_Contatos.Controls.Add(lb_Email);
            gb_Contatos.Controls.Add(lb_PessoaRecado);
            gb_Contatos.Controls.Add(mk_Tel2);
            gb_Contatos.Controls.Add(mk_Email);
            gb_Contatos.Location = new Point(5, 56);
            gb_Contatos.Name = "gb_Contatos";
            gb_Contatos.Padding = new Padding(0);
            gb_Contatos.Size = new Size(610, 57);
            gb_Contatos.TabIndex = 47;
            gb_Contatos.TabStop = false;
            gb_Contatos.Text = "Contatos:";
            // 
            // tx_Pessoa
            // 
            tx_Pessoa.Location = new Point(430, 30);
            tx_Pessoa.Name = "tx_Pessoa";
            tx_Pessoa.Size = new Size(176, 23);
            tx_Pessoa.TabIndex = 21;
            // 
            // gb_Endereco
            // 
            gb_Endereco.Controls.Add(mk_DataAlteracao);
            gb_Endereco.Controls.Add(lb_DtAlteracao);
            gb_Endereco.Controls.Add(chk_Transportadora);
            gb_Endereco.Controls.Add(chk_Fornecedor);
            gb_Endereco.Controls.Add(chk_Cliente);
            gb_Endereco.Controls.Add(gb_Contatos);
            gb_Endereco.Controls.Add(tx_Endereco);
            gb_Endereco.Controls.Add(lb_Endereco);
            gb_Endereco.Controls.Add(cmb_Estado);
            gb_Endereco.Controls.Add(cmb_Situacao);
            gb_Endereco.Controls.Add(lb_DescricaoEndereco);
            gb_Endereco.Controls.Add(lb_Situacao);
            gb_Endereco.Controls.Add(tx_Pais);
            gb_Endereco.Controls.Add(cmb_Descricao);
            gb_Endereco.Controls.Add(lb_Num);
            gb_Endereco.Controls.Add(lb_Bairro);
            gb_Endereco.Controls.Add(lb_Cidade);
            gb_Endereco.Controls.Add(tx_Cidade);
            gb_Endereco.Controls.Add(lb_Estado);
            gb_Endereco.Controls.Add(tx_Bairro);
            gb_Endereco.Controls.Add(lb_Pais);
            gb_Endereco.Controls.Add(tx_Num);
            gb_Endereco.Controls.Add(mk_CEP);
            gb_Endereco.Controls.Add(lb_CEP);
            gb_Endereco.Location = new Point(14, 83);
            gb_Endereco.Margin = new Padding(0);
            gb_Endereco.Name = "gb_Endereco";
            gb_Endereco.Padding = new Padding(0);
            gb_Endereco.Size = new Size(958, 116);
            gb_Endereco.TabIndex = 48;
            gb_Endereco.TabStop = false;
            gb_Endereco.Text = "Dados de Endereço:";
            // 
            // mk_DataAlteracao
            // 
            mk_DataAlteracao.Location = new Point(872, 33);
            mk_DataAlteracao.Mask = "00/00/0000";
            mk_DataAlteracao.Name = "mk_DataAlteracao";
            mk_DataAlteracao.Size = new Size(77, 23);
            mk_DataAlteracao.TabIndex = 49;
            mk_DataAlteracao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_DtAlteracao
            // 
            lb_DtAlteracao.AutoSize = true;
            lb_DtAlteracao.Location = new Point(872, 18);
            lb_DtAlteracao.Name = "lb_DtAlteracao";
            lb_DtAlteracao.Size = new Size(75, 15);
            lb_DtAlteracao.TabIndex = 48;
            lb_DtAlteracao.Text = "Ult Alteração";
            // 
            // lb_Cod
            // 
            lb_Cod.AutoSize = true;
            lb_Cod.Location = new Point(248, 1);
            lb_Cod.Name = "lb_Cod";
            lb_Cod.Size = new Size(32, 15);
            lb_Cod.TabIndex = 49;
            lb_Cod.Text = "Cod.";
            // 
            // tx_Cod
            // 
            tx_Cod.Location = new Point(251, 17);
            tx_Cod.Name = "tx_Cod";
            tx_Cod.Size = new Size(65, 23);
            tx_Cod.TabIndex = 50;
            // 
            // bt_ListarTodos
            // 
            bt_ListarTodos.Font = new Font("Segoe UI", 9F);
            bt_ListarTodos.Location = new Point(13, 202);
            bt_ListarTodos.Name = "bt_ListarTodos";
            bt_ListarTodos.Size = new Size(96, 28);
            bt_ListarTodos.TabIndex = 51;
            bt_ListarTodos.Text = "Listar Todos";
            bt_ListarTodos.UseVisualStyleBackColor = true;
            // 
            // Empresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(bt_ListarTodos);
            Controls.Add(tx_Cod);
            Controls.Add(lb_Cod);
            Controls.Add(gb_Endereco);
            Controls.Add(lb_Categoria);
            Controls.Add(tx_Categoria);
            Controls.Add(bt_Inativar);
            Controls.Add(bt_Salvar);
            Controls.Add(bt_Editar);
            Controls.Add(bt_Novo);
            Controls.Add(OptPessoaJ);
            Controls.Add(OptPessoaF);
            Controls.Add(dg_EnderecosCliente);
            Controls.Add(mk_CPF_CNPJ);
            Controls.Add(tx_NomeFantasia);
            Controls.Add(tx_RazaoSocial);
            Controls.Add(lb_CNPJ_CPF);
            Controls.Add(lb_NomeFantasia);
            Controls.Add(lb_RazaoSocial);
            Name = "Empresas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Empresas";
            ((System.ComponentModel.ISupportInitialize)dg_EnderecosCliente).EndInit();
            gb_Contatos.ResumeLayout(false);
            gb_Contatos.PerformLayout();
            gb_Endereco.ResumeLayout(false);
            gb_Endereco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lb_RazaoSocial;
        private Label lb_NomeFantasia;
        private Label lb_CNPJ_CPF;
        private Label lb_Endereco;
        private Label lb_DescricaoEndereco;
        private Label lb_CEP;
        private Label lb_Tel1;
        private Label lb_Tel2;
        private Label lb_Email;
        private Label lb_PessoaRecado;
        private TextBox tx_RazaoSocial;
        private TextBox tx_NomeFantasia;
        private TextBox tx_Endereco;
        private MaskedTextBox mk_CPF_CNPJ;
        private MaskedTextBox mk_CEP;
        private MaskedTextBox mk_Tel1;
        private MaskedTextBox mk_Tel2;
        private MaskedTextBox mk_Email;
        private MaskedTextBox maskedTextBox7;
        private GroupBox groupBox1;
        private DataGridView dg_EnderecosCliente;
        private RadioButton OptPessoaF;
        private RadioButton OptPessoaJ;
        private Button bt_Novo;
        private Button bt_Editar;
        private Button bt_Salvar;
        private Button bt_Inativar;
        private ComboBox cmb_Descricao;
        private CheckBox chk_Cliente;
        private CheckBox chk_Fornecedor;
        private CheckBox chk_Transportadora;
        private TextBox tx_Categoria;
        private Label lb_Categoria;
        private ComboBox cmb_Situacao;
        private Label lb_Situacao;
        private Label lb_Num;
        private Label lb_Bairro;
        private Label lb_Cidade;
        private Label lb_Estado;
        private Label lb_Pais;
        private TextBox tx_Num;
        private TextBox tx_Bairro;
        private TextBox tx_Cidade;
        private TextBox tx_Pais;
        private ComboBox cmb_Estado;
        private GroupBox gb_Contatos;
        private GroupBox gb_Endereco;
        private TextBox tx_Pessoa;
        private MaskedTextBox mk_DataAlteracao;
        private Label lb_DtAlteracao;
        private Label lb_Cod;
        private TextBox tx_Cod;
        private Button bt_ListarTodos;
    }
}