using System.Text;

namespace dioseries.Classes
{
    public abstract class Video : EntidadeBase
    {
        protected int Ano { get; set; }
        protected string Descricao { get; set; }
        protected EGenero Genero { get; set; }
        protected string Titulo { get; set; }

        public Video(int id, EGenero genero, string titulo, string descricao, int ano)
        {
            Ano = ano;
            Genero = genero;
            Descricao = descricao;
            Id = id;
            Titulo = titulo;
        }

        public override abstract string RetornaDescricaoMenu();

        public string ToString(string complemento) => new StringBuilder()
            .AppendLine($"Gênero: { Genero }")
            .AppendLine($"Titulo: { Titulo }")
            .AppendLine($"Descrição: { Descricao }")
            .AppendLine($"Ano de Inicio: { Ano }")
            .AppendLine(complemento)
            .AppendLine($"Excluido: { (Excluido ? "Sim" : "Não") }")
            .ToString();
    }
}
