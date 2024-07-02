using eAgenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinApp._2___ModuloContato
{
    public interface IRepositorioContatos
    {
        void Cadastrar(Contato novoContato);
        bool Editar(int id, Contato contatoEditado);
        bool Excluir(int id);
        Contato SelecionarPorId(int idSelecionado);
        List<Contato> SelecionarTodos();
    }
}
