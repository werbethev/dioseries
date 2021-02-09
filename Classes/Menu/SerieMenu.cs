using System;

namespace dioseries.Classes.Menu
{
    public class SerieMenu
    {
        public static SerieRepositorio repositorio = new SerieRepositorio();
        public const string NomeEntidadeMenu = "série";


        public static void AtualizarSerie()
        {
            int idSerie = MenuConsole.PerguntarId(SerieMenu.NomeEntidadeMenu);

            foreach (int i in Enum.GetValues(typeof(EGenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(EGenero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int generoSelecionado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            var entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Inicio Série: ");
            var entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            var entradaDescricao = Console.ReadLine();

            var serie = new Serie(id: idSerie,
                                    genero: (EGenero)generoSelecionado,
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);

            SerieMenu.repositorio.Atualizar(serie);
        }

        public static void ExcluirSerie()
        {
            int idSerie = MenuConsole.PerguntarId(SerieMenu.NomeEntidadeMenu);
            SerieMenu.repositorio.Excluir(idSerie);
        }

        public static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(EGenero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(EGenero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int generoSelecionado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            var entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Inicio Série: ");
            var entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            var entradaDescricao = Console.ReadLine();

            var novaSerie = new Serie(id: SerieMenu.repositorio.ProximoId(),
                                      genero: (EGenero)generoSelecionado,
                                      titulo: entradaTitulo,
                                      ano: entradaAno,
                                      descricao: entradaDescricao);

            SerieMenu.repositorio.Inserir(novaSerie);
        }

        public static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = SerieMenu.repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                Console.WriteLine("ID {0}: - {1} {2}", serie.RetornaId(), serie.RetornaTitulo(), excluido ? " - *Excluido*" : "");
            }
        }

        public static string ObterOpcaoSelecionada()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            return Console.ReadLine().ToUpper();
        }

        public static void VisualizarSerie()
        {
            int idSerie = MenuConsole.PerguntarId(SerieMenu.NomeEntidadeMenu);
            Console.WriteLine(SerieMenu.repositorio.RetornaPorId(idSerie));
        }
    }
}
