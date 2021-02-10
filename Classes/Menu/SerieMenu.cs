using dioseries.Classes.Repositorios;
using System;

namespace dioseries.Classes.Menu
{
    public class SerieMenu : VideoMenu<Serie>
    {
        public SerieMenu(): base(new SerieRepositorio(), "Série") { }

        protected override Serie Criar(int id)
        {
            foreach (int i in Enum.GetValues(typeof(EGenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(EGenero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int generoSelecionado = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Título da Série: ");
            var entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Inicio Série: ");
            var entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            var entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de temporadas da Série: ");
            var entradaQuantTemporada = Convert.ToInt32(Console.ReadLine());

            return new Serie(id, (EGenero)generoSelecionado, entradaTitulo,
                                    entradaDescricao, entradaAno, entradaQuantTemporada);
        }
    }
}
