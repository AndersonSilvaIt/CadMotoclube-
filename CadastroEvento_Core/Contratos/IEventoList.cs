using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEvento_Core.Entidades;

namespace CadastroEvento_Core.Contratos
{
    public interface IEventoList : IRepositorio<EventoList>
    {
        bool VerifyIfExistEventByYear(int year);
        EventoList FindEventoList(int entitiesListid);
    }
}
