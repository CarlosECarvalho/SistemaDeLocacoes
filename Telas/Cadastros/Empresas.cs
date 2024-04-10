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
        private void OptPessoaF_Click(object sender, EventArgs e)
        {
            TipoPessoa(this);
        }

        private void OptPessoaJ_Click(object sender, EventArgs e)
        {
            TipoPessoa(this);
        }
    }
}
