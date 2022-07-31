using System.Collections.Generic;
using CadastroEvento_Core.Entidades;

namespace CadastroEvento_Core.Contratos
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
        IList<T> GetAllEntities();
        T GetEntityById(int id);
    }
}
