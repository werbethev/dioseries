using dioseries.Classes;
using System.Collections.Generic;

namespace dioseries.Interfaces
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        void Atualizar(T entidade);
        void Excluir(int id);
        void Inserir(T entidade);
        List<T> Lista();
        int ProximoId();
        T RetornaPorId(int id);
    }
}
