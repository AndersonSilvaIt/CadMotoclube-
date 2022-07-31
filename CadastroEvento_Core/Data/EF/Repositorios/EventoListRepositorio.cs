using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEvento_Core.Entidades;
using CadastroEvento_Core.Contratos;

namespace CadastroEvento_Core.Data.EF.Repositorios
{
    public class EventoListRepositorio : RepositorioBase<EventoList>, IEventoList
    {
        public bool VerifyIfExistEventByYear(int year)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.EventoList.Any(p => p.Ano == year);
            }
        }

        public EventoList FindEventoList(int id)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.EventoList.Include("Eventos").FirstOrDefault(p => p.Id == id);
            }
        }

    }
}
