using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEvento_Core.Contratos;
using CadastroEvento_Core.Entidades;
using CadastroEvento_Core.Data.EF.Repositorios;

namespace CadastroEvento_Core.Data.EF.Repositorios
{
    public class EventoRepositorio : RepositorioBase<Evento>, IEvento
    {
        public IList<Evento> GetEventosByEventosListId(int eventoListId)
        {
            List<Evento> listEvento = new List<Evento>();

            using (DataContext ctx = new DataContext())
            {
                listEvento = ctx.Evento.Where(p => p.EventoListId == eventoListId).ToList();
                return listEvento;
            }
        }

        public IList<Evento> SearchEvento(string mc, string pres, string cidade, string membro, string uf, string trofeu, int eventoListId)
        {
            using (DataContext ctx = new DataContext())
            {
                var a = ctx.Evento.AsQueryable().Where(p => p.EventoListId == eventoListId);

                if (!string.IsNullOrWhiteSpace(mc.Trim()))
                    a = a.Where(p => p.Motoclube.ToUpper().Contains(mc.ToUpper()));

                if (!string.IsNullOrWhiteSpace(pres.Trim()))
                    a = a.Where(p => p.Presidente.ToUpper().Contains(pres.ToUpper()));

                if (!string.IsNullOrWhiteSpace(cidade.Trim()))
                    a = a.Where(p => p.Cidade.ToUpper().Contains(cidade.ToUpper()));

                if (!String.IsNullOrWhiteSpace(membro.Trim()))
                    a = a.Where(p => p.Membro.ToUpper().Contains(membro.ToUpper()));

                if (!string.IsNullOrWhiteSpace(uf))
                    a = a.Where(p => p.UF == uf);

                if (!string.IsNullOrWhiteSpace(trofeu))
                    a = a.Where(p => p.Trofeu == trofeu);


                return a.ToList();
            }
        }
    }
}
