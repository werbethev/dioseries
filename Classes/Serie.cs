using System.Text;

namespace dioseries.Classes
{
    public class Serie : EntidadeBase
    {
        private int Ano { get;  set; }
        private string Descricao { get; set; }
        private EGenero Genero{ get; set; }
        private string Titulo { get; set; }
        public bool Excluido { get; set; }

        public Serie(int id, EGenero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public override string ToString() => new StringBuilder()
            .AppendFormat("Gênero: ", Genero).AppendLine()
            .AppendFormat("Titulo: ", Titulo).AppendLine()
            .AppendFormat("Descrição: ", Descricao).AppendLine()
            .AppendFormat("Ano de Inicio: ", Ano).AppendLine()
            .AppendFormat("Excluido: ", Excluido ? "Sim" : "Não").AppendLine()
            .ToString();

        public string retornaTitulo() => Titulo;
        public int retornaId() => Id;
        public bool Excluir() => Excluido = true;
    }
}
