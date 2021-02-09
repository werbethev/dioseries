using System.Text;

namespace dioseries.Classes
{
    public class Serie : EntidadeBase
    {
        private int Ano { get;  set; }
        private string Descricao { get; set; }
        private EGenero Genero{ get; set; }
        private string Titulo { get; set; }

        public Serie(int id, EGenero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public override string ToString() => new StringBuilder()
            .AppendLine($"Gênero: { Genero }")
            .AppendLine($"Titulo: { Titulo }")
            .AppendLine($"Descrição: { Descricao }")
            .AppendLine($"Ano de Inicio: { Ano }")
            .AppendLine($"Excluido: { (Excluido ? "Sim" : "Não") }")
            .ToString();

        public override string RetornaDescricaoMenu() => Titulo;
    }
}
