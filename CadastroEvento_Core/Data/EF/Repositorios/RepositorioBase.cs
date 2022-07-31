using CadastroEvento_Core.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroEvento_Core.Entidades;
using System.Data.Entity;


namespace CadastroEvento_Core.Data.EF.Repositorios
{
    public class RepositorioBase<T> : IRepositorio<T> where T : EntidadeBase
    {
        //protected readonly MCDataContext ctx = new MCDataContext();

        public void Adicionar(T entidade)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Set<T>().Add(entidade);
                salvar(ctx);
            }
        }

        public void Atualizar(T entidade)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(entidade).State = EntityState.Modified;
                salvar(ctx);
            }
        }

        public void Excluir(T entidade)
        {
            using (DataContext ctx = new DataContext())
            {
                //ctx.Set<T>().Remove(entidade);
                ctx.Entry(entidade).State = EntityState.Deleted;
                salvar(ctx);
            }
        }

        public IList<T> GetAllEntities()
        {
            using (DataContext ctx = new DataContext())
            {
                IList<T> list = ctx.Set<T>().ToList();

                return list;
            }
        }

        public T GetEntityById(int id)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<T>().Find(id);
            }
        }

        private void salvar(DataContext ctx)
        {
            ctx.SaveChanges();
        }
    }
}
