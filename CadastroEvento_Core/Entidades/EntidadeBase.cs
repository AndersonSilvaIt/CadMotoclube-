using System;

namespace CadastroEvento_Core.Entidades
{
    public abstract class EntidadeBase
    {
        public EntidadeBase()
        {
            DataCadastro = DateTime.Now;
        }


        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}