using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.Compartilhado
{
    public static class DataViewGridExtensions
    {

        public static int SelecionarId(this DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return -1;

            object valorSelecionado = grid
                .SelectedRows[0]
                .Cells[0]
                .Value;

            if (valorSelecionado == null)
                return -1;

            return (int)valorSelecionado;
        }
    }
}
