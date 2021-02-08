using dioseries.Classes;
using System.Collections.Generic;

namespace dioseries.Interfaces
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(T entidade);
        int ProximoId();
    }
}
