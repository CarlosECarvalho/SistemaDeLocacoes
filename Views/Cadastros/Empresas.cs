using SistemaDeLocacoes.Entidades;
using System.Windows.Forms.Design;

namespace SistemaDeLocacoes
{
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }

        public void TipoPessoa(Form empresa)
        {
            var empresas = empresa as Empresas;

            if (empresas != null)
            {
                if (string.IsNullOrEmpty(empresas.mk_CPF_CNPJ.Text))
                {
                    if (empresas.OptPessoaF.Checked)
                    {
                        mk_CPF_CNPJ.Mask = "000,000,000-00";
                        lb_CNPJ_CPF.Text = "CPF";
                    }
                    else if (empresas.OptPessoaJ.Checked)
                    {
                        mk_CPF_CNPJ.Mask = "00,000,000/0000-00";
                        lb_CNPJ_CPF.Text = "CNPJ";
                    }
                }
            }

        }
        private void Habilitar_campos(Empresas empresas, bool habilita)
        {
            var empresa = empresas as Empresas;
            if (string.IsNullOrEmpty(empresa.tx_Cod.Text) && string.IsNullOrWhiteSpace(empresa.tx_Cod.Text) && habilita == false)
            { //carregamento inicial da tela
                empresa.OptPessoaF.Enabled = habilita;
                empresa.OptPessoaJ.Enabled = habilita;
                empresa.mk_CPF_CNPJ.Enabled = habilita;
                empresa.tx_RazaoSocial.Enabled = habilita;
                empresa.tx_Categoria.Enabled = habilita;
                empresa.tx_NomeFantasia.Enabled = habilita;
                empresa.mk_CEP.Enabled = habilita;
                empresa.tx_Endereco.Enabled = habilita;
                empresa.tx_Num.Enabled = habilita;
                empresa.tx_Bairro.Enabled = habilita;
                empresa.tx_Cidade.Enabled = habilita;
                empresa.cmb_Estado.Enabled = habilita;
                empresa.tx_Pais.Enabled = habilita;
                empresa.mk_Tel1.Enabled = habilita;
                empresa.mk_Tel2.Enabled = habilita;
                empresa.tx_Email.Enabled = habilita;
                empresa.tx_Pessoa.Enabled = habilita;
                empresa.cmb_Descricao.Enabled = habilita;
                empresa.cmb_Situacao.Enabled = habilita;
                empresa.chk_Cliente.Enabled = habilita;
                empresa.chk_Fornecedor.Enabled = habilita;
                empresa.chk_Transportadora.Enabled = habilita;
                empresa.tx_Cod.BackColor = SystemColors.Window;
                empresa.mk_DataAlteracao.BackColor = SystemColors.Window;
            }
            else if (string.IsNullOrEmpty(empresa.tx_Cod.Text) && string.IsNullOrWhiteSpace(empresa.tx_Cod.Text) && habilita == true)
            { //novo cadastro
                empresa.OptPessoaF.Enabled = habilita;
                empresa.OptPessoaJ.Enabled = habilita;
                empresa.mk_CPF_CNPJ.Enabled = habilita;
                empresa.tx_RazaoSocial.Enabled = habilita;
                empresa.tx_Categoria.Enabled = habilita;
                empresa.tx_NomeFantasia.Enabled = habilita;
                empresa.mk_CEP.Enabled = habilita;
                empresa.tx_Endereco.Enabled = habilita;
                empresa.tx_Num.Enabled = habilita;
                empresa.tx_Bairro.Enabled = habilita;
                empresa.tx_Cidade.Enabled = habilita;
                empresa.cmb_Estado.Enabled = habilita;
                empresa.tx_Pais.Enabled = habilita;
                empresa.mk_Tel1.Enabled = habilita;
                empresa.mk_Tel2.Enabled = habilita;
                empresa.tx_Email.Enabled = habilita;
                empresa.tx_Pessoa.Enabled = habilita;
                empresa.cmb_Descricao.Enabled = habilita;
                empresa.cmb_Situacao.Enabled = habilita;
                empresa.chk_Cliente.Enabled = habilita;
                empresa.chk_Fornecedor.Enabled = habilita;
                empresa.chk_Transportadora.Enabled = habilita;
                empresa.tx_Cod.BackColor = Color.White;
                empresa.mk_DataAlteracao.BackColor = Color.White;
            }
            else if (!string.IsNullOrEmpty(empresa.tx_Cod.Text) && !string.IsNullOrWhiteSpace(empresa.tx_Cod.Text) && habilita == true)
            { //editar cadastro
                empresa.OptPessoaF.Enabled = !habilita;
                empresa.OptPessoaJ.Enabled = !habilita;
                empresa.mk_CPF_CNPJ.Enabled = habilita;
                empresa.tx_RazaoSocial.Enabled = habilita;
                empresa.tx_Categoria.Enabled = habilita;
                empresa.tx_NomeFantasia.Enabled = habilita;
                empresa.mk_CEP.Enabled = habilita;
                empresa.tx_Endereco.Enabled = habilita;
                empresa.tx_Num.Enabled = habilita;
                empresa.tx_Bairro.Enabled = habilita;
                empresa.tx_Cidade.Enabled = habilita;
                empresa.cmb_Estado.Enabled = habilita;
                empresa.tx_Pais.Enabled = habilita;
                empresa.mk_Tel1.Enabled = habilita;
                empresa.mk_Tel2.Enabled = habilita;
                empresa.tx_Email.Enabled = habilita;
                empresa.tx_Pessoa.Enabled = habilita;
                empresa.cmb_Descricao.Enabled = habilita;
                empresa.cmb_Situacao.Enabled = habilita;
                empresa.chk_Cliente.Enabled = habilita;
                empresa.chk_Fornecedor.Enabled = habilita;
                empresa.chk_Transportadora.Enabled = habilita;
                empresa.tx_Cod.BackColor = Color.White;
                empresa.mk_DataAlteracao.BackColor = Color.White;
            }
        }

        private void Limpar_campos(Empresas empresas)
        {
            empresas.tx_Cod.Text = null;
            empresas.mk_CPF_CNPJ.Text = null;
            empresas.tx_RazaoSocial.Text = null;
            empresas.tx_Categoria.Text = null;
            empresas.tx_NomeFantasia.Text = null;
            empresas.mk_CEP.Text = null;
            empresas.tx_Endereco.Text = null;
            empresas.tx_Num.Text = null;
            empresas.tx_Bairro.Text = null;
            empresas.tx_Cidade.Text = null;
            empresas.cmb_Estado.Text = null;
            empresas.tx_Pais.Text = null;
            empresas.mk_Tel1.Text = null;
            empresas.mk_Tel2.Text = null;
            empresas.tx_Email.Text = null;
            empresas.tx_Pessoa.Text = null;
            empresas.cmb_Descricao.Text = null;
            empresas.cmb_Situacao.Text = null;
            empresas.chk_Cliente.Checked = false;
            empresas.chk_Fornecedor.Checked = false;
            empresas.chk_Transportadora.Checked = false;
            empresas.tx_Cod.BackColor = Color.White;
            empresas.mk_DataAlteracao.BackColor = Color.White;
        }
        private void OptPessoaF_Click(object sender, EventArgs e)
        {
            TipoPessoa(this);
            Limpar_campos(this);
            Habilitar_campos(this, true);
        }

        private void OptPessoaJ_Click(object sender, EventArgs e)
        {
            TipoPessoa(this);
            Limpar_campos(this);
            Habilitar_campos(this, true);
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            Habilitar_campos(this, false);
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            OptPessoaF.Enabled = true;
            OptPessoaJ.Enabled = true;
            bt_Editar.Enabled = false;
            bt_BuscarId.Enabled = false;
            bt_ListarTodos.Enabled = false;
            bt_ListarEndereco.Enabled = false;
        }

        private void bt_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_Cod.Text) && string.IsNullOrWhiteSpace(tx_Cod.Text))
            {
                MessageBox.Show("Selecione um registro para editar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bt_Novo.Enabled = false;
                bt_BuscarId.Enabled = false;
                bt_ListarTodos.Enabled = false;
                bt_ListarEndereco.Enabled = false;
                Habilitar_campos(this, true);
            }

        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            Limpar_campos(this);
            Habilitar_campos(this, false);
            bt_Editar.Enabled = true;
            bt_BuscarId.Enabled = true;
            bt_ListarTodos.Enabled = true;
            bt_ListarEndereco.Enabled = true;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
