using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroEvento_Core.Entidades
{
    [Table("Evento")]
    public class Evento : EntidadeBase
    {
        public string Motoclube { get; set; }
        public string Membro { get; set; }
        public string Presidente { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Fone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Trofeu { get; set; }

        public int EventoListId { get; set; }
        public virtual EventoList EventoList { get; set; }
    }
}
