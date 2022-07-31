using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEvento_Core.Entidades
{
    [Table("EventoList")]
    public class EventoList : EntidadeBase
    {
        public int Ano { get; set; }
        public int Aniversario { get; set; }

        public string Texto { get; set; }

        public virtual IList<Evento> Eventos { get; set; }
    }
}
