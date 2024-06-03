using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase, IControladorFiltravel
    {
        private TabelaCompromissoControl tabelaCompromisso;

        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;

        public override string TipoCadastro { get { return "Compromissos"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um compromisso existente"; } }

        public string ToolTipFiltrar { get { return "Filtrar Compromissos"; } }

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            List<Contato> contatosCadastrados = repositorioContato.SelecionarTodos();

            telaCompromisso.CarregarContatos(contatosCadastrados);

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso novoCompromisso = telaCompromisso.Compromisso;

            repositorioCompromisso.Cadastrar(novoCompromisso);

            CarregarCompromissos();
        }

        public override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            List<Contato> contatosCadastrados = repositorioContato.SelecionarTodos();

            telaCompromisso.CarregarContatos(contatosCadastrados);

            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            Compromisso compromissoSelecionado =
                repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (compromissoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCompromisso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Compromisso compromissoEditado = telaCompromisso.Compromisso;

            repositorioCompromisso.Editar(compromissoSelecionado.Id, compromissoEditado);

            CarregarCompromissos();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            Compromisso compromissoSelecionado =
                repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (compromissoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{compromissoSelecionado.Assunto}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado != DialogResult.Yes)
                return;

            repositorioCompromisso.Excluir(compromissoSelecionado.Id);

            CarregarCompromissos();

        }

        public void Filtrar()
        {
            TelaFiltrarCompromissoForm telaFiltrar = new TelaFiltrarCompromissoForm();

            DialogResult resultado = telaFiltrar.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            TipoFiltroCompromissosEnum filtroSelecionado = telaFiltrar.filtroSelecionado;

            List<Compromisso> compromissosSelecionados;

            if (filtroSelecionado == TipoFiltroCompromissosEnum.Passados)
                compromissosSelecionados = repositorioCompromisso.SelecionarPassados();

            else if (filtroSelecionado == TipoFiltroCompromissosEnum.Futuros)
                compromissosSelecionados = repositorioCompromisso.SelecionarFuturos();
            else if (filtroSelecionado == TipoFiltroCompromissosEnum.PorPeriodo)
            {
                DateTime PeriodoInicial = telaFiltrar.InicioPeriodo;
                DateTime PeriodoFinal = telaFiltrar.TerminoPeriodo;

                compromissosSelecionados = repositorioCompromisso.CompromissoPorPeriodo(PeriodoInicial, PeriodoFinal);
            }
            else
            {
                compromissosSelecionados = repositorioCompromisso.SelecionarTodos();
            }

            tabelaCompromisso.AtualizarRegistros(compromissosSelecionados);

        }

        public override UserControl ObterListagem()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }
    }
}