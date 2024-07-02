using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp._1___Compartilhado
{
    public interface IControladorSubItens
    {
        string ToolTipAdicionarItens { get; }
        string ToolTipConcluirItens { get; }
        void AdicionarItens();
        void AtualizarItens();
    }
}
