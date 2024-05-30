using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());


        }


        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();

            foreach (Compromisso c in compromissos)
                grid.Rows.Add(
                    c.Id,
                    c.Assunto,
                    c.Data.ToShortDateString(),
                    c.HoraInicio.ToString(@"hh\:mm"),
                    c.HoraTermino.ToString(@"hh\:mm"),
                    c.Contato);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();

        }
        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "HoraInicio", HeaderText = "Início" },
                new DataGridViewTextBoxColumn { DataPropertyName = "HoraTermino", HeaderText = "Fim" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Contato", HeaderText = "Contato" }
            };
        }
    }
}
