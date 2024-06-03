using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefas
{
    public partial class TelaAtualizacaoItemTarefaForm : Form
    {
        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<ItemTarefa>().ToList();
            }
        }

        public TelaAtualizacaoItemTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            labelTituloTarefa.Text = tarefaSelecionada.Titulo;

            CarregarItensSelecionados(tarefaSelecionada);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarItensSelecionados(Tarefa tarefaSelecionada)
        {
            int i = 0;

            foreach (ItemTarefa item in tarefaSelecionada.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }
    }
}