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
    public partial class TelaFiltrarCompromissoForm : Form
    {

        public TipoFiltroCompromissosEnum filtroSelecionado { get; private set; }

        public DateTime InicioPeriodo
        {
            get
            {
                return dtInicio.Value;
            }
        }

        public DateTime TerminoPeriodo
        {
            get
            {
                return dtTermino.Value;
            }
        }

        public TelaFiltrarCompromissoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (rdbCompromissosPorPeriodo.Checked)
                filtroSelecionado = TipoFiltroCompromissosEnum.PorPeriodo;

            else if (rdbCompromissosPassados.Checked)
                filtroSelecionado = TipoFiltroCompromissosEnum.Passados;

            else if (rdbCompromissosFuturos.Checked)
                filtroSelecionado = TipoFiltroCompromissosEnum.Futuros;

            else
                filtroSelecionado = TipoFiltroCompromissosEnum.Todos;
        }

        private void rdbCompromissosPorPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCompromissosPorPeriodo.Checked)
            {
                dtInicio.Enabled = true;
                dtTermino.Enabled = true;
                lblInicio.Enabled = true;
                lblTermino.Enabled = true;
            }
            else
            {
                dtInicio.Enabled = false;
                dtTermino.Enabled = false;
                lblInicio.Enabled = false;
                lblTermino.Enabled = false;
            }

        }
    }
}
