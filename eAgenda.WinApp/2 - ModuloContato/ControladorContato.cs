using eAgenda.WinApp._2___ModuloContato;
using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private TabelaContatoControl tabelaContato;

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

            if (resultado == DialogResult.OK)
            {
                Contato novoContato = telaContato.Contato;

                repositorioContato.Cadastrar(novoContato);

                CarregarContatos();
            }
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaContato.ObterRegistroSelecionado();

            Contato contatoSelecionado = repositorioContato.SelecionarPorId(idSelecionado);




        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }
        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemContato == null)
                listagemContato = new ListagemContatoControl();

            CarregarContatos();

            return listagemContato;
        }


    }
}
