using SistemaDeLocacoes.Telas.Locacoes;
using System.Net.Http.Headers;

namespace SistemaDeLocacoes
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            Empresas telaEmpresas = new Empresas();
            telaEmpresas.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos telaProdutos = new Produtos();
            telaProdutos.Show();
        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            InserirLocacoes telaLocacoes = new InserirLocacoes();
            telaLocacoes.Show();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            CobrarLocacoes telaCobranca = new CobrarLocacoes();
            telaCobranca.Show();
        }
    }
}
