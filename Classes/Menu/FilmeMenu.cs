using dioseries.Classes.Repositorios;
using System;

namespace dioseries.Classes.Menu
{
    public class FilmeMenu : VideoMenu<Filme>
    {
        public FilmeMenu() : base(new FilmeRepositorio(), "Filme") { }

        protected override Filme Criar(int id)
        {
            foreach (int i in Enum.GetValues(typeof(EGenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(EGenero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int generoSelecionado = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Título do Filme: ");
            var entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Inicio Filme: ");
            var entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição do Filme: ");
            var entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite a Duração do Filme: ");
            var entradaDuracao = Convert.ToInt32(Console.ReadLine());

            return new Filme(id, (EGenero)generoSelecionado, entradaDescricao, entradaDuracao, entradaTitulo, entradaAno);
        }
    }
}
