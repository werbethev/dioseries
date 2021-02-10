using dioseries.Interfaces;
using System.Collections.Generic;

namespace dioseries.Classes.Repositorios
{
    public abstract class RepositorioBase<TEntidade> : IRepositorio<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly List<TEntidade> listaRepositorio;

        public RepositorioBase()
        {
            listaRepositorio = new List<TEntidade>();
        }

        public void Atualizar(TEntidade entidade)
        {
            if (entidade != null && entidade.Id >= 0)
                listaRepositorio[entidade.Id] = entidade;
        }

        public void Excluir(int id) => listaRepositorio?[id]?.Excluir();

        public void Inserir(TEntidade entidade)
        {
            if (entidade != null)
                listaRepositorio.Add(entidade);
        }

        public List<TEntidade> Lista() => listaRepositorio;

        public int ProximoId() => listaRepositorio.Count;

        public TEntidade RetornaPorId(int id) => listaRepositorio[id];
    }
}
