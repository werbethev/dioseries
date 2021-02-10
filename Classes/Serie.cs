namespace dioseries.Classes
{
    public class Serie : Video
    {
        private int QuantTemporadas { get; set; }

        public Serie(int id, EGenero genero, string titulo, string descricao, int ano, int quantTemporadas)
            : base(id, genero, titulo, descricao, ano)
        {
            QuantTemporadas = quantTemporadas;
        }

        public override string RetornaDescricaoMenu() => $"{Titulo} - {QuantTemporadas} temporadas";

        public override string ToString() => ToString($"Temporadas: {QuantTemporadas}");
    }
}
