using System.Collections.Generic;
using System.Data.Entity;
using CadastroEvento_Core.Entidades;

namespace CadastroEvento_Core.Data.EF
{
    public class DBInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            //var agenda =  new EntidadeAgenda() { Descricao = "Agenda01", Observacao = "Obs01" };

            //context.Agenda.Add(agenda);
            //context.SaveChanges();
        }
    }
}
