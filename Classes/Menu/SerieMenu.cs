using System;

namespace dioseries.Classes.Menu
{
    public class SerieMenu
    {
        public static SerieRepositorio repositorio = new SerieRepositorio();
        public const string NomeEntidadeMenu = "série";

        private static void AtualizarSerie()
        {
            int idSerie = MenuConsole.PerguntarId(NomeEntidadeMenu);

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

            repositorio.Atualizar(serie);
        }

        private static void ExcluirSerie()
        {
            int idSerie = MenuConsole.PerguntarId(NomeEntidadeMenu);
            repositorio.Excluir(idSerie);
        }

        private static void InserirSerie()
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

            var novaSerie = new Serie(id: repositorio.ProximoId(),
                                      genero: (EGenero)generoSelecionado,
                                      titulo: entradaTitulo,
                                      ano: entradaAno,
                                      descricao: entradaDescricao);

            repositorio.Inserir(novaSerie);
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

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

        public static void MostrarMenuPrincipal()
        {
            string opcaoSelecionada;
            do
            {
                opcaoSelecionada = ObterOpcaoSelecionada();

                Console.WriteLine();
                switch (opcaoSelecionada)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Incorreta!");
                        Console.WriteLine("Tente Novamente!");
                        break;
                }


            } while (opcaoSelecionada != "X");
        }

        private static string ObterOpcaoSelecionada()
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

        private static void VisualizarSerie()
        {
            int idSerie = MenuConsole.PerguntarId(NomeEntidadeMenu);
            Console.WriteLine(repositorio.RetornaPorId(idSerie));
        }
    }
}
