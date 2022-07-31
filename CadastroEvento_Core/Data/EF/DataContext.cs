using System.Data.Entity;
using CadastroEvento_Core.Entidades;

namespace CadastroEvento_Core.Data.EF
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DbCadastro")
        {
            Database.SetInitializer<DataContext>(new DBInitializer());
            //this.Configuration.LazyLoadingEnabled = true;
        }
        
        public DbSet<EventoList> EventoList { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Motoclube> Motoclube { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
