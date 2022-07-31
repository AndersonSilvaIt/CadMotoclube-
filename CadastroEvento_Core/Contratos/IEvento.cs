using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEvento_Core.Entidades;

namespace CadastroEvento_Core.Contratos
{
    public interface IEvento : IRepositorio<Evento>
    {
        IList<Evento> GetEventosByEventosListId(int id);
        IList<Evento> SearchEvento(string mc, string pres, string cidade, string membro, string uf, string trofeu, int eventoListId);
    }
}
