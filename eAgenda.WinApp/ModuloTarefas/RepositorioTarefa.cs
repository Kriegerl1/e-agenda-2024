using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloTarefas
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public void AdicionarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach (ItemTarefa item in itens)
                tarefaSelecionada.AdicionarItem(item);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada, List<ItemTarefa> itensPendentes, List<ItemTarefa> itensConcluidos)
        {
            foreach (ItemTarefa i in itensPendentes)
                tarefaSelecionada.MarcarPendente(i);

            foreach (ItemTarefa i in itensConcluidos)
                tarefaSelecionada.ConcluirItem(i);
        }
    }
}
