using System.Text;

namespace dioseries.Classes
{
    public class Filme : EntidadeBase
    {
        private int Ano { get; set; }
        private string Descricao { get; set; }
        private int DuracaoMinutos { get; set; }
        private EGenero Genero { get; set; }
        private string Titulo { get; set; }

        public Filme(int id, EGenero genero, string descricao, int duracao, string titulo,  int ano)
        {
            Ano = ano;
            Descricao = descricao;
            DuracaoMinutos = duracao;
            Genero = genero;
            Id = id;
            Titulo = titulo;
        }

        public override string RetornaDescricaoMenu() => $"{Titulo} - {DuracaoMinutos} minutos";

        public override string ToString() => new StringBuilder()
            .AppendLine($"Gênero: { Genero }")
            .AppendLine($"Titulo: { Titulo }")
            .AppendLine($"Duração: { DuracaoMinutos } minutos")
            .AppendLine($"Descrição: { Descricao }")
            .AppendLine($"Ano de Inicio: { Ano }")
            .AppendLine($"Excluido: { (Excluido ? "Sim" : "Não") }")
            .ToString();
    }
}
