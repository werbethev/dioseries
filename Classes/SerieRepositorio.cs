using dioseries.Interfaces;
using System.Collections.Generic;

namespace dioseries.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private readonly List<Serie> listaSerie;
        public SerieRepositorio()
        {
            listaSerie = new List<Serie>();
        }

        public void Atualizar(Serie serie)
        {
            if (serie != null && serie.Id >= 0)
                listaSerie[serie.Id] = serie;
        }

        public void Excluir(int id) => listaSerie?[id]?.Excluir();

        public void Inserir(Serie serie)
        {
            if (serie != null)
                listaSerie.Add(serie);
        }

        public List<Serie> Lista() => listaSerie;

        public int ProximoId() => listaSerie.Count;

        public Serie RetornaPorId(int id) => listaSerie[id];
    }
}
