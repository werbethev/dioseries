using dioseries.Enum;
using System.Text;

namespace dioseries.Classes
{
    public class Serie : EntidadeBase
    {
        private int Ano { get;  set; }
        private string Descricao { get; set; }
        private eGenero Genero{ get; set; }
        private string Titulo { get; set; }

        public Serie(int id, eGenero genero, string titulo, string descricao, int ano)
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
            .ToString();

        public string retornaTitulo() => this.Titulo;
        public int retornaId() => this.Id;
    }
}
