using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        RepositorioContato repositorioContato;
        TabelaContatoControl TabelaContatos;

        public ControladorContato(RepositorioContato repositorio)
        {
            repositorioContato = repositorio;
        }

        public override string TipoCadastro { get { return "Contatos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo contato"; } }

        public override string ToolTipEditar { get { return "Editar um contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um contato existente"; } }

        public override void Adicionar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Contato novoContato = telaContato.Contato;

            repositorioContato.Cadastrar(novoContato);

            CarregarContatos();
        }
        public override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            int idSelecionado = TabelaContatos.ObterRegistroSelecionado();

            Contato contatoSelecionado = repositorioContato.SelecionarPorId(idSelecionado);

            if (contatoSelecionado == null)
            {
                MessageBox.Show(
                                 "Não é possível realizar esta ação sem um registro selecionado.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            ); return;
            }

            telaContato.Contato = contatoSelecionado;
            DialogResult resultado = telaContato.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Contato contatoEditado = telaContato.Contato;

            repositorioContato.Editar(contatoSelecionado.Id, contatoEditado);
            CarregarContatos();

        }

        public override void Excluir()
        {
            int idSelecionado = TabelaContatos.ObterRegistroSelecionado();

            Contato contatoSelecionado = repositorioContato.SelecionarPorId(idSelecionado);

            if (contatoSelecionado == null)
            {
                MessageBox.Show(
                                 "Não é possível realizar esta ação sem um registro selecionado.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            ); return;
            }

            if (contatoSelecionado == null)
            {
                MessageBox.Show("Não é possivel realizar a ação sem um registro selecionado.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{contatoSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            repositorioContato.Excluir(contatoSelecionado.Id);
            CarregarContatos();


        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            TabelaContatos.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (TabelaContatos == null)
                TabelaContatos = new TabelaContatoControl();

            CarregarContatos();

            return TabelaContatos;
        }

    }
}
