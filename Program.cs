using dioseries.Classes;
using System;

namespace dioseries
{
    class Program
    {
        private static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            var opcaoSelecionada = ObterOpcaoSelecionada();

            while (opcaoSelecionada != "X")
            {
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
                opcaoSelecionada = ObterOpcaoSelecionada();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(idSerie);

            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(idSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int idSerie = int.Parse(Console.ReadLine());

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

        public static void ListarSeries()
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
                Console.WriteLine("ID {0}: - {1} {2}", serie.RetornaId(), serie.retornaTitulo(), excluido ? " - *Excluido*" : "");
            }
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

            var novaSerie = new Serie(id: repositorio.ProximoId(),
                                      genero: (EGenero)generoSelecionado,
                                      titulo: entradaTitulo,
                                      ano: entradaAno,
                                      descricao: entradaDescricao);

            repositorio.Inserir(novaSerie);
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
    }
}
