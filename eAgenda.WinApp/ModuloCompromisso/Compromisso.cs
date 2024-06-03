using eAgenda.ConsoleApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string Assunto { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }
        public Contato Contato { get; set; }

        public string Local { get; set; }
        public string Link { get; set; }

        public TipoCompromissoEnum TipoCompromisso
        {
            get
            {
                TipoCompromissoEnum TipoSelecionado;

                if (Local.Length == 0)
                    TipoSelecionado = TipoCompromissoEnum.Presencial;
                else
                    TipoSelecionado = TipoCompromissoEnum.Remoto;

                return TipoSelecionado;
            }
        }
        public Compromisso(string assunto, string local, string link, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            Link = link;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            Contato = contato;

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Data = atualizado.Data;
            Local = atualizado.Local;
            Link = atualizado.Link;
            HoraInicio = atualizado.HoraInicio;
            HoraTermino = atualizado.HoraTermino;
            Contato = atualizado.Contato;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto.Trim()))
                erros.Add("O campo \"Assunto\" é obrigatório.");

            if (string.IsNullOrEmpty(Local.Trim()))
                erros.Add("O campo \"Local\" é obrigatório");

            if (!string.IsNullOrEmpty(Link.Trim()) && !string.IsNullOrEmpty(Local.Trim()))
                erros.Add("Os campos \"Link e Local\" não podem ser preenchidos mutuamente.");

            if (HoraInicio > HoraTermino)
                erros.Add("O início do compromisso não pode ser depois da hora de termino.");

            if (HoraTermino < HoraInicio)
                erros.Add("O termino não pode ser antes do início do compromisso.");

            return erros;
        }

        public override string? ToString()
        {
            string nomeContato = Contato == null ? string.Empty : Contato.Nome;

            return $"Id: {Id}, Assunto: {Assunto}, Data: {Data.ToShortDateString()}, Início: {HoraInicio.ToString(@"hh\:mm")}, Término: {HoraTermino.ToString(@"hh\:mm")}, Contato: {nomeContato}, Tipo: {TipoCompromisso.ToString()}";
        }
    }
}
