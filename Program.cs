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
                switch (opcaoSelecionada)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        //Inserir();
                        break;
                    case "3":
                        //Atualizar
                        break;
                    case "4":
                        //Excluir
                        break;
                    case "5":
                        //Visualizar
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
                Console.WriteLine("ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
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
