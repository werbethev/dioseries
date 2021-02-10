namespace dioseries.Classes
{
    public class Filme : Video
    {
        private int DuracaoMinutos { get; set; }

        public Filme(int id, EGenero genero, string descricao, int duracao, string titulo,  int ano)
            : base(id, genero, titulo, descricao, ano)
        {
            DuracaoMinutos = duracao;
        }

        public override string RetornaDescricaoMenu() => $"{Titulo} - {DuracaoMinutos} minutos";

        public override string ToString() => ToString($"Duração: {DuracaoMinutos} minutos");
    }
}
