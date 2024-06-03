using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {

        public delegate bool Filtro(Compromisso c);

        internal List<Compromisso> CompromissoPorPeriodo(DateTime inicio, DateTime fim)
        {
            return registros.FindAll(c => c.Data >= inicio && c.Data <= fim);
        }
        internal List<Compromisso> CompromissosFuturos()
        {
            return registros.FindAll(c => c.Data >= DateTime.Today);
        }
        internal List<Compromisso> CompromissosPassados()
        {
            return registros.FindAll(c => c.Data < DateTime.Today);
        }

        public List<Compromisso> SelecionarFuturos()
        {
            Filtro metodoFiltro = FiltrarFuturos;

            return Filtrar(metodoFiltro);
        }
        private bool FiltrarFuturos(Compromisso c)
        {
            return c.Data > DateTime.Today;
        }

        public List<Compromisso> SelecionarPassados()
        {
            Filtro metodoFiltro = FiltrarPassados;

            return Filtrar(metodoFiltro);
        }
        public bool FiltrarPassados(Compromisso c)
        {
            return c.Data < DateTime.Today;
        }

        public List<Compromisso> Filtrar(Filtro filtro)
        {
            List<Compromisso> compromissosFiltrados = new List<Compromisso>();

            foreach (Compromisso c in registros)
            {
                if (filtro(c))
                    compromissosFiltrados.Add(c);
            }

            return compromissosFiltrados;
        }
    }
}
