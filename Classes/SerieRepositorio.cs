using dioseries.Interfaces;
using System;
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

        public void Atualiza(int id, Serie serie)
        {
            if (serie != null)
                listaSerie[id] = serie;
        }

        public void Exclui(int id) => listaSerie?[id]?.Excluir();

        public void Insere(Serie serie)
        {
            if (serie != null)
                listaSerie.Add(serie);
        }

        public List<Serie> Lista() => listaSerie;

        public int ProximoId() => listaSerie.Count;

        public Serie RetornaPorId(int id) => listaSerie[id];
    }
}
