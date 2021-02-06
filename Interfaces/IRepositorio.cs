﻿using System.Collections.Generic;

namespace dioseries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int ind);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
